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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cnctBtn_Click(object sender, EventArgs e)
        {
            //MenuMain main = new MenuMain();
            //main.Show();

            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            before before = new before();
            before.Show();
            this.Hide();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            before before = new before();
            before.Show();
            this.Hide();
        }
    }
}
