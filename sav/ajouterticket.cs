using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sav
{

    public delegate void TicketDataHandler(string reference, string etat, decimal prix, DateTime datesav, string client, int reparabilite, string tag);

 
    public partial class ajouterticket : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
       
        public ajouterticket()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            commande f2 = new commande();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            commande f2 = new commande();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=";
            string query = "INSERT INTO sav.ticket (reference, etat, prix, datesav, client, reparabilite, tag) VALUES (@Reference, @Etat, @Prix, @DateSav, @Client, @Reparabilite, @Tag)";
            


            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Reference", txtReference.Text);
                    cmd.Parameters.AddWithValue("@Etat", cmbEtat.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Prix", decimal.Parse(txtPrix.Text));
                    cmd.Parameters.AddWithValue("@DateSav", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Client", txtClient.Text);
                    cmd.Parameters.AddWithValue("@Reparabilite", cmbReparabilite.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Tag", txtTag.Text);
                    

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ticket créé avec succès.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la création du ticket: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

            private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ajouterticket_Load(object sender, EventArgs e)
        {

        }
    }
}
