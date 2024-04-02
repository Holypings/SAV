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
    public partial class connexion : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            accueil f1 = new accueil();
            f1.Show();

            string pseudo = txtPseudo.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(pseudo) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez entrer votre pseudo et votre mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sav.user WHERE pseudo = @Pseudo AND mdp = @Password", connection);
            cmd.Parameters.AddWithValue("@Pseudo", pseudo);
            cmd.Parameters.AddWithValue("@Password", password);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                // Les identifiants sont valides, rediriger vers le formulaire principal 'accueil'
                accueil mainForm = new accueil();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Les identifiants sont invalides, afficher un message d'erreur
                MessageBox.Show("Pseudo ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();



        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
