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
            SetMyCustomFormat();
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
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            expirationDateTimePicker.Format = DateTimePickerFormat.Custom;
            expirationDateTimePicker.CustomFormat = "MM/yyyy";
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
            if (firstNameTextBox.TextLength == 0)
            {
                invalidResult.Add("First name is required.\n");
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
            if (lastNameTextBox.TextLength == 0)
            {
                invalidResult.Add("Last name is required.\n");
                result  =false;
            }
            return result;
        }

        private bool verifyUsername()
        {
            bool result = true;
            //Username must contain a upper and lowercase letter, a digit, and must be of length 6
            if(System.Text.RegularExpressions.Regex.IsMatch(usernameTextBox.Text, "^(?=.*[a-zA-Z])(?=.*\\d).{6,}$\r\n"))
            {
                invalidResult.Add($"Invalid username.\n");
                usernameTextBox.Clear();
                result = false;
            }
            if (usernameTextBox.TextLength == 0)
            {
                invalidResult.Add("Username is required.\n");
                result = false;
            }
            return result;

        }
        private bool verifyPassword()
        {
            bool result = true;
            if (!passwordTextBox.Text.Equals(reEnterTextBox.Text)) {
                invalidResult.Add("Password does not match.\n");
                reEnterTextBox.Clear();
                result = false;
            }
            if(passwordTextBox.Text.Length < 8 && passwordTextBox.Text.Length > 0)
            {
                invalidResult.Add("Password must be eight characters or longer.\n");
                passwordTextBox.Clear();
                reEnterTextBox.Clear();
                result = false;
            }
            if (passwordTextBox.Text.Length == 0 && result == true)
            {
                invalidResult.Add("Password is required.\n");
                result = false;
            }
            return result;
        }
        private bool verifyCard()
        {
            bool result = true;
            if (cardTextBox.Text.Length == 0)
            {
                return true;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(cardTextBox.Text, @"^(?! )[\d ]{13,19}$"))
            {
                invalidResult.Add("Invalid Card input.\n");
                cardTextBox.Clear();
                result = false;
            }
            // If result is true that means something was entered. We then need to check the CVV and return the result.
            if( result == true)
            {
            result = verifyCVV();
            }

            return result;
        }
        private bool verifyCVV()
        {
            bool result = true;
            if (cvvTextBox.Text.Length == 0)
            {
                return true;
            }
            if(!System.Text.RegularExpressions.Regex.IsMatch(cvvTextBox.Text, @"\d+"))
            {
                invalidResult.Add("Invalid CVV input.\n");
                cvvTextBox.Clear();
                result = false;
            }
            if (cvvTextBox.Text.Length > 0 && cvvTextBox.Text.Length < 3)
            {
                invalidResult.Add("CVV length is three.\n");
                cvvTextBox.Clear();
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
                    Customer person = new Customer(firstNameTextBox.Text, lastNameTextBox.Text, passwordTextBox.Text, cardTextBox.Text, usernameTextBox.Text, expirationDateTimePicker.Value);
                    MessageBox.Show("Welcome " + firstNameTextBox.Text + ", you just created an account", "Validation Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBManager dB = new DBManager();
                    dB.InsertIntoCustomerTable(person.FirstName, person.LastName, person.Username, person.Password, person.Card, person.CVV, person.CardExpireDate.ToLongDateString(), 'c');  
                   // this.Close();
                }
            }
        }

        private void CreateAccountPage_Load(object sender, EventArgs e)
        {
            // Setting min date to curent time
            expirationDateTimePicker.MinDate = DateTime.Today;

            expirationDateTimePicker.MaxDate = DateTime.Today.AddYears(10);
        }
    }
}
