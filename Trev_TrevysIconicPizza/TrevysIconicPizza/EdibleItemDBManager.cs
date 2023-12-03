using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrevysIconicPizza
{
    internal class EdibleItemDBManager
    {
        // database string
        private const String ConnectionString = "Data Source=trevysIconicPizza.db;Version=3";

        public void CreateTableIfNotExists(String tableName)
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

    }
}
