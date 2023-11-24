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
            deliveryDateTimePicker.MinDate = DateTime.Today;

            // user can only select today or next day
            DateTime endOfNextDay = DateTime.Today.AddDays(2).AddTicks(-1);
            deliveryDateTimePicker.MaxDate = endOfNextDay;


        }

        private void pickupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TimeSpan rushHourStart = TimeSpan.Parse("17:00");
            TimeSpan rushHourEnd = TimeSpan.Parse("18:00");
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (pickupRadioButton.Checked) 
            {
                delivTimeLabel.Visible = false;
                deliveryDateTimePicker.Visible = false;

                if(now > rushHourStart && now < rushHourEnd)
                {
                    pickUpTimeLabel.Text = DateTime.Now.AddMinutes(20).ToString;
                }
            } else
            {
                deliveryDateTimePicker.Visible = true;
                delivTimeLabel.Visible = true;
            }
        }

        private void pickUpTimeLabel_Click(object sender, EventArgs e)
        {
            pickUpTimeLabel.Text =  DateTime.Now.AddMinutes(40).ToString();
        }
    }


}

