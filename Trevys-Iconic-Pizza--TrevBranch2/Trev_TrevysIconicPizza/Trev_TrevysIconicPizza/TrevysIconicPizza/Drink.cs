using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class Drink
    {
        String type;
        decimal price;
        char size;
        //List<String> ingredients;

        public string Type { get; set; }
        public decimal Price { get; set; }
        public char Size { get; set; }

        public Drink()
        {
            Type = "";
            Size = ' ';
            Price = 0;
        }

        public Drink(string type)
        {
            Type = type;
            Size = ' ';
            Price = 0;
        }

        // can be overridden by child classes
        public virtual decimal CalculatePrice()
        {
            // Default behavior for a generic drink
            return Price;
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
