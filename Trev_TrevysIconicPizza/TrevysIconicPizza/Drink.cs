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
    }
}
