using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace sav
{
    public partial class inscription : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public inscription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string iquery = "INSERT INTO sav.user(`ID_USER`,`nom`,`prenom`,`mail`,`pseudo`, `mdp`) VALUES (NULL, @Nom, @Prenom, @Mail, @Pseudo, @mdp)";
            MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
            commandDatabase.Parameters.AddWithValue("@Nom", txtFName.Text);
            commandDatabase.Parameters.AddWithValue("@Prenom", txtLName.Text);
            commandDatabase.Parameters.AddWithValue("@Mail", txtEmail.Text);
            commandDatabase.Parameters.AddWithValue("@Pseudo", txtUsername.Text);

            // Hachage du mot de passe avant l'insertion
            string hashedPassword = HashPassword(txtPasword.Text);
            commandDatabase.Parameters.AddWithValue("@mdp", hashedPassword);

            commandDatabase.CommandTimeout = 60;

            try
            {
                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Compte créé avec succès!");
                this.Hide();
                accueil f1 = new accueil();
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();

            }
        }

        private bool CheckIfEmailExists(string email)
        {
            bool exists = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sav.user WHERE mail = @Email", connection);
            cmd.Parameters.AddWithValue("@Email", email);
            using (var dr = cmd.ExecuteReader())
            {
                exists = dr.HasRows;
            }
            connection.Close();
            return exists;
        }

        private bool CheckIfPseudoExists(string pseudo)
        {
            bool exists = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sav.user WHERE pseudo = @Pseudo", connection);
            cmd.Parameters.AddWithValue("@Pseudo", pseudo);
            using (var dr = cmd.ExecuteReader())
            {
                exists = dr.HasRows;
            }
            connection.Close();
            return exists;
        }

        private void InsertNewUser()
        {
            connection.Open();
            string iquery = "INSERT INTO sav.user(`ID_USER`,`nom`,`prenom`,`mail`,`pseudo`, `mdp`) VALUES (NULL, @Nom, @Prenom, @Mail, @Pseudo, @mdp)";
            MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
            commandDatabase.Parameters.AddWithValue("@Nom", txtFName.Text);
            commandDatabase.Parameters.AddWithValue("@Prenom", txtLName.Text);
            commandDatabase.Parameters.AddWithValue("@Mail", txtEmail.Text);
            commandDatabase.Parameters.AddWithValue("@Pseudo", txtUsername.Text);
            commandDatabase.Parameters.AddWithValue("@mdp", txtPasword.Text);
            commandDatabase.CommandTimeout = 60;

            try
            {
                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Compte créé avec succès!");
                // Afficher le formulaire d'accueil après l'inscription réussie
                this.Hide();
                accueil f1 = new accueil();
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            accueil f1 = new accueil();
            f1.Show();
        }

        private void inscription_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
