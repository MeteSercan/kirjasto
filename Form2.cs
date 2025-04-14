using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kirjasto_ohjelma5
{
    public partial class Form2 : Form
    {
        static string connectionString = "Server=localhost;Port=3306;Database=kirjasto;User ID=root;Password=123;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Nayta_Lainaukset_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Lainaus";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewLainaukset.DataSource = table;  // Assuming dataGridViewLainaukset is the DataGridView for displaying loans
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Nayta_Asiakkaat_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Asiakas";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView2.DataSource = table;  // Assuming dataGridViewAsiakas is the DataGridView for displaying Asiakas
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Lisaa_asiakas_Click(object sender, EventArgs e)
        {
            Form3 adminForm = new Form3();
            adminForm.ShowDialog();
        }

        private void Poista_asiakas_Click(object sender, EventArgs e)
        {
            // Prompt for Customer ID (asiakastunnus)
            string customerId = Microsoft.VisualBasic.Interaction.InputBox("Syötä poistettavan asiakkaan tunnus:", "Poista Asiakas", "", -1, -1);

            // Check if Customer ID was entered
            if (string.IsNullOrEmpty(customerId))
            {
                MessageBox.Show("Asiakastunnus on pakollinen.", "Virhe syötteessä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Asiakastunnusta ei löytynyt tietokannasta.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Delete customer
                    string deleteCustomerQuery = "DELETE FROM Asiakas WHERE asnum = @customerId";
                    MySqlCommand deleteCustomerCmd = new MySqlCommand(deleteCustomerQuery, conn);
                    deleteCustomerCmd.Parameters.AddWithValue("@customerId", customerId);
                    deleteCustomerCmd.ExecuteNonQuery();

                    MessageBox.Show("Asiakas poistettu onnistuneesti!", "Onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe: " + ex.Message, "Tietokantavirhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Poistu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lisaa_kirjailija_Click(object sender, EventArgs e)
        {
            Form4 adminForm = new Form4();
            adminForm.ShowDialog();
        }

        private void Lisaa_kirja_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.Show();
        }
    }
}






