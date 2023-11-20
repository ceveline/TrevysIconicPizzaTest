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
    public partial class CreateAccountPage : Form
    {
        //Saves any error message 
        List<string> invalidResult = new List<string>();
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void reEnterPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (reEnterPasswordCheckBox.Checked)
            {
                reEnterTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                reEnterTextBox.UseSystemPasswordChar = true;
            }
        }
        private bool verifyFirstName()
        {
            bool result = true;
            if (System.Text.RegularExpressions.Regex.IsMatch(firstNameTextBox.Text, "[^a-zA-Z]"))
            {
                invalidResult.Add("First name must contain only letters.\n");
                firstNameTextBox.Clear();
                result = false;
            }
            return result;
        }

        private bool verifyLastName()
        {
            bool result = true;
            if (System.Text.RegularExpressions.Regex.IsMatch(lastNameTextBox.Text, "[^a-zA-Z]"))
            {
                invalidResult.Add("Last name must contain only letters.\n");
                lastNameTextBox.Clear();
                result = false;
            }
            return result;
        }

        private bool verifyUsername()
        {
            bool result = true;
            //Username must contain a upper and lowercase letter, a digit, and must be of length 6
            if(System.Text.RegularExpressions.Regex.IsMatch(usernameTextBox.Text, "^(?=.*[a-zA-Z])(?=.*\\d).{6,}$\r\n"))
            {
                invalidResult.Add($"Invalid username\n");
                usernameTextBox.Clear();
                result = false;
            }
            return result;

        }
        private bool verifyPassword()
        {
            bool result = true;
            if (!passwordTextBox.Text.Equals(reEnterTextBox.Text)) {
                invalidResult.Add("Password does not match\n");
                reEnterTextBox.Clear();
                result = false;
            }
            if(passwordTextBox.Text.Length < 8)
            {
                invalidResult.Add("Password must be eight characters or longer");
                passwordTextBox.Clear();
                result = false;
            }
            return result;
        }
        private bool verifyCard()
        {
            bool result = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(cardTextBox.Text, @"^(?! )[\d ]{13,19}$"))
            {
                invalidResult.Add("Invalid Card input\n");
                cardTextBox.Clear();
                result = false;
            }

            return result;
        }
        private void createAcountButton_Click(object sender, EventArgs e)
        {
            // Clear the list of invalid results after displaying them
            invalidResult.Clear();
            
            string text = "";

            verifyCard();
            verifyUsername();
            verifyFirstName();
            verifyLastName();
            verifyPassword();

            // If invalidResult is not empty then add all strings to text variable so all errors can be displayed at once
            if (invalidResult.Count != 0)
            {
                foreach (var result in invalidResult)
                {
                    text += result;
                }

                MessageBox.Show(text, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Clear text after loop
                text = "";

            }
            
            // If all return true create new Customer object and close the form
            if(verifyCard() == true && verifyUsername() == true && verifyFirstName() == true && verifyLastName() == true && verifyPassword() == true) 
            {
                DialogResult  result = MessageBox.Show("Are you sure all information is correct?", "Verification", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Customer person = new Customer(firstNameTextBox.Text, lastNameTextBox.Text, passwordTextBox.Text, cardTextBox.Text, usernameTextBox.Text);
                    MessageBox.Show("Welcome " + firstNameTextBox.Text + ", you just created an account", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }


    }
}
