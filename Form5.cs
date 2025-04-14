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
    public partial class Form5 : Form
    {
        static string connectionString = "Server=localhost;Port=3306;Database=kirjasto;User ID=root;Password=123;";
        public Form5()
        {
            InitializeComponent();
        }

        private void Nayta_kirja_Click(object sender, EventArgs e)
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
                    dataGridViewKirjat.DataSource = table;  // Assuming dataGridKirjat is the DataGridView for displaying books
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe: " + ex.Message, "Tietokantavirhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Lisaa_kirja_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            string authorId = txtAuthorID.Text.Trim();
            string title = txtTitle.Text.Trim();
            string publicationYear = txtYear.Text.Trim();
            string pageCount = txtPages.Text.Trim();

            if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(authorId) || string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Täytä kaikki pakolliset kentät: ISBN, Kirjailijan tunnus, ja Kirjan nimi.", "Syöttövirhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the author exists in Kirjailija table
                    string checkAuthorQuery = "SELECT COUNT(*) FROM Kirjailija WHERE kirtunnus = @kirtunnus";
                    MySqlCommand checkCmd = new MySqlCommand(checkAuthorQuery, conn);
                    checkCmd.Parameters.AddWithValue("@kirtunnus", authorId);
                    int authorExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (authorExists == 0)
                    {
                        MessageBox.Show("Kirjailijan tunnusta ei löytynyt tietokannasta.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert the new book
                    string query = "INSERT INTO Kirja (isbn, kirtu, nimi, julkaistu, sivut) VALUES (@isbn, @kirtunnus, @nimi, @julkaistu, @sivut)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@kirtunnus", authorId);
                    cmd.Parameters.AddWithValue("@nimi", title);
                    cmd.Parameters.AddWithValue("@julkaistu", publicationYear);
                    cmd.Parameters.AddWithValue("@sivut", pageCount);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kirja lisätty onnistuneesti!", "Onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBookFields();  // Clear input fields after successful insertion
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe: " + ex.Message, "Tietokantavirhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        // Clear the textboxes after adding the book
        private void ClearBookFields()
        {
            txtISBN.Clear();
            txtAuthorID.Clear();
            txtTitle.Clear();
            txtYear.Clear();
            txtPages.Clear();
        }

        private void Poista_kirja_Click(object sender, EventArgs e)
        {
            // Prompt for the ISBN
            string isbn = Microsoft.VisualBasic.Interaction.InputBox("Syötä poistettavan kirjan ISBN:", "Poista Kirja", "", -1, -1);

            // Check if ISBN was entered
            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("ISBN on pakollinen.", "Syöttövirhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the book exists
                    string checkBookQuery = "SELECT COUNT(*) FROM Kirja WHERE isbn = @isbn";
                    MySqlCommand checkBookCmd = new MySqlCommand(checkBookQuery, conn);
                    checkBookCmd.Parameters.AddWithValue("@isbn", isbn);
                    int bookExists = Convert.ToInt32(checkBookCmd.ExecuteScalar());

                    if (bookExists == 0)
                    {
                        MessageBox.Show("ISBN ei löytynyt tietokannasta.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Delete the book
                    string deleteBookQuery = "DELETE FROM Kirja WHERE isbn = @isbn";
                    MySqlCommand deleteBookCmd = new MySqlCommand(deleteBookQuery, conn);
                    deleteBookCmd.Parameters.AddWithValue("@isbn", isbn);
                    deleteBookCmd.ExecuteNonQuery();

                    MessageBox.Show("Kirja poistettu onnistuneesti!", "Onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe: " + ex.Message, "Tietokantavirhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Takaisin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
