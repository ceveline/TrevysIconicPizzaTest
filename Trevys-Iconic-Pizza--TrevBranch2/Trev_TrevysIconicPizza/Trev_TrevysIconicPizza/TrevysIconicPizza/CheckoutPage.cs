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

        public CheckoutPage()
        {
            InitializeComponent();
            // Display date and time
            deliveryDateTimePicker.Format = DateTimePickerFormat.Custom;
            deliveryDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void CheckoutPage_Load(object sender, EventArgs e)
        {
            // Setting min date to current time
            deliveryDateTimePicker.MinDate = DateTime.Today;

            // User can only select today or next day
            DateTime endOfNextDay = DateTime.Today.AddDays(2).AddTicks(-1);
            deliveryDateTimePicker.MaxDate = endOfNextDay;

        }

        private void pickupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Rush hour time
            TimeSpan rushHourStart = TimeSpan.Parse("17:00");
            TimeSpan rushHourEnd = TimeSpan.Parse("19:00");
            TimeSpan now = DateTime.Now.TimeOfDay;
            
            // If pickup is selected display pickup estimated time and hide calendar/ delivery label
            if (pickupRadioButton.Checked) 
            {
                delivTimeLabel.Visible = false;
                deliveryDateTimePicker.Visible = false;
                pickUpTimeLabel.Visible = true;
                estimatedPrepTime.Visible = true;

                pickUpTimeLabel.Text = DateTime.Now.AddMinutes(40).ToString("g");

                // Rush hour will add an extra 20 minutes to pick up time 
                if (now > rushHourStart && now < rushHourEnd)
                {
                    pickUpTimeLabel.Text = DateTime.Now.AddMinutes(60).ToString("g");
                }
            } else
            {
                deliveryDateTimePicker.Visible = true;
                delivTimeLabel.Visible = true;
                pickUpTimeLabel.Visible =false;
                estimatedPrepTime.Visible = false;
            }
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

