using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    public class Pizza
    {
        //String name;
        String type;
        decimal price;
        String size;
        

        public Pizza(string type, String size)
        {
            //this.name = Name;
            this.type = type;
            this.size = size;

            this.price = 0;

            this.size = Size;
            
        }

        //count price (to determine price of size, ingredients, type) -> 4 methods
        public decimal calculatePizzaPrice()
        {
            Price = 0;

            return Price;
        }

        //public decimal calculatePriceForCustomPizza()
        //{
        //    decimal price = 0;
        //    Size = Size.ToLower();

        //    if (size == "s")
        //    {
        //        price += 7.99m;
        //    }
        //    else if (size == "m")
        //    {
        //        price += 8.99m;
        //    }
        //    else if (size == "l")
        //    {
        //        price += 9.99m;
        //    }

        //    foreach (String ingredient in ingredients)
        //    {
        //        if (ingredient.Equals("black olives", StringComparison.OrdinalIgnoreCase)
        //            || ingredient.Equals("green peppers", StringComparison.OrdinalIgnoreCase)
        //            || ingredient.Equals("jalapenos", StringComparison.OrdinalIgnoreCase)
        //            || ingredient.Equals("mushrooms", StringComparison.OrdinalIgnoreCase)
        //            || ingredient.Equals("red peppers", StringComparison.OrdinalIgnoreCase)
        //            || ingredient.Equals("tomatoes", StringComparison.OrdinalIgnoreCase))
        //        {
        //            price += 1.99m;
        //        }
        //        else if (ingredient.Equals("bacon", StringComparison.OrdinalIgnoreCase)
        //            || ingredient.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
        //        {
        //            price += 3.99m;
        //        }
        //        else if (ingredient.Equals("basil", StringComparison.OrdinalIgnoreCase))
        //        {
        //            price += 0.99m;
        //        }
        //        else if (ingredient.Equals("mozzarella", StringComparison.OrdinalIgnoreCase))
        //        {
        //            price += 2.75m;
        //        }
        //    }

        //    Price = price;

        //    return Price;
        //}

        //needs to be edited
        public override string ToString()
        {
            return String.Format("{0, -20}{1,-30}{2,0:C}", Type, Size, Price);
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public decimal Price { get { return price; } set { price = value; } }
        public String Size { get { return size; } set { size = value; } }

        //public List<String> Ingredients { get { return ingredients; } set { ingredients = value; } }



    }
}
