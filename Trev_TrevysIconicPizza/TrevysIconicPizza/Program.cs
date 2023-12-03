using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TrevysIconicPizza
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LandingPage());

            EdibleItemDBManager edibleItemDBM = new EdibleItemDBManager();

            // create table(s) if they don't exist
            edibleItemDBM.CreateTableIfNotExists("EdibleItem");

            // insert the items into EdibleItem table
            InsertInitialItems(edibleItemDBM);
        }

        static void InsertInitialItems(EdibleItemDBManager dbManager)
        {
            // Example: Inserting a pizza and a drink
            dbManager.InsertEdibleItem("EdibleItem", "Pepperoni Pizza", "Small", 14.99m, "Pizza");
            dbManager.InsertEdibleItem("EdibleItem", "Pepperoni Pizza", "Medium", 17.99m, "Pizza");
            dbManager.InsertEdibleItem("EdibleItem", "Pepperoni Pizza", "Large", 19.99m, "Pizza");

            dbManager.InsertEdibleItem("EdibleItem", "Original Pizza", "Small", 10.99m, "Pizza");
            dbManager.InsertEdibleItem("EdibleItem", "Original Pizza", "Medium", 13.99m, "Pizza");
            dbManager.InsertEdibleItem("EdibleItem", "Original Pizza", "Large", 16.99m, "Pizza");

            dbManager.InsertEdibleItem("EdibleItem", "Margherita Pizza", "Small", 13.99m, "Pizza");
            dbManager.InsertEdibleItem("EdibleItem", "Margherita Pizza", "Medium", 16.99m, "Pizza");
            dbManager.InsertEdibleItem("EdibleItem", "Margherita Pizza", "Large", 18.99m, "Pizza");

            dbManager.InsertEdibleItem("EdibleItem", "Vegetarian Pizza", "Small", 13.99m, "Pizza");
            dbManager.InsertEdibleItem("EdibleItem", "Vegetarian Pizza", "Medium", 16.99m, "Pizza");
            dbManager.InsertEdibleItem("EdibleItem", "Vegetarian Pizza", "Large", 19.99m, "Pizza");

            dbManager.InsertEdibleItem("EdibleItem", "Custom Pizza", "Small", null, "Pizza");
            dbManager.InsertEdibleItem("EdibleItem", "Custom Pizza", "Medium", null, "Pizza");
            dbManager.InsertEdibleItem("EdibleItem", "Custom Pizza", "Large", null, "Pizza");

            // Milkshakes
            dbManager.InsertEdibleItem("EdibleItem", "Custom Milkshake", null, null, "Drink");
            dbManager.InsertEdibleItem("EdibleItem", "Strawberry Milkshake", null, 8.99m, "Drink");
            dbManager.InsertEdibleItem("EdibleItem", "Chocolate Milkshake", null, 8.99m, "Drink");
            dbManager.InsertEdibleItem("EdibleItem", "Vanilla Milkshake", null, 8.99m, "Drink");
            dbManager.InsertEdibleItem("EdibleItem", "Soft Drink", null, 2.50m, "Drink");


            // Insert more initial data if needed

        }
    }
    
}
