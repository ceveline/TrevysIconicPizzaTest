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
       
        public DrinkPage(CartPage cartPageInstance)
        {
            InitializeComponent();
            this.cartPage = cartPageInstance;
        }

        private void addVanillaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vanilla milkshake has been added to your cart successfully!");

            //fix it
            Drink vMilkshake = new VanillaMilkshake();

            cartPage.AddDrinkToCart(vMilkshake);
        }

        private void addChocolateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chocolate milkshake has been added to your cart successfully!");

            //fix it
            Drink cMilkshake = new ChocolateMilkshake();

            cartPage.AddDrinkToCart(cMilkshake);
        }

        private void addStrawberryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Strawberry milkshake has been added to your cart successfully!");

            //fix it
            Drink sMilkshake = new StrawberryMilkshake();

            cartPage.AddDrinkToCart(sMilkshake);
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

        
    }
}
