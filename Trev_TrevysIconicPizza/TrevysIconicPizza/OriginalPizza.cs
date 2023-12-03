using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class OriginalPizza : Pizza
    {
        public OriginalPizza(String size) : base("Original", size)
        {
            Size = size;
            Price = calculatePizzaPrice();
        }

        public virtual decimal calculatePizzaPrice()
        {

            switch (Size)
            {
                case "Small":
                    Price = 10.99m;
                    break;
                case "Medium":
                    Price = 13.99m;
                    break;
                case "Large":
                    Price = 16.99m;
                    break;
            }

            return Price;
        }

    }
}
