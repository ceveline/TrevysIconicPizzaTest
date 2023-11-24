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

    }
}

