using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza(String size) : base("Pepperoni", size) 
        { 
            Size = size;
            Price = calculatePizzaPrice();
        }

        public virtual decimal calculatePizzaPrice()
        {

            switch (Size)
            {
                case "Small":
                    Price = 14.99m;
                    break;
                case "Medium":
                    Price = 17.99m;
                    break;
                case "Large":
                    Price = 19.99m;
                    break;
            }

            return Price;
        }
    }
    
}
