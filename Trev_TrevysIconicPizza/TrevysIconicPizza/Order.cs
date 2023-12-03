using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class Order
    {
        private List<EdibleItem> orderList;


        public Order()
        {
            orderList = new List<EdibleItem>();
        }

        public void AddEdibleItem(EdibleItem edibleItem)
        {
            orderList.Add(edibleItem);
        }

        public void RemoveEdibleItem(EdibleItem edibleItem)
        {
            orderList.Remove(edibleItem);
        }

     

        public List<EdibleItem> GetOrderList()
        {
            return orderList;
        }
    }

}

