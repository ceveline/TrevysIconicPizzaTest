using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class Manager : User
    {
        string user_ID;
        string firstName;
        string lastName;
        string username;
        string password;

        //Keeps track of id
        static int idManagerCounter = 0;

        public Manager(string firstName, string lastName, string username, string password)
        {
            Firstname = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            User_ID = Generate_ID();
        }
        public string Generate_ID()
        {
            string id = $"C{idManagerCounter:D4}";
            idManagerCounter++;
            return id;
        }

        public string Firstname
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
    }
}
