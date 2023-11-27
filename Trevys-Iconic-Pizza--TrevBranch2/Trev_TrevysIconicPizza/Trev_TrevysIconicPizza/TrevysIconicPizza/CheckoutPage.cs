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

    public partial class CheckoutPage : Form
    {
        List<string> invalidResult = new List<string>();

        private CartPage cartPage;
        public CheckoutPage(CartPage cartPageInstance)
        {
            InitializeComponent();
            this.cartPage = cartPageInstance;

        }

        public CheckoutPage()
        {
            InitializeComponent();
            //display date and time
            deliveryDateTimePicker.Format = DateTimePickerFormat.Custom;
            deliveryDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void CheckoutPage_Load(object sender, EventArgs e)
        {
            // setting min date to curent time
            deliveryDateTimePicker.MinDate = DateTime.Now;

            // user can only select today or next day
            DateTime endOfNextDay = DateTime.Today.AddDays(2).AddTicks(-1);
            deliveryDateTimePicker.MaxDate = endOfNextDay;


        }

        private void cartLogo_Click(object sender, EventArgs e)
        {
            // Handle the FormClosed event
            cartPage.Hide(); // Hide the cartPage instead of closing it
            cartLogo.Enabled = false;

            cartPage.VisibleChanged += (s, args) =>
            {
                cartLogo.Enabled = true; // Re-enable the cartLogo when the cartPage is closed
            };

            cartPage.Show();
        }

        private bool verifyCard()
        {
            bool result = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(cardNumberTextBox.Text, @"^(?! )[\d ]{13,19}$"))
            {
                invalidResult.Add("Invalid Card input\n");
                cardNumberTextBox.Clear();
                result = false;
            }

            return result;
        }

        private bool verifyCVV()
        {
            bool result = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(CVVTextBox.Text, @"^\d{3}$"))
            {
                invalidResult.Add("Invalid CVV input\n");
                CVVTextBox.Clear();
                result = false;
            }

            return result;
        }

        private bool verifyPhone()
        {
            bool result = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(phoneTextBox.Text, @"^\d{10}$"))
            {
                invalidResult.Add("Invalid Phone Number input\n");
                cardNumberTextBox.Clear();
                result = false;
            }

            return result;
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            // Clear the list of invalid results after displaying them
            invalidResult.Clear();

            string text = "";

            verifyCard();
            verifyCVV();
            verifyPhone();
          

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
        }

    }
}

