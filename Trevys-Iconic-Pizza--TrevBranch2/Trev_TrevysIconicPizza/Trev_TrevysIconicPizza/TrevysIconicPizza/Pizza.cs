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
        List<String> ingredients;

        public Pizza(string type, String size, List<string> ingredients)
        {
            //this.name = Name;
            this.type = type;
            this.size = size;

            if ((type.Equals("Original", StringComparison.OrdinalIgnoreCase) ||
                (type.Equals("Vegetarian", StringComparison.OrdinalIgnoreCase) ||
                (type.Equals("Pepperoni", StringComparison.OrdinalIgnoreCase)) ||
                (type.Equals("Margherita", StringComparison.OrdinalIgnoreCase)))))
            {
                this.price = calculatePriceForReadyPizza();
            }
            else
            {
                this.price = calculatePriceForCustomPizza();
            }

            this.size = Size;
            this.ingredients = ingredients ?? new List<string>();
        }

        //count price (to determine price of size, ingredients, type) -> 4 methods
        public decimal calculatePriceForReadyPizza()
        {
            decimal price = 0;
            Size = Size.ToLower();

            if (type.Equals("Original", StringComparison.OrdinalIgnoreCase))
            {
                switch (Size)
                {
                    case "s":
                        price = 10.99m;
                        break;
                    case "m":
                        price = 13.99m;
                        break;
                    case "l":
                        price = 16.99m;
                        break;
                }
            }
            else if (type.Equals("Vegetarian", StringComparison.OrdinalIgnoreCase))
            {
                switch (Size)
                {
                    case "s":
                        price = 13.99m;
                        break;
                    case "m":
                        price = 16.99m;
                        break;
                    case "l":
                        price = 19.99m;
                        break;
                }
            }
            else if (type.Equals("Pepperoni", StringComparison.OrdinalIgnoreCase))
            {
                switch (Size)
                {
                    case "s":
                        price = 14.99m;
                        break;
                    case "m":
                        price = 17.99m;
                        break;
                    case "l":
                        price = 19.99m;
                        break;
                }
            }
            else if (type.Equals("Margherita", StringComparison.OrdinalIgnoreCase))
            {
                switch (Size)
                {
                    case "s":
                        price = 13.99m;
                        break;
                    case "m":
                        price = 16.99m;
                        break;
                    case "l":
                        price = 18.99m;
                        break;
                }
            }

            Price = price;

            return Price;
        }

        public decimal calculatePriceForCustomPizza()
        {
            decimal price = 0;
            Size = Size.ToLower();

            if (size == "s")
            {
                price += 7.99m;
            }
            else if (size == "m")
            {
                price += 8.99m;
            }
            else if (size == "l")
            {
                price += 9.99m;
            }

            foreach (String ingredient in ingredients)
            {
                if (ingredient.Equals("black olives", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("green peppers", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("jalapenos", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("mushrooms", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("red peppers", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("tomatoes", StringComparison.OrdinalIgnoreCase))
                {
                    price += 1.99m;
                }
                else if (ingredient.Equals("bacon", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
                {
                    price += 3.99m;
                }
                else if (ingredient.Equals("basil", StringComparison.OrdinalIgnoreCase))
                {
                    price += 0.99m;
                }
                else if (ingredient.Equals("mozzarella", StringComparison.OrdinalIgnoreCase))
                {
                    price += 2.75m;
                }
            }

            Price = price;

            return Price;
        }

        //needs to be edited
        public override string ToString()
        {
            return String.Format("Type: {0}, Size: {1}, Price: {2:C}", Type, Size, Price);
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public decimal Price { get { return price; } set { price = value; } }
        public String Size { get { return size; } set { size = value; } }

        public List<String> Ingredients { get { return ingredients; } set { ingredients = value; } }



    }
}
