using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrevysIconicPizza
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void cartLogo_Click(object sender, EventArgs e)
        {
            CartPage cartPage = new CartPage();

            // Handle the FormClosed event
            cartPage.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                cartLogo.Enabled = true;
            };

            cartPage.Show();
            cartLogo.Enabled = false;
        }
    }
}
