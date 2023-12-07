using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrevysIconicPizza
{
    internal class DBManager
    {
        // database string
        private const String ConnectionString = "Data Source=trevysIconicPizza.db;Version=3";

        public void CreateEdibleItemTableIfNotExists(String tableName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = $@"CREATE TABLE IF NOT EXISTS {tableName} (
                                    edibleItem_ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                    name VARCHAR(50), 
                                    size CHAR, 
                                    price DECIMAL(5,2), 
                                    itemCategory CHAR,
                                    CONSTRAINT unique_edibleitem UNIQUE(name, size, price, itemCategory)
                                    )";

                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }
            }
        }


        public void InsertEdibleItem(string tableName, string name, string size, decimal? price, string itemCategory)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string sql = $@"INSERT INTO {tableName} (name, size, price, itemCategory) 
                        SELECT @Name, @Size, @Price, @ItemCategory 
                        WHERE NOT EXISTS (
                            SELECT 1 FROM {tableName} 
                            WHERE name = @Name AND size = @Size AND price = @Price AND itemCategory = @ItemCategory
                        )";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Size", size != null ? (object)size : DBNull.Value);
                    command.Parameters.AddWithValue("@Price", price != null ? (object)price : DBNull.Value); // DBNull.Value for null values
                    command.Parameters.AddWithValue("@ItemCategory", itemCategory);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateOrderTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = @"CREATE TABLE IF NOT EXISTS [Order] (
                            order_ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                            customer_ID INTEGER,
                            FOREIGN KEY (customer_ID) REFERENCES Customer(customer_ID)
                            )";

                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }
            }
        }


        public void InsertOrderToOrderTable(int customerId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"INSERT INTO [Order] (customer_ID) VALUES (@customerId)";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public int GetLastInsertedOrderID()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Assuming the order_ID is an auto-incrementing primary key
                string sql = "SELECT last_insert_rowid()";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    int lastInsertedOrderID = Convert.ToInt32(command.ExecuteScalar());
                    return lastInsertedOrderID;
                }
            }
        }


        // orderStatus can be randomized 1-4 (1 = received, 2 = confirmed, 3 = ready, 4 = canceled)
        public void InsertOrderItemToOrderItemTable(int orderId, int orderStatusId, int edibleItemId, int quantity, decimal price)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"INSERT INTO Order_Item (order_ID, orderStatus, edibleItem_ID, quantity, price) 
                       VALUES (@orderId, @orderStatusId, @edibleItemId, @quantity, @price)";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.Parameters.AddWithValue("@orderStatusId", orderStatusId);
                    command.Parameters.AddWithValue("@edibleItemId", edibleItemId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@price", price);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateOrderStatusTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = $@"CREATE TABLE IF NOT EXISTS [OrderStatus] (
                            orderStatus_ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                            description VARCHAR)";

                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }
            }
        }

        public void CreateOrderItemTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = @"CREATE TABLE IF NOT EXISTS OrderItem (
                            orderItem_ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                            order_ID INTEGER,
                            orderDate VARCHAR,
                            orderStatus INTEGER,
                            edibleItem_ID INTEGER,
                            quantity INTEGER,
                            price DECIMAL,
                            FOREIGN KEY (order_ID) REFERENCES [Order](order_ID),
                            FOREIGN KEY (orderStatus) REFERENCES OrderStatus(orderStatus_ID),
                            FOREIGN KEY (edibleItem_ID) REFERENCES EdibleItem(edibleItem_ID)
                            )";

                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }
            }
        }
        public void CreateCustomerTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Customer (
                                   customer_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                   firstName VARCHAR(50) NOT NULL,
                                   lastName VARCHAR(50),
                                   username VARCHAR(50),
                                   password VARCHAR(50),
                                   cardNumber VARCHAR(20),
                                   CVV VARCHAR(3),
                                   cardExpirationDate VARCHAR(50),
                                   category_ID CHAR,
                                   FOREIGN KEY (category_ID) REFERENCES CustomerCategory(category_ID))";

                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }
            }
        }

        public void InsertIntoCustomerTable(string firstName, string lastName, string username, string password, string cardNumber, string cvv, string cardExpirationDate, int category_ID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"INSERT INTO Customer (firstName, lastName, username, password, cardNumber, CVV, cardExpirationDate, category_ID) 
                       VALUES (@firstName, @lastName, @username, @password, @cardNumber, @cvv, @cardExpirationDate, @category_ID)";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@cardNumber", cardNumber);
                    command.Parameters.AddWithValue("@cvv", cvv);
                    command.Parameters.AddWithValue("@cardExpirationDate", cardExpirationDate);
                    command.Parameters.AddWithValue("@category_ID", category_ID);

                    command.ExecuteNonQuery();
                }

            }
        }
        public void UpdateCustomer(int customerId, string newFirstName, string newLastName, string newUsername, string newPassword, string newCardNumber, string newCVV, DateTime newCardExpirationDate)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    // Construct the UPDATE SQL command
                    command.CommandText = @"UPDATE Customer 
                                   SET firstName = @FirstName, 
                                       lastName = @LastName,
                                       username = @Username,
                                       password = @Password,
                                       cardNumber = @CardNumber,
                                       CVV = @CVV,
                                       cardExpirationDate = @CardExpirationDate
                                   WHERE customer_ID = @CustomerID";

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@FirstName", newFirstName);
                    command.Parameters.AddWithValue("@LastName", newLastName);
                    command.Parameters.AddWithValue("@Username", newUsername);
                    command.Parameters.AddWithValue("@Password", newPassword);
                    command.Parameters.AddWithValue("@CardNumber", newCardNumber);
                    command.Parameters.AddWithValue("@CVV", newCVV);
                    command.Parameters.AddWithValue("@CardExpirationDate", newCardExpirationDate);
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    // Execute the UPDATE command
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateCustomerCategoryTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = @"CREATE TABLE IF NOT EXIST [CustomerCategory] (
                                  category_ID PRIMARY KEY INT,
                                  description VARCHAR(50)";

                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }

            }
        }
        public void CreatePaymentTable()
        {
            try {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    string createTableQuery = @"CREATE TABLE IF NOT EXISTS Payment (
                            payment_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                            order_ID INTEGER,
                            amount DECIMAL,
                            paymentType VARCHAR(40),
                            FOREIGN KEY (order_ID) REFERENCES [Order](order_ID))";

                    using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                    {
                        createTableCommand.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating Payment table: {ex.Message}");
            }

        }
        public void InsertIntoPayment(int orderID, decimal amount, string paymentType )
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"INSERT INTO Payment(order_ID, amount, paymentType)
                       VALUES (@order_ID, @amount, @paymentType)";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@order_ID", orderID);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@paymentType", paymentType);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void insertIntoCustomerCategoryTable(string description)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"INSERT INTO [CustomerCategory] (description) 
                       VALUES (@description)";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@description", description);

                    command.ExecuteNonQuery();
                }

            }
        }
    }
}
