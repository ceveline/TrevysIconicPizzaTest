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
            //string item = toppingsCheckedListBox.SelectedItem.ToString();


            //if (e.NewValue == CheckState.Checked)
            //{
            //    selectedItemsRichTextBox.AppendText(item);
            //}
            //else
            //{
            //    //condition
            //}

            UpdateDisplayListBox();

        }

        //p.663

        private void UpdateDisplayListBox()
        {

            selectedItemsRichTextBox.Clear();

            // Check if any item is selected in crustListBox
            if (crustListBox.SelectedIndex != -1)
            {
                string selectedCrust = crustListBox.SelectedItem.ToString();
                // Append the selected crust to the RichTextBox
                selectedItemsRichTextBox.AppendText(selectedCrust + "\n");
            }

            // Check if any item is selected in sauceListBox
            if (sauceListBox.SelectedIndex != -1)
            {
                string selectedSauce = sauceListBox.SelectedItem.ToString();
                // Append the selected sauce to the RichTextBox
                selectedItemsRichTextBox.AppendText(selectedSauce + "\n");
            }

            // Handle checked toppings
            foreach (var item in toppingsCheckedListBox.CheckedItems)
            {
                string checkedItem = item.ToString();
                // Append the checked toppings to the RichTextBox
                selectedItemsRichTextBox.AppendText(checkedItem + "\n");
            }


        }

        private void vegAddToCartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vegetarian pizza has been added to your cart successfully!");

            string selectedSize = vegComboBox.Text;
            Pizza vegetarian = new VegetarianPizza(selectedSize);

            // Now, use the cartPage instance to add the pizza to the cart
            cartPage.AddPizzaToCart(vegetarian);

        }

        //ori
        private void oriAddToCartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Original pizza has been added to your cart successfully!");
            string size = oriComboBox.Text;
            Pizza original = new OriginalPizza(size);
            cartPage.AddPizzaToCart(original);
        }

        private void pepperoniAddToCartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pepperoni pizza has been added to your cart successfully!");
            string size = pepComboBox.Text;
            Pizza pepperoni = new PepperoniPizza(size);
            cartPage.AddPizzaToCart(pepperoni);
        }

        private void margAddToCartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Margherita pizza has been added to your cart successfully!");
            string size = margComboBox.Text;
            Pizza margherita = new MargheritaPizza(size);
            cartPage.AddPizzaToCart(margherita);
        }

        private void customAddToCartButton_Click(object sender, EventArgs e)
        {
            String size = customSizeComboBox.Text;
            List<String> ingredients = new List<String>();

            // Retrieve ingredients from the RichTextBox
            string[] lines = selectedItemsRichTextBox.Text.Split('\n');
            ingredients.AddRange(lines);

            // Create and add the custom pizza
            Pizza customPizza = new CustomPizza(size, ingredients);
            cartPage.AddPizzaToCart(customPizza);
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
