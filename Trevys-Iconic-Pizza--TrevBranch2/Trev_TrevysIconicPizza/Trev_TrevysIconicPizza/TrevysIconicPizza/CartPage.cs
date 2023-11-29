
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace TrevysIconicPizza
{
    public partial class CartPage : Form
    {
        private static CartPage _instance;
        private decimal totalPrice;
        // pricelist List to store the prices of the items
        private List<decimal> priceList = new List<decimal>();
        private decimal TotalPrice { get; set; }
        public CartPage()
        {
            InitializeComponent();
            checkEmpty();
        }

        public static CartPage GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CartPage();
                _instance.FormClosed += (sender, args) => _instance = null; // Handle the FormClosed event to reset the instance
            }
            return _instance;
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to remove the selected item?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = cartListBox.SelectedIndex;
                    cartListBox.Items.RemoveAt(selectedIndex);
                    checkEmpty();

                    decimal priceToRemove = priceList.IndexOf(priceList[selectedIndex]);
                    
                    priceList.RemoveAt(selectedIndex);
                    
                    // FIX THIS
                    //TotalPrice -= ;

                    totalLabel.Text = "$" + TotalPrice;
                }
            }
        }


        //Checks if the listBox is empty
        public bool checkEmpty()
        {
            bool result = false;

            // If cart is empty display empty cart message
            if (cartListBox.Items.Count == 0)
            {
                emptyLabel.Show();
                editButton.Enabled = false;
                removeButton.Enabled = false;
                result = true;
            } else
            {
                emptyLabel.Hide();
                editButton.Enabled = true;
                removeButton.Enabled = true;
            }
            return result;
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            CheckoutPage checkoutPage = new CheckoutPage();

            // Handle the FormClosed event
            checkoutPage.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                checkOutButton.Enabled = true;
            };

            checkoutPage.Show();
            checkOutButton.Enabled = false;

        }

        public void AddPizzaToCart(Pizza pizza)
        {
            //cartListBox.Refresh();
            cartListBox.Items.Add(pizza.ToString());
            checkEmpty();

            // add the price to the price list

            decimal price = pizza.Price;
            priceList.Add(price);


            TotalPrice += price;


            totalLabel.Text = "$" + TotalPrice;

            cartListBox.Refresh();

        } 
        public void AddDrinkToCart(Drink drink)
        {
            //cartListBox.Refresh();
            cartListBox.Items.Add(drink.ToString());
            checkEmpty();

            decimal price = drink.Price;
            priceList.Add(price);

           
            TotalPrice += price;


            totalLabel.Text = "$" + TotalPrice;

            cartListBox.Refresh();

        }

        public void RemovePizzaFromCart(Pizza pizza)
        {
            cartListBox.Items.Remove(pizza.ToString());
            checkEmpty();

            //TotalPrice -= pizza.Price;
            //totalLabel.Text = "$" + TotalPrice.ToString();

            cartListBox.Refresh();
        }

        private void CartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the form when the close button is clicked
            
        }

        // every time the rmeove button is clicked, the price is gonna be reduced, taken out of the list
    }
}
