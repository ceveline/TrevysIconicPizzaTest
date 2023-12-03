using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TrevysIconicPizza
{
    public class EdibleItem
    {
        
        private List<EdibleItem> edibleItems;
        public List<EdibleItem> EdibleItems { get; set; }

        public EdibleItem()
        {
            EdibleItems = new List<EdibleItem>();
        }

        

    }
}
