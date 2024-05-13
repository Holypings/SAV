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
    public partial class connexion : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public connexion()
        {
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            const int iterations = 350000;
            const int keySize = 64;
            HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA256;

            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[keySize];
                rng.GetBytes(salt);

                var deriveBytes = new Rfc2898DeriveBytes(password, salt, iterations, hashAlgorithm);
                byte[] hash = deriveBytes.GetBytes(keySize);

                return Convert.ToBase64String(hash);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPseudo.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifiez si l'utilisateur existe dans la base de données
            bool userExists = CheckIfUserExists(txtPseudo.Text, txtPassword.Text);
            if (!userExists)
            {
                MessageBox.Show("Identifiants incorrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si l'utilisateur existe, affichez le formulaire d'accueil
            this.Hide();
            accueil f1 = new accueil();
            f1.Show();
        }

        private bool CheckIfUserExists(string username, string password)
        {
            bool exists = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sav.user WHERE pseudo = @Pseudo AND mdp = @Mdp", connection);
            cmd.Parameters.AddWithValue("@Pseudo", username);
            cmd.Parameters.AddWithValue("@Mdp", password); // Assurez-vous que le mot de passe est haché avant de le comparer
            using (var dr = cmd.ExecuteReader())
            {
                exists = dr.HasRows;
            }
            connection.Close();
            return exists;
        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
