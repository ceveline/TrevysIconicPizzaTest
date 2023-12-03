using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class MargheritaPizza : Pizza
    {
        public MargheritaPizza(String size) : base("Margherita", size)
        {
            Size = size;
            Price = calculatePizzaPrice();
        }
        public virtual decimal calculatePizzaPrice()
        {

            switch (Size)
            {
                case "Small":
                    Price = 13.99m;
                    break;
                case "Medium":
                    Price = 16.99m;
                    break;
                case "Large":
                    Price = 18.99m;
                    break;
            }

            return Price;
        }
    }
}
