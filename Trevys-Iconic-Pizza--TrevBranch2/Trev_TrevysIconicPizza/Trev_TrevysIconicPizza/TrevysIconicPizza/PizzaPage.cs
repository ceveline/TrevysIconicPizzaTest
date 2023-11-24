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
    public partial class PizzaPage : Form
    {
        //CartPage cartPage = new CartPage();
        private CartPage cartPage;
        List<string> customPizzaItems = new List<string>();
        public PizzaPage(CartPage cartPageInstance)
        {
            InitializeComponent();
            this.cartPage = cartPageInstance;

            pizzaPanel.AutoScrollMinSize = new Size(0, 900);
            this.Size = new Size(Width, Height + 100);

        }

        private void crustListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateDisplayListBox();
        }

        private void sauceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplayListBox();
        }

        private void toppingsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = toppingsCheckedListBox.Items[e.Index].ToString(); // Use e.Index to get the correct item

            if (e.NewValue == CheckState.Checked)
            {
                selectedListBox.Items.Add(item);
                customPizzaItems.Add(item);
            }
            else
            {
                selectedListBox.Items.Remove(item);
                customPizzaItems.Remove(item);
            }

        }

        //p.663

        private void UpdateDisplayListBox()
        {
            // Clear existing items in displayListBox
            selectedListBox.Items.Clear();

            // Check if any item is selected in crustListBox
            if (crustListBox.SelectedIndex != -1)
            {
                // Get the selected crust from crustListBox
                string selectedCrust = crustListBox.SelectedItem.ToString();
                // Add the selected crust to the displayListBox
                selectedListBox.Items.Add(selectedCrust);
                customPizzaItems.Add(selectedCrust);
            }

            // Check if any item is selected in sauceListBox
            if (sauceListBox.SelectedIndex != -1)
            {
                // Get the selected sauce from sauceListBox
                string selectedSauce = sauceListBox.SelectedItem.ToString();
                // Add the selected sauce to the displayListBox
                selectedListBox.Items.Add(selectedSauce);
                customPizzaItems.Add(selectedSauce);
            }

        }
        //vege vegetarian
        private void vegAddToCartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vegetarian pizza has been added to your cart successfully!");

            string selectedSize = vegComboBox.Text;
            Pizza vegetarian = new VegetarianPizza(selectedSize);

            // Now, use the cartPage instance to add the pizza to the cart
            cartPage.AddPizzaToCart(vegetarian);

        }

        //ori
        private void oriAddToCartButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Original pizza has been added to your cart successfully!");
            string size = oriComboBox.Text;
            Pizza original = new OriginalPizza(size);
            cartPage.AddPizzaToCart(original);
        }

        private void pepAddToCartButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pepperoni pizza has been added to your cart successfully!");
            string size = pepComboBox.Text;
            Pizza pepperoni = new OriginalPizza(size);
            cartPage.AddPizzaToCart(pepperoni);
        }

        private void margAddToCartButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Margherita pizza has been added to your cart successfully!");
            string size = margComboBox.Text;
            Pizza margherita = new MargheritaPizza(size);
            cartPage.AddPizzaToCart(margherita);
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

        private void customAddToCartButton_Click(object sender, EventArgs e)
        {
            
            
            string sauce = sauceListBox.Text;
            string crust = crustListBox.Text;

            string size = customComboBox.Text;

            if (sauceListBox.SelectedItem == null || crustListBox.SelectedItem == null || customComboBox.SelectedItem == null) 
            {
                MessageBox.Show("Please make sure the size, crust, and sauce are chosen.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pizza custom = new CustomPizza(size, customPizzaItems);
            cartPage.AddPizzaToCart(custom);
            MessageBox.Show("Custom pizza has been added to your cart successfully!");


        }

        private void sizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
