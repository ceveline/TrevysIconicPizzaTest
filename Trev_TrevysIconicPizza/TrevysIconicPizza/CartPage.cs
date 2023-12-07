
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrevysIconicPizza
{
    public partial class CartPage : Form
    {
        private static CartPage _instance;
        private decimal totalPrice;
        public static decimal TotalPrice { get; set; }

        private EdibleItem edibleItem = new EdibleItem();
        private List<decimal> priceList = new List<decimal>();
        private List<EdibleItem> itemsToOrder = new List<EdibleItem>();

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

                    decimal priceToRemove = priceList[selectedIndex];

                    TotalPrice -= priceToRemove;

                    totalLabel.Text = "$" + TotalPrice;

                    priceList.RemoveAt(selectedIndex);

                    edibleItem.EdibleItems.RemoveAt(selectedIndex);

                    itemsToOrder.RemoveAt(selectedIndex);

                    
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
                removeButton.Enabled = false;
                result = true;
            } else
            {
                emptyLabel.Hide();
                removeButton.Enabled = true;
            }
            return result;
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the CheckoutPage
            CheckoutPage checkoutPage = new CheckoutPage();

            // Handle the FormClosed event
            checkoutPage.FormClosed += (s, args) =>
            {
                this.Show();
                // Re-enable the checkOutButton when the CheckoutPage is closed
                checkOutButton.Enabled = true;
            };
            this.Hide();
            checkoutPage.Show();
            checkOutButton.Enabled = false;

            checkoutPage.UpdateCheckoutItems(itemsToOrder);

            // Pass the total price to the checkout page
            checkoutPage.UpdateTotalPrice(TotalPrice);
        }


        public void AddPizzaToCart(Pizza pizza)
        {
            //cartListBox.Refresh();
            cartListBox.Items.Add(pizza.ToString());
            checkEmpty();

            // add the price to the price list

            decimal price = pizza.Price;
            priceList.Add(price);
            edibleItem.EdibleItems.Add(pizza);


            TotalPrice += price;


            totalLabel.Text = "$" + TotalPrice;

            itemsToOrder.Add(pizza);

            cartListBox.Refresh();

        }
        public void AddDrinkToCart(Drink drink)
        {
            //cartListBox.Refresh();
            cartListBox.Items.Add(drink.ToString());
            checkEmpty();

            decimal price = drink.Price;
            priceList.Add(price);
            edibleItem.EdibleItems.Add(drink);

            TotalPrice += price;

            totalLabel.Text = "$" + TotalPrice;
            itemsToOrder.Add(drink);

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


            private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the form when the close button is clicked

            
        }

        private void CartPage_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            //// Get the PizzaPage instance
            //PizzaPage pizzaPage = new PizzaPage(_instance);

            //// Show the PizzaPage
            //pizzaPage.Show();
        }



        // every time the rmeove button is clicked, the price is gonna be reduced, taken out of the list
    }
}
