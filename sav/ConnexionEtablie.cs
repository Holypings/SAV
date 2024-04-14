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
    public partial class ConnexionEtablie : Form
    {
        public ConnexionEtablie()
        {
            InitializeComponent();
        }

        private void btndeco_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnexionForm frm1 = new ConnexionForm();
            frm1.ShowDialog();
        }

        private void ConnexionEtablie_Load(object sender, EventArgs e)
        {

        }
    }
}
