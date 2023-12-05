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
                // Re-enable the loginButton when the LoginPage is closed
                continueAsGuestButton.Enabled = true;
                loginButton.Enabled = true;
                createAccountButton.Enabled = true;
            };

            loginPage.Show();
            continueAsGuestButton.Enabled = false;
            loginButton.Enabled = false;
            createAccountButton.Enabled = false;

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            // Assuming loginPage is an instance of LoginPage
            CreateAccountPage createAccountPage = new CreateAccountPage();

            // Handle the FormClosed event
            createAccountPage.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                continueAsGuestButton.Enabled = true;
                loginButton.Enabled = true;
                createAccountButton.Enabled = true;
            };

            createAccountPage.Show();
            continueAsGuestButton.Enabled = false;
            loginButton.Enabled = false;
            createAccountButton.Enabled = false;
        }

        private void continueAsGuestButton_Click(object sender, EventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            // Handle the FormClosed event
            menuPage.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                continueAsGuestButton.Enabled = true;
                loginButton.Enabled = true;
                createAccountButton.Enabled = true;
                //this.Hide();
            };

            menuPage.Show();
            continueAsGuestButton.Enabled = false;
            loginButton.Enabled = false;
            createAccountButton.Enabled = false;


        }
        }
    }

