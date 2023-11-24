using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class CustomPizza : Pizza
    {
        List<string> ingredients = new List<string>();
        public List<String> Ingredients {  get; set; }
        public CustomPizza(String size, List<String> ingredients) : base("Custom Pizza", size)
        {
            Size = size;
            Price = calculatePizzaPrice();
            Ingredients = ingredients;
        }

        public virtual decimal calculatePizzaPrice()
        {
            if (Size == "Small")
            {
                Price += 7.99m;
            }
            else if (Size == "Medium")
            {
                Price += 8.99m;
            }
            else if (Size == "Large")
            {
                Price += 9.99m;
            }


            foreach (String ingredient in Ingredients)
            {
                if (ingredient.Equals("black olives", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("green peppers", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("jalapenos", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("mushrooms", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("red peppers", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("tomatoes", StringComparison.OrdinalIgnoreCase))
                {
                    Price += 1.99m;
                }
                else if (ingredient.Equals("bacon", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
                {
                    Price += 3.99m;
                }
                else if (ingredient.Equals("basil", StringComparison.OrdinalIgnoreCase))
                {
                    Price += 0.99m;
                }
                else if (ingredient.Equals("mozzarella", StringComparison.OrdinalIgnoreCase))
                {
                    Price += 2.75m;
                }
                else
                {
                    Price += 0;
                }
            }
            return Price;
        }

        public override string ToString()
        {
            String str = String.Format("{0, -20}{1,-30}{2,0:C}", Type, Size, Price);
            
            str += String.Format("\n{0}", Ingredients);

            return str;
        }
    }
}
