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
        private CartPage cartPageInstance;
        public MenuPage()
        {
            InitializeComponent();
            cartPageInstance = CartPage.GetInstance();
        }

        private void pizzaButton_Click(object sender, EventArgs e)
        {

            PizzaPage pizzaPage = new PizzaPage(cartPageInstance);

            // Handle the FormClosed event
            pizzaPage.FormClosed += (s, args) =>
            {
                this.Show();
                // Re-enable the loginButton when the LoginPage is closed
                pizzaButton.Enabled = true;
            };
            this.Hide();
            pizzaPage.Show();
            pizzaButton.Enabled = false;
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {

            DrinkPage drinkPage = new DrinkPage(cartPageInstance);

            // Handle the FormClosed event
            drinkPage.FormClosed += (s, args) =>
            {
                this.Show();
                // Re-enable the loginButton when the LoginPage is closed
                drinkButton.Enabled = true;
            };

            this.Hide();
            drinkPage.Show();
            drinkButton.Enabled = false;
        }

        private void cartLogo_Click(object sender, EventArgs e)
        {
            // Handle the FormClosed event
            cartPageInstance.Hide(); // Hide the cartPage instead of closing it
            cartLogo.Enabled = false;

            cartPageInstance.VisibleChanged += (s, args) =>
            {
                this.Show();
                cartLogo.Enabled = true; // Re-enable the cartLogo when the cartPage is closed
            };

            this.Hide();
            cartPageInstance.Show();

        }

        private void accountLogo_Click(object sender, EventArgs e)
        {
            AccountInformation accountInformation = new AccountInformation();

            // Handle the FormClosed event
            accountInformation.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                accountLogo.Enabled = true;

            };

            accountInformation.Show();
            accountLogo.Enabled = false;
        }

        private void questionLogo_Click(object sender, EventArgs e)
        {
            HelpPage helpPage = new HelpPage();

            // Handle the FormClosed event
            helpPage.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                questionLogo.Enabled = true;

            };

             helpPage.Show();
            questionLogo.Enabled = false;
        }
    }
}

