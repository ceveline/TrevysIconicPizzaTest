using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class CurrentClient
    {
        // database string
        private const String ConnectionString = "Data Source=trevysIconicPizza.db;Version=3";
        private static CurrentClient _instance;

        private CurrentClient() { } // private constructor to prevent instantiation

        public static CurrentClient Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CurrentClient();

                }
                return _instance;
            }
        }
        public int Order_ID { get; set; }
        public int Customer_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public DateTime CardExpireDate { get; set; }
        public char category_ID { get; set; }
        // Method to populate CurrentClient instance from the database
        public void PopulateFromDatabase(string username, string password)
        {
            // Perform database query to fetch user information
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Customer WHERE username = @Username AND password = @Password";

                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Username", username);
                    selectCommand.Parameters.AddWithValue("@Password", password);

                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate CurrentClient properties from the database
                            Customer_ID = Convert.ToInt32(reader["customer_ID"]);
                            FirstName = reader["firstName"].ToString();
                            LastName = reader["lastName"].ToString();
                            Username = reader["username"].ToString();
                            Password = reader["password"].ToString();
                            CardNumber = reader["cardNumber"].ToString();
                            CardExpireDate = Convert.ToDateTime(reader["cardExpirationDate"]);
                        }
                    }
                }
            }
        }
        public void Clear()
        {
            // Reset or set properties to default values
            Customer_ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
            CardNumber = string.Empty;
            CardExpireDate = DateTime.MinValue;
            category_ID = '\0'; // Assuming the default value for char is '\0'
        }
        public void SetOrderID(int orderID)
        {
            Order_ID = orderID;
        }

    }
}
