using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;

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


        public void InsertOrderToOrderTable(string customerId)
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

        // call it when the order is being placed
        public void UpdateCustomPizzaPrice(int newPrice, string size)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Construct the SQL UPDATE statement to update price for a specific size of custom pizza in all orders
                string sql = $@"UPDATE Order
                        SET price = @NewPrice
                        WHERE edibleItem_ID IN (
                            SELECT edibleItem_ID 
                            FROM EdibleItem 
                            WHERE name = 'Custom Pizza' AND size = @Size
                        )";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@NewPrice", newPrice);
                    command.Parameters.AddWithValue("@Size", size);

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

    }




}

