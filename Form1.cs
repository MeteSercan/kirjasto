using MySql.Data.MySqlClient;
using System.Data;

namespace kirjasto_ohjelma5
{
    public partial class Form1 : Form
    {
        static string connectionString = "Server=bldt4ttrlyjhgcfqm71e-mysql.services.clever-cloud.com;Port=3306;Database=bldt4ttrlyjhgcfqm71e;User ID=uvb0p7i37m52cqi3;Password=HjTnGLulPmx71V7ZggUO;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string customerId = palautakirja_asiakas_numero.Text.Trim();
            string isbn = palautakirja_isbn.Text.Trim();

            if (string.IsNullOrEmpty(customerId) || string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Syötä Kaikki Kennät.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the book is borrowed by the customer
                    string checkBorrowQuery = @"SELECT L.lainanum 
                                                FROM Lainaus L
                                                JOIN Lainauskirja LK ON L.lainanum = LK.lainanum
                                                WHERE L.astun = @customerId AND LK.isbn = @isbn";
                    MySqlCommand checkBorrowCmd = new MySqlCommand(checkBorrowQuery, conn);
                    checkBorrowCmd.Parameters.AddWithValue("@customerId", customerId);
                    checkBorrowCmd.Parameters.AddWithValue("@isbn", isbn);
                    object lainaNumResult = checkBorrowCmd.ExecuteScalar();

                    if (lainaNumResult == null)
                    {
                        MessageBox.Show("Käyttäjällä ei ole lainauksia löyty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string lainaNum = lainaNumResult.ToString();

                    // Proceed to return the book
                    string deleteLainausKirjaQuery = "DELETE FROM Lainauskirja WHERE lainanum = @lainanum AND isbn = @isbn";
                    MySqlCommand deleteLainausKirjaCmd = new MySqlCommand(deleteLainausKirjaQuery, conn);
                    deleteLainausKirjaCmd.Parameters.AddWithValue("@lainanum", lainaNum);
                    deleteLainausKirjaCmd.Parameters.AddWithValue("@isbn", isbn);
                    deleteLainausKirjaCmd.ExecuteNonQuery();

                    // If no more books are linked to this loan, delete the loan record
                    string checkRemainingBooksQuery = "SELECT COUNT(*) FROM Lainauskirja WHERE lainanum = @lainanum";
                    MySqlCommand checkRemainingBooksCmd = new MySqlCommand(checkRemainingBooksQuery, conn);
                    checkRemainingBooksCmd.Parameters.AddWithValue("@lainanum", lainaNum);
                    int remainingBooks = Convert.ToInt32(checkRemainingBooksCmd.ExecuteScalar());

                    if (remainingBooks == 0)
                    {
                        string deleteLainausQuery = "DELETE FROM Lainaus WHERE lainanum = @lainanum";
                        MySqlCommand deleteLainausCmd = new MySqlCommand(deleteLainausQuery, conn);
                        deleteLainausCmd.Parameters.AddWithValue("@lainanum", lainaNum);
                        deleteLainausCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Palautus ", "Onnistuu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kaikki_kirjat_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Kirja";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void kirjailijat_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Kirjailija";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView2.DataSource = table;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private string GenerateNewLainaNum(MySqlConnection conn)
        {
            string query = "SELECT IFNULL(MAX(lainanum), 0) + 1 FROM Lainaus";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            return cmd.ExecuteScalar().ToString();
        }

        private void Laina_kirja_Click(object sender, EventArgs e)
        {
            string customerId = Lainakirja_asiakas_numero.Text.Trim();
            string isbn = Lainakirja_isbn.Text.Trim();

            if (string.IsNullOrEmpty(customerId) || string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Täyttä Kaikki Kennät.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if customer exists
                    string checkCustomerQuery = "SELECT COUNT(*) FROM Asiakas WHERE asnum = @customerId";
                    MySqlCommand checkCustomerCmd = new MySqlCommand(checkCustomerQuery, conn);
                    checkCustomerCmd.Parameters.AddWithValue("@customerId", customerId);
                    int customerExists = Convert.ToInt32(checkCustomerCmd.ExecuteScalar());

                    if (customerExists == 0)
                    {
                        MessageBox.Show("Käyttäjä Ei Löyty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if book exists
                    string checkBookQuery = "SELECT COUNT(*) FROM Kirja WHERE isbn = @isbn";
                    MySqlCommand checkBookCmd = new MySqlCommand(checkBookQuery, conn);
                    checkBookCmd.Parameters.AddWithValue("@isbn", isbn);
                    int bookExists = Convert.ToInt32(checkBookCmd.ExecuteScalar());

                    if (bookExists == 0)
                    {
                        MessageBox.Show("ISBN ei löyty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Proceed to borrow the book
                    string newLainaNum = GenerateNewLainaNum(conn);
                    string insertLainausQuery = "INSERT INTO Lainaus (lainanum, astun, pvm) VALUES (@lainanum, @customerId, NOW())";
                    MySqlCommand insertLainausCmd = new MySqlCommand(insertLainausQuery, conn);
                    insertLainausCmd.Parameters.AddWithValue("@lainanum", newLainaNum);
                    insertLainausCmd.Parameters.AddWithValue("@customerId", customerId);
                    insertLainausCmd.ExecuteNonQuery();

                    string insertLainausKirjaQuery = "INSERT INTO Lainauskirja (isbn, lainanum) VALUES (@isbn, @lainanum)";
                    MySqlCommand insertLainausKirjaCmd = new MySqlCommand(insertLainausKirjaQuery, conn);
                    insertLainausKirjaCmd.Parameters.AddWithValue("@isbn", isbn);
                    insertLainausKirjaCmd.Parameters.AddWithValue("@lainanum", newLainaNum);
                    insertLainausKirjaCmd.ExecuteNonQuery();

                    MessageBox.Show("Kirjan Laina Onnistuu!","Succees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Lainatut_kirjat_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT L.lainanum, L.pvm, K.nimi AS KirjanNimi, A.enimi AS AsiakasEnimi, A.snimi AS AsiakasSnimi
                                     FROM Lainaus L
                                     JOIN Lainauskirja LK ON L.lainanum = LK.lainanum
                                     JOIN Kirja K ON LK.isbn = K.isbn
                                     JOIN Asiakas A ON L.astun = A.asnum";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView3.DataSource = table;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void admin_menu_Click(object sender, EventArgs e)
        {
            
            string inputPassword = Microsoft.VisualBasic.Interaction.InputBox("Syötä Admin Salasana:", "Admin Login", "", -1, -1);

            
            if (inputPassword == "123")
            {
                
                Form2 adminForm = new Form2();
                adminForm.ShowDialog();
            }
            else
            {
                
                MessageBox.Show("Väärin Salasana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}