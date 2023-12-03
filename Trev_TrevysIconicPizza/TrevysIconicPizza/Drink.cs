using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    public class Drink : EdibleItem
    {
        String type;
        decimal price;

        public string Type { get; set; }
        public decimal Price { get; set; }

        public Drink(string type)
        {
            Type = type;
            Price = CalculatePrice();
        }

        // can be overridden by child classes
        protected virtual decimal CalculatePrice()
        {
            // Default behavior for a generic drink
            return Price;
        }

        public override string ToString()
        {
            return String.Format("{0, -35}{1,35:C}", Type, Price);
        }

        /*
         *Coca Cola
Diet Coke
Ginger Ale
Sprite
         */

        //public decimal calculatePriceForDrinks()
        //{
        //    if (type.Equals("Coca cola", StringComparison.OrdinalIgnoreCase)
        //        || type.Equals("Diet coke", StringComparison.OrdinalIgnoreCase)
        //        || type.Equals("Ginger ale", StringComparison.OrdinalIgnoreCase)
        //        || type.Equals("Sprite", StringComparison.OrdinalIgnoreCase))
        //    {
        //        Price = 2.99m;
        //    }
        //    else if (type.Equals("vanilla milkshake", StringComparison.OrdinalIgnoreCase))
        //    {
        //        Price = 7.99m;
        //    }
        //    else if (type.Equals("strawberry milkshake", StringComparison.OrdinalIgnoreCase))
        //    {
        //        Price = 8.99m;
        //    }
        //    else if (type.Equals("chocolate milkshake", StringComparison.OrdinalIgnoreCase))
        //    {
        //        Price = 8.99m;
        //    }


        //    return Price;
        //}

        //public decimal calculatePriceForCustomMilkshake()
        //{
        //    decimal Price = 0;
        //    foreach (String ingredient in ingredients)
        //    {
        //        if (type.Equals("Banana", StringComparison.OrdinalIgnoreCase)
        //        || type.Equals("Strawberry", StringComparison.OrdinalIgnoreCase)
        //        || type.Equals("Smores", StringComparison.OrdinalIgnoreCase)
        //        || type.Equals("Pretzel", StringComparison.OrdinalIgnoreCase)
        //        || type.Equals("Chocolate", StringComparison.OrdinalIgnoreCase))
        //        {
        //            Price += 2.99m;
        //        }
        //        else if (type.Equals("Caramel", StringComparison.OrdinalIgnoreCase)
        //            || type.Equals("Mint", StringComparison.OrdinalIgnoreCase)
        //            || type.Equals("Peanut Butter", StringComparison.OrdinalIgnoreCase)
        //            || type.Equals("Peanutes", StringComparison.OrdinalIgnoreCase))
        //        {
        //            Price += 1.75m;
        //        }
        //    }

        //    return Price;
        //}
    }
}
