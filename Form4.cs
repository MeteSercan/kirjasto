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
    public partial class Form4 : Form
    {
        static string connectionString = "Server=localhost;Port=3306;Database=kirjasto;User ID=root;Password=123;";
        public Form4()
        {
            InitializeComponent();
        }

        private void Nayta_kirjailija_Click(object sender, EventArgs e)
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
                    dataGridViewKirjailijat.DataSource = table;  // Assuming dataGridViewKirjailijat is the DataGridView for displaying authors
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe: " + ex.Message, "Tietokantavirhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Lisaa_kirjailija_Click(object sender, EventArgs e)
        {
            // Retrieve data from the textboxes
            string authorId = kirtu.Text.Trim();
            string firstName = enimi.Text.Trim();
            string lastName = snimi.Text.Trim();

            // Validate that all fields are filled
            if (string.IsNullOrEmpty(authorId) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Täytä kaikki kentät: Kirjailijan tunnus, etunimi ja sukunimi.", "Syöttövirhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert the data into the database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Kirjailija (kirtunnus, enimi, snimi) VALUES (@kirtunnus, @enimi, @snimi)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kirtunnus", authorId);
                    cmd.Parameters.AddWithValue("@enimi", firstName);
                    cmd.Parameters.AddWithValue("@snimi", lastName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kirjailija lisätty onnistuneesti!", "Onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAuthorFields();  // Clear input fields after successful insertion
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe: " + ex.Message, "Tietokantavirhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Clear the textboxes after adding the author
        private void ClearAuthorFields()
        {
            kirtu.Clear();
            enimi.Clear();
            snimi.Clear();
        }

        private void Poista_kirjailija_Click(object sender, EventArgs e)
        {
            // Prompt for the author ID (kirtunnus)
            string authorId = Microsoft.VisualBasic.Interaction.InputBox("Syötä poistettavan kirjailijan tunnus:", "Poista Kirjailija", "", -1, -1);

            // Check if an author ID was entered
            if (string.IsNullOrEmpty(authorId))
            {
                MessageBox.Show("Kirjailijan tunnus on pakollinen.", "Syöttövirhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the author exists
                    string checkAuthorQuery = "SELECT COUNT(*) FROM Kirjailija WHERE kirtunnus = @kirtunnus";
                    MySqlCommand checkAuthorCmd = new MySqlCommand(checkAuthorQuery, conn);
                    checkAuthorCmd.Parameters.AddWithValue("@kirtunnus", authorId);
                    int authorExists = Convert.ToInt32(checkAuthorCmd.ExecuteScalar());

                    if (authorExists == 0)
                    {
                        MessageBox.Show("Kirjailijan tunnusta ei löytynyt tietokannasta.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Delete the author
                    string deleteAuthorQuery = "DELETE FROM Kirjailija WHERE kirtunnus = @kirtunnus";
                    MySqlCommand deleteAuthorCmd = new MySqlCommand(deleteAuthorQuery, conn);
                    deleteAuthorCmd.Parameters.AddWithValue("@kirtunnus", authorId);
                    deleteAuthorCmd.ExecuteNonQuery();

                    MessageBox.Show("Kirjailija poistettu onnistuneesti!", "Onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
