using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class Order
    {
        private Customer customer { get; set; }
        private List<Pizza> pizzaList;
        private List<Drink> drinkList;

        public List<Drink> GetDrinks()
        {
            return new List<Drink>(drinkList);
        }

        public List<Pizza> GetPizzas()
        {
            return new List<Pizza>(pizzaList);
        }

        public void AddDrink(Drink drink)
        {
            drinkList.Add(drink);
        }

        public void AddPizza(Pizza pizza)
        {
            pizzaList.Add(pizza);
        }
    }
}



