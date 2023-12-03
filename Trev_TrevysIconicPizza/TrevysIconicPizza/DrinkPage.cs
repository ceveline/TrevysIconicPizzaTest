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
    public partial class DrinkPage : Form
    {
        private CartPage cartPage;
        List<string> customMilkshakeItems = new List<string>();

        public DrinkPage(CartPage cartPageInstance)
        {
            InitializeComponent();
            this.cartPage = cartPageInstance;
        }

        private void addVanillaButton_Click(object sender, EventArgs e)
        {
            
            Drink vMilkshake = new VanillaMilkshake();

            cartPage.AddDrinkToCart(vMilkshake);

            MessageBox.Show("Vanilla milkshake has been added to your cart successfully!");
        }

        private void addChocolateButton_Click(object sender, EventArgs e)
        {
           
            Drink cMilkshake = new ChocolateMilkshake();

            cartPage.AddDrinkToCart(cMilkshake);

            MessageBox.Show("Chocolate milkshake has been added to your cart successfully!");
        }

        private void addStrawberryButton_Click(object sender, EventArgs e)
        {
            
            Drink sMilkshake = new StrawberryMilkshake();

            cartPage.AddDrinkToCart(sMilkshake);

            MessageBox.Show("Strawberry milkshake has been added to your cart successfully!");
        }

        private void cartLogo_Click(object sender, EventArgs e)
        {
            cartPage.Hide(); // Hide the cartPage instead of closing it
            cartLogo.Enabled = false;

            cartPage.VisibleChanged += (s, args) =>
            {
                cartLogo.Enabled = true; // Re-enable the cartLogo when the cartPage is closed
            };

            cartPage.Show();
        }

        private void addCustomButton_Click(object sender, EventArgs e)
        {
            string flavor = flavorListBox.Text;

            if (flavorListBox.SelectedItems.Count == 0 || toppingsListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please make sure flavor and at least one topping are selected!");
                return;
            }

            Drink custom = new CustomMilkshake(customMilkshakeItems);
            cartPage.AddDrinkToCart(custom);
            MessageBox.Show("Custom milkshake has been added to your cart successfully!");
        }

        private void toppingsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = toppingsListBox.Items[e.Index].ToString(); // Use e.Index to get the correct item

            if (e.NewValue == CheckState.Checked)
            {
                customMilkshakeItems.Add(item);
            }
            else
            {
                customMilkshakeItems.Remove(item);
            }
        }

        private void addSoftButton_Click(object sender, EventArgs e)
        {
            Drink sDrink = new SoftDrink();

            cartPage.AddDrinkToCart(sDrink);

            MessageBox.Show("Strawberry milkshake has been added to your cart successfully!");
        }
    }
}
