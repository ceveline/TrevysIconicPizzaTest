using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class Customer : User
    {
        private string user_ID;
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private string card;
        private string cvv;
        private DateTime cardExpireDate;

        //Keeps track of id
        static int idCustomerCounter = 0;
        public Customer( string firstName, string lastName, string password, string card, string username, DateTime expiration) 
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Card = card;
            User_ID = Generate_ID();
            CardExpireDate = expiration;
        }
        //Method generates ID that starts with C for client
        public string Generate_ID()
        {
            string id = $"C{idCustomerCounter:D4}";
            idCustomerCounter++;
            return id;
        }

        public string Username
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
        public string User_ID
        {
            get 
            { 
                return user_ID;
            }
            set 
            {
                user_ID = value; 
            }
        }
        public string CVV
        {
            get
            {
                return CVV;
            }
            set 
            { 
                CVV = value; 
            }
        }
        public DateTime CardExpireDate
        {
            get
            {
                return cardExpireDate;
            }
            set
            {
                cardExpireDate = value;
            }
        }
    }
}
