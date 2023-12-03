using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    public class VegetarianPizza : Pizza
    {
        
        public VegetarianPizza(String size) : base("Vegetarian", size)
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
                    Price = 19.99m;
                    break;
            }

            return Price;
        }


        }

}
