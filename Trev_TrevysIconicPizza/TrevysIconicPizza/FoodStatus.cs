using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrevysIconicPizza
{
    public partial class FoodStatus : Form
    { 
        CurrentClient client;
        private DateTime orderStartTime;
        private Timer timer;
        public FoodStatus()
        {
            InitializeComponent();
           
            client = CurrentClient.Instance;
            timer = new Timer();
            timer.Interval = 1000; // Set the interval in milliseconds (adjust as needed)
            timer.Tick += Timer_Tick_Tick;
            timer.Start();

            
        }
        
        private string GetOrderStatusDescription(int orderId)
        {


            // For demonstration purposes, return a sample description
            return "Order Received";
        }
        private void UpdateOrderStatus(int orderId, int time)
        {
            // Fetch order status description from the database
            string orderStatusDescription = GetOrderStatusDescription(orderId);

            // Update the label with the fetched order status description
            stepLabel.Text = orderStatusDescription;

            // Update the progress bar based on the order status
            UpdateProgressBar(orderStatusDescription);
        }
        private void UpdateProgressBar(string orderStatusDescription)
        {
            // Update the progress bar based on the order status description
            switch (orderStatusDescription)
            {
                case "Order Received":
                    statusProgressBar.Value = 25; // Example: 25% progress
                    break;
                case "In the Oven":
                    statusProgressBar.Value = 50; // Example: 50% progress
                    break;
                case "Out for Delivery":
                    statusProgressBar.Value = 75; // Example: 75% progress
                    break;
                case "Delivered":
                    statusProgressBar.Value = 100; // Example: 100% progress
                    break;
                default:
                    statusProgressBar.Value = 0; // Reset if the status is unknown
                    break;
            }
        }

        private void Timer_Tick_Tick(object sender, EventArgs e)
        {
            // Rush hour time
            TimeSpan rushHourStart = TimeSpan.Parse("17:00");
            TimeSpan rushHourEnd = TimeSpan.Parse("19:00");
            TimeSpan now = DateTime.Now.TimeOfDay;

            int totalTime;

            if (now > rushHourStart && now < rushHourEnd)
            {
                totalTime = 1;
            }
            else
            {
                totalTime = 2;
            }

            // Calculate the elapsed time
            int elapsedTime = (int)(DateTime.Now - orderStartTime).TotalMinutes;

            // Calculate the percentage completion
            int progressPercentage = (int)((double)elapsedTime / totalTime * 100);

            // Update the progress bar value
            statusProgressBar.Value = progressPercentage;

            // Call the method to update the order status periodically
            UpdateOrderStatus(client.Order_ID, totalTime);
        }
        private void StartOrderStatusTimer()
        {
            orderStartTime = DateTime.Now; // Set orderStartTime when the timer starts
            Timer_Tick.Start(); // Start the timer
        }


    }
}
