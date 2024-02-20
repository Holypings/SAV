using System;
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


namespace sav
{
    public partial class accueil : Form
    {
        public accueil()         
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void accueil_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            commande f2 = new commande();
            f2.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inscription f5 = new inscription();
            f5.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            connexion f4 = new connexion();
            f4.Show();

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void commandebtn_Click(object sender, EventArgs e)
        {
            
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }

}
