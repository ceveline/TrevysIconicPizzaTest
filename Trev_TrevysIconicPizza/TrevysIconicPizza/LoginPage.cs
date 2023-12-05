using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrevysIconicPizza
{

    public partial class LoginPage : Form
    {
        // database string
        private const String ConnectionString = "Data Source=trevysIconicPizza.db;Version=3";
        public LoginPage()
        {
            InitializeComponent();
        }
        
        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }


        private bool IsValidUser(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT COUNT(*) FROM Customer WHERE username = @username AND password = @password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Perform authentication logic here, e.g., check credentials against the database
            // Return true if authentication is successful, false otherwise
            // You need to implement this method based on your database structure and authentication requirements
            // Example: check credentials against the database
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Customer WHERE username = @Username AND password = @Password";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0; // If count is greater than 0, authentication is successful
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
                string username = UserNameTextBox.Text;
                string password = PasswordTextBox.Text;

                // Perform authentication logic (check username and password against the database)
                bool isAuthenticated = AuthenticateUser(username, password);

                if (isAuthenticated)
                {
                    // If authentication is successful, populate CurrentClient
                    CurrentClient.Instance.PopulateFromDatabase(username, password);

                    // Now you can access CurrentClient properties
                    string firstName = CurrentClient.Instance.FirstName;
                    string lastName = CurrentClient.Instance.LastName;

                    // Navigate to the MenuPage
                    MenuPage menuPageForm = new MenuPage();
                    menuPageForm.Show();

                    // Close the current login form or hide it
                    this.Close();
                }
                else
                {
                    // Handle unsuccessful authentication (show error message, etc.)
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

       

}