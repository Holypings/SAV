using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sav
{


    public partial class commande : Form
    {

        public commande()
        {
            InitializeComponent();
            LoadInitialData();
            commandebtn.FlatStyle = FlatStyle.Flat;
            commandebtn.FlatAppearance.BorderSize = 0;
            ajtcomptebtn.FlatStyle = FlatStyle.Flat;
            ajtcomptebtn.FlatAppearance.BorderSize = 0;
            connectbtn.FlatStyle = FlatStyle.Flat;
            connectbtn.FlatAppearance.BorderSize = 0;
            dashbtn.FlatStyle = FlatStyle.Flat;
            dashbtn.FlatAppearance.BorderSize = 0;

        }

        private void LoadInitialData()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=";
            string selectQuery = "SELECT * FROM sav.ticket";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["reference"], reader["etat"], reader["prix"], reader["datesav"], reader["client"], reader["reparabilite"], reader["tag"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du chargement des données initiales: " + ex.Message);
            }
        }


        private void tbsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void commande_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comptebtn_Click(object sender, EventArgs e)
        {

        }

        private void dashbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            accueil f1 = new accueil();
            f1.Show();
        }

        private void commandebtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ajtcomptebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            inscription f5 = new inscription();
            f5.Show();
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            connexion f4 = new connexion();
            f4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ajouterticket f3 = new ajouterticket();
            f3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=";
            string insertQuery = "INSERT INTO sav.ticket (reference, etat, prix, datesav, client, reparabilite, tag) VALUES (@Reference, @Etat, @Prix, @DateSav, @Client, @Reparabilite, @Tag)";
            string selectQuery = "SELECT * FROM sav.ticket"; // Sélectionne le dernier enregistrement inséré

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Reference", txtReference.Text);
                        cmd.Parameters.AddWithValue("@Etat", cmbEtat.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Prix", decimal.Parse(txtPrix.Text));
                        cmd.Parameters.AddWithValue("@DateSav", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@Client", txtClient.Text);
                        cmd.Parameters.AddWithValue("@Reparabilite", cmbReparabilite.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Tag", txtTag.SelectedItem.ToString());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Insertion réussie.");
                        }
                        else
                        {
                            Console.WriteLine("Aucune ligne insérée.");
                        }
                    }

                    // Récupérer les données insérées
                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, con))
                    {
                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dataGridView1.Rows.Add(reader["reference"], reader["etat"], reader["prix"], reader["datesav"], reader["client"], reader["reparabilite"], reader["tag"]);
                                Console.WriteLine("Dernier enregistrement inséré affiché.");
                            }
                            else
                            {
                                Console.WriteLine("Aucun enregistrement trouvé.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la création du ticket: " + ex.Message);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InsertDataFromDataGridView()
        {

        }
    }
}
