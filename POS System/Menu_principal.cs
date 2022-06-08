using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class MenuMain : Form
    {
        public MenuMain()
        {
            InitializeComponent();
        }

        private void tsGestionCompte_Click(object sender, EventArgs e)
        {
            create_acnt form = new create_acnt();
            form.Show();
        }

        private void tsProduit_Click(object sender, EventArgs e)
        {
            Produit prodform = new Produit();
            prodform.Show();
        }

        private void tsCommande_Click(object sender, EventArgs e)
        {
            Commande comForm = new Commande();
            comForm.Show();
            //this.Hide();
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
