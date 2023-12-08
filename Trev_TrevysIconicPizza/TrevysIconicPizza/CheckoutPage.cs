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
        private bool totalPriceUpdated = false; // Flag to track whether total price is updated
        private bool totalPriceUpdated_pickup = false;
        private decimal subtotal;
        private decimal currentPrice;
        CurrentClient client;

        public CheckoutPage()
        {
            InitializeComponent();
            // Initialize the CartPage instance
            currentPrice = CartPage.TotalPrice;

            // Display date and time
            deliveryDateTimePicker.Format = DateTimePickerFormat.Custom;
            deliveryDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            client = CurrentClient.Instance;
            
        }

        private void CheckoutPage_Load(object sender, EventArgs e)
        {
            // Setting min date to curent time
            deliveryDateTimePicker.MinDate = DateTime.Today;

            // User can only select today or next day
            DateTime endOfNextDay = DateTime.Today.AddDays(2).AddTicks(-1);
            deliveryDateTimePicker.MaxDate = endOfNextDay;

        }

        private void pickupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pickUpTimer.Start();
            pickUpTimer_Tick(this, EventArgs.Empty);
           
        }

        private void pickUpTimer_Tick(object sender, EventArgs e)
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
            }
            else
            {
    
                deliveryDateTimePicker.Visible = true;
                delivTimeLabel.Visible = true;
                pickUpTimeLabel.Visible = false;
                estimatedPrepTime.Visible = false;
            }
            
        }



        public void UpdateCheckoutItems(List<EdibleItem> items)
        {
            foreach (EdibleItem e in items)
            {
                orderListBox.Items.Add(e);
            }

            
        }

        public void UpdateTotalPrice(decimal price)
        {
            currentPrice = price; // Update the current price

            if (!totalPriceUpdated && deliveryRadioButton.Checked && currentPrice > 0)
            {
                subtotal = currentPrice + 5;
                totalTextBox.Text = subtotal.ToString();
                totalPriceUpdated = true;
                totalPriceUpdated_pickup = false;
            }
            else if (!totalPriceUpdated_pickup && pickupRadioButton.Checked && currentPrice >0)
            {
                subtotal = subtotal - 5;
                totalTextBox.Text = subtotal.ToString();
                totalPriceUpdated = false;
                totalPriceUpdated_pickup = true;
            }
            else 
            {
                totalTextBox.Text = currentPrice.ToString();
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Call the method to update the total price based on the user's selection
            UpdateTotalPrice(currentPrice);
        }


        private void checkoutButton_Click(object sender, EventArgs e)
        {
            
            // Create an instance of the MenuPage
            MenuPage menuPage = new MenuPage();

            // Show a message to the user
            MessageBox.Show("Thank you for the order!");
            DBManager db = new DBManager();
            
            db.InsertOrderToOrderTable(client.Customer_ID);
            
            // Get order_ID for the payment Insert
            int order_ID = db.GetLastInsertedOrderID();

            if (cardRadioButton.Checked)
            {
                client.SetOrderID(order_ID);
                db.InsertIntoPayment(order_ID, subtotal, "Card");
            }
            else
            {
                client.SetOrderID(order_ID);
                db.InsertIntoPayment(order_ID, subtotal, "Cash");
            }
            // Close the current CheckoutPage
            this.Close();

            FoodStatus status1 = new FoodStatus();
            status1.Show();

            // Show the MenuPage
            //Application.Restart();

        }

        
    }


}

