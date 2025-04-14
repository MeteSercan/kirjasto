using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kirjasto_ohjelma5
{
    public partial class Form3 : Form
    {
        static string connectionString = "Server=localhost;Port=3306;Database=kirjasto;User ID=root;Password=123;";
        public Form3()
        {
            InitializeComponent();
        }
        private void ClearCustomerFields()
        {
            tunnus.Clear();
            etunimi.Clear();
            sukunimi.Clear();
            osoite.Clear();
            posti.Clear();
            kaupunki.Clear();
            puhelin.Clear();
        }
        private void Lisaa_asiakas_Click(object sender, EventArgs e)
        {
            string customerId = tunnus.Text.Trim();
            string firstName = etunimi.Text.Trim();
            string lastName = sukunimi.Text.Trim();
            string address = osoite.Text.Trim();
            string postalCode = posti.Text.Trim();
            string city = kaupunki.Text.Trim();
            string phone = puhelin.Text.Trim();

            if (string.IsNullOrEmpty(customerId) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please fill all required fields: Customer ID, First Name, and Last Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Asiakas (asnum, enimi, snimi, loso, pno, ptp, puh) VALUES (@asnum, @enimi, @snimi, @loso, @pno, @ptp, @puh)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@asnum", customerId);
                    cmd.Parameters.AddWithValue("@enimi", firstName);
                    cmd.Parameters.AddWithValue("@snimi", lastName);
                    cmd.Parameters.AddWithValue("@loso", address);
                    cmd.Parameters.AddWithValue("@pno", postalCode);
                    cmd.Parameters.AddWithValue("@ptp", city);
                    cmd.Parameters.AddWithValue("@puh", phone);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearCustomerFields();  // Clear input fields after successful insertion
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
