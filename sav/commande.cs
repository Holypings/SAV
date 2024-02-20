using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sav
{
    public partial class commande : Form
    {
        public commande()
        {
            InitializeComponent();
            commandebtn.FlatStyle = FlatStyle.Flat;
            commandebtn.FlatAppearance.BorderSize = 0;
            ajtcomptebtn.FlatStyle = FlatStyle.Flat;
            ajtcomptebtn.FlatAppearance.BorderSize = 0;
            connectbtn.FlatStyle = FlatStyle.Flat;
            connectbtn.FlatAppearance.BorderSize = 0;
            comptebtn.FlatStyle = FlatStyle.Flat;
            comptebtn.FlatAppearance.BorderSize = 0;
            dashbtn.FlatStyle = FlatStyle.Flat;
            dashbtn.FlatAppearance.BorderSize = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ajouterticket f3 = new ajouterticket();
            f3.Show();
        }
    }
}
