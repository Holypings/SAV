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
    public partial class inscription : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public inscription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Votre code existant pour cacher le formulaire et afficher le formulaire d'accueil
            this.Hide();
            accueil f1 = new accueil();
            f1.Show();

            // Votre code existant pour valider le formulaire
            if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Entrez un mail valide", "Email invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Veuillez remplir le formulaire", "Erreur");
                return;
            }

            // Vérifier si l'email existe déjà
            bool emailExists = CheckIfEmailExists(txtEmail.Text);
            if (emailExists)
            {
                MessageBox.Show("Email déjà existant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifier si le pseudo existe déjà
            bool pseudoExists = CheckIfPseudoExists(txtUsername.Text);
            if (pseudoExists)
            {
                MessageBox.Show("Pseudo déjà existant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si aucun des deux n'existe, procéder à l'insertion
            InsertNewUser();
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
            Console.WriteLine("Mot de passe à insérer : " + txtPasword.Text);


            try
            {
                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Compte créé avec succès !");
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
