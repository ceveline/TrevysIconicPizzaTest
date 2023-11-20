using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class Customer
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private string card;

        public Customer(string firstName, string lastName, string password, string card, string username) 
        {
            UserName = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Card = card;
        }

        public string UserName
        {
            get 
            { 
                return username; 
            }
            set 
            { 
                username = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set 
            { 
            firstName = value;
            }
        }
        public string LastName
        {
            get 
            { 
                return lastName;
            }
            set
            { 
                lastName = value; 
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Card
        {
            get
            {
                return card;
            }
            set
            {
                card = value;
            }
        }
    }
}
