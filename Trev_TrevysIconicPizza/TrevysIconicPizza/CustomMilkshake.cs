using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class CustomMilkshake : Drink
    {
        List<string> ingredients = new List<string>();
        public List<string> Ingredients { get; set; }
        public CustomMilkshake(List<string> ingredients) : base("Custom Milkshake")
        {
            Price = CalculatePrice();
            Ingredients = ingredients;
        }

        public virtual decimal CalculatePrice()
        {
            Price = 3.25m ;

            foreach (String ingredient in ingredients)
            {
                if (ingredient.Equals("banana", StringComparison.OrdinalIgnoreCase)
                || ingredient.Equals("Strawberry", StringComparison.OrdinalIgnoreCase)
                || ingredient.Equals("Smores", StringComparison.OrdinalIgnoreCase)
                || ingredient.Equals("Pretzel", StringComparison.OrdinalIgnoreCase)
                || ingredient.Equals("Chocolate", StringComparison.OrdinalIgnoreCase))
                {
                    Price += 2.99m;
                }
                else if (ingredient.Equals("Caramel", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("Mint", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("Peanut Butter", StringComparison.OrdinalIgnoreCase)
                    || ingredient.Equals("Peanutes", StringComparison.OrdinalIgnoreCase))
                {
                    Price += 1.75m;
                }
            }


            return Price;
        }
    }
}
