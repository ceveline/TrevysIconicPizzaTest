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
            deliveryDateTimePicker.MinDate = DateTime.Now;

            // user can only select today or next day
            DateTime endOfNextDay = DateTime.Today.AddDays(2).AddTicks(-1);
            deliveryDateTimePicker.MaxDate = endOfNextDay;
          
            
        }
    }
}
