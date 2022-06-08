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
    public partial class Commande : Form
    {
        public Commande()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MenuMain main = new MenuMain();
            //main.Show();
            this.Hide();
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
