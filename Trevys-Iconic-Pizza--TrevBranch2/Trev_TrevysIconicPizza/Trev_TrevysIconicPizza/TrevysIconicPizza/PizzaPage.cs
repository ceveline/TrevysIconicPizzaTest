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
        public PizzaPage(CartPage cartPageInstance)
        {
            InitializeComponent();
            this.cartPage = cartPageInstance;

            pizzaPanel.AutoScrollMinSize = new Size(0, 880);
            this.Size = new Size(Width, Height + 10);

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
            string item = toppingsCheckedListBox.SelectedItem.ToString();


            if (e.NewValue == CheckState.Checked)
            {
                selectedListBox.Items.Add(item);
            }
            else
            {
                selectedListBox.Items.Remove(item);
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
            }

            // Check if any item is selected in sauceListBox
            if (sauceListBox.SelectedIndex != -1)
            {
                // Get the selected sauce from sauceListBox
                string selectedSauce = sauceListBox.SelectedItem.ToString();
                // Add the selected sauce to the displayListBox
                selectedListBox.Items.Add(selectedSauce);
            }

        }
        //vege vegetarian
        private void vegAddToCartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pizza");

            string size = vegListBox.Text;
            Pizza vegetarian = new Pizza("vegetarian", "s", null);

            // Now, use the cartPage instance to add the pizza to the cart
            cartPage.AddPizzaToCart(vegetarian);

        }

        //ori
        private void addToCartButton2_Click(object sender, EventArgs e)
        {
            string size = oriListBox.Text;
            Pizza original = new Pizza("original", size, null);
        }

        private void addToCartButton3_Click(object sender, EventArgs e)
        {
            string size = pepListBox.Text;
            Pizza pepperoni = new Pizza("pepperoni", size, null);
        }

        private void addToCartButton4_Click(object sender, EventArgs e)
        {
            string size = margListBox.Text;
            Pizza margherita = new Pizza("margherita", size, null);
        }

        
        private void cartLogo_Click(object sender, EventArgs e)
        {
            // Handle the FormClosed event
            cartPage.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                cartLogo.Enabled = true;
            };

            cartPage.Show();
            cartLogo.Enabled = false;
        }
    }

}
