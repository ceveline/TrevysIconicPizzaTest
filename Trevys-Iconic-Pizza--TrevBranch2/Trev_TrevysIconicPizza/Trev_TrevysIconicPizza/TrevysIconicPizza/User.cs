using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal interface User
    {
         string User_ID { get; set; }
         string Username { get; set; }
         string Password { get; set; }
    }
}
