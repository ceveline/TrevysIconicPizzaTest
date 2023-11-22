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
            Drink vMilkshake = new Drink();

            cartPage.AddDrinkToCart(vMilkshake);
        }

        private void addChocolateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chocolate milkshake has been added to your cart successfully!");

            //fix it
            Drink cMilkshake = new Drink();

            cartPage.AddDrinkToCart(cMilkshake);
        }
    }
}
