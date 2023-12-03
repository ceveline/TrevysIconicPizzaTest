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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            
        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            // Assuming loginPage is an instance of LoginPage
            LoginPage loginPage = new LoginPage();

            // Handle the FormClosed event
            loginPage.FormClosed += (s, args) =>
            {
                this.Show();
                // Re-enable the loginButton when the LoginPage is closed
                loginButton.Enabled = true;
            };

            this.Hide();
            loginPage.Show();
            loginButton.Enabled = false;

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            // Assuming loginPage is an instance of LoginPage
            CreateAccountPage createAccountPage = new CreateAccountPage();

            // Handle the FormClosed event
            createAccountPage.FormClosed += (s, args) =>
            {
                this.Show();
                // Re-enable the loginButton when the LoginPage is closed
                createAccountButton.Enabled = true;
            };

            this.Hide();
            createAccountPage.Show();
            createAccountButton.Enabled = false;
        }

        private void continueAsGuestButton_Click(object sender, EventArgs e)
        {

            // Create an instance of the MenuPage form
            MenuPage menuPage = new MenuPage();

            // Handle the FormClosed event of the MenuPage form
            menuPage.FormClosed += (s, args) =>
            {
                // Show the LandingPage form when MenuPage is closed
                this.Show();
                continueAsGuestButton.Enabled = true;
            };

            // Hide the LandingPage form
            this.Hide();

            // Show the MenuPage
            menuPage.Show();
            continueAsGuestButton.Enabled = false;

            //MenuPage menuPage = new MenuPage();
            //// Handle the FormClosed event
            //this.Close();
            //menuPage.FormClosed += (s, args) =>
            //{
            //    // Re-enable the loginButton when the LoginPage is closed
            //    continueAsGuestButton.Enabled = true;

            //};


            //menuPage.Show();
            //continueAsGuestButton.Enabled = false;
        }
    }
}
