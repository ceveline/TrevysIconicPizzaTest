
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

namespace TrevysIconicPizza
{
    public partial class CartPage : Form
    {
        private static CartPage _instance;
        private decimal totalPrice;
        private decimal TotalPrice { get; set; }

        private EdibleItem edibleItem = new EdibleItem();

        //private List<Pizza> pizzaOrders = new List<Pizza>();
        //private List<Pizza> PizzaOrders { get; set; }
        //private List<Drink> drinkOrders = new List<Drink>();
        //private List<Drink> DrinkOrders { get; set; }

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
                    cartListBox.Items.RemoveAt(cartListBox.SelectedIndex);
                    checkEmpty();
<<<<<<< HEAD

                    decimal priceToRemove = priceList.IndexOf(priceList[selectedIndex]);
                    
                    priceList.RemoveAt(selectedIndex);

                    edibleItem.EdibleItems.RemoveAt(selectedIndex);

                    // minus the price from the total price
                    TotalPrice -= priceToRemove;

                    
                    // FIX THIS
                    //TotalPrice -= ;
                    
                    // FIX THIS
                    //TotalPrice -= ;

                    totalLabel.Text = "$" + TotalPrice;
=======
                    TotalPrice = 0;
>>>>>>> parent of 98c9bd3 (total price text is still not updating. need to fix it still)
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
                //editButton.Enabled = false;
                removeButton.Enabled = false;
                result = true;
            } else
            {
                emptyLabel.Hide();
                //editButton.Enabled = true;
                removeButton.Enabled = true;
            }
            return result;
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            //CheckoutPage checkoutPage = new CheckoutPage();

            //// Handle the FormClosed event
            //checkoutPage.FormClosed += (s, args) =>
            //{
            //    // Re-enable the loginButton when the LoginPage is closed
            //    checkOutButton.Enabled = true;
            //};

            //checkoutPage.Show();
            //checkOutButton.Enabled = false;

            CheckoutPage checkoutPage = new CheckoutPage();

            // Pass the cart items to the checkout page
            List<string> cartItems = new List<string>();
            foreach (var item in cartListBox.Items)
            {
                cartItems.Add(item.ToString());
            }
            checkoutPage.UpdateCheckoutItems(cartItems);

            // Handle the FormClosed event
            checkoutPage.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                checkOutButton.Enabled = true;
            };

            checkoutPage.Show();
            this.Hide();
            checkOutButton.Enabled = false;

        }

        public void AddPizzaToCart(Pizza pizza)
        {
            //cartListBox.Refresh();
            cartListBox.Items.Add(pizza.ToString());
            checkEmpty();

<<<<<<< HEAD
            // add the price to the price list

            decimal price = pizza.Price;
            priceList.Add(price);
            edibleItem.EdibleItems.Add(pizza);
            //PizzaOrders.Add(pizza);


            TotalPrice += price;


            totalLabel.Text = "$" + TotalPrice;
=======
            TotalPrice += pizza.Price;
            totalLabel.Text = "$" + TotalPrice.ToString();
>>>>>>> parent of 98c9bd3 (total price text is still not updating. need to fix it still)

            cartListBox.Refresh();

        } 
        public void AddDrinkToCart(Drink drink)
        {
            //cartListBox.Refresh();
            cartListBox.Items.Add(drink.ToString());
            checkEmpty();

<<<<<<< HEAD
            decimal price = drink.Price;
            priceList.Add(price);
            edibleItem.EdibleItems.Add(drink);

            TotalPrice += price;


            totalLabel.Text = "$" + TotalPrice;
=======
            TotalPrice += drink.Price;
            totalLabel.Text = "$" + TotalPrice.ToString();
>>>>>>> parent of 98c9bd3 (total price text is still not updating. need to fix it still)

            cartListBox.Refresh();

        }

        public void RemovePizzaFromCart(Pizza pizza)
        {
            cartListBox.Items.Remove(pizza.ToString());
            checkEmpty();

<<<<<<< HEAD
            //PizzaOrders.Remove(pizza);
=======
            TotalPrice -= pizza.Price;
            totalLabel.Text = "$" + TotalPrice.ToString();
>>>>>>> parent of 98c9bd3 (total price text is still not updating. need to fix it still)

            cartListBox.Refresh();
        }

        private void CartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the form when the close button is clicked
            
        }
<<<<<<< HEAD
=======

        
>>>>>>> parent of 98c9bd3 (total price text is still not updating. need to fix it still)
    }
}
