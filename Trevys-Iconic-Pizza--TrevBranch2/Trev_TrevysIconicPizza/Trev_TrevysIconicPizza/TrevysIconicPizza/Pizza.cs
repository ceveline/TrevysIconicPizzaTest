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

        public override string ToString()
        {
            return String.Format("{0,-30} {1,-10} {2,20:C}", Type, Size, Price);
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public decimal Price { get; set;} 
        public String Size { get { return size; } set { size = value; } }

        //public List<String> Ingredients { get { return ingredients; } set { ingredients = value; } }



    }
}
