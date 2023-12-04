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
        public LoginPage()
        {
            InitializeComponent();
           
        }
        // database string
        private const String ConnectionString = "Data Source=trevysIconicPizza.db;Version=3";
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


        //private bool IsValidUser(string username, string password)
        //{
        //    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
        //    {
        //        connection.Open();

        //        using (SQLiteCommand command = new SQLiteCommand(connection))
        //        {
        //            command.CommandText = "SELECT COUNT(*) FROM Customer WHERE username = @username AND password = @password";
        //            command.Parameters.AddWithValue("@username", username);
        //            command.Parameters.AddWithValue("@password", password);

        //            int count = Convert.ToInt32(command.ExecuteScalar());

        //            return count > 0;
        //        }
        //    }
        //}

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT * FROM Customer WHERE username = @username AND password = @password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Login successful
                            MessageBox.Show("Login successful!");

                            // Populate CurrentClient properties from the database
                            CurrentClient.Instance.FirstName = reader["firstName"].ToString();
                            CurrentClient.Instance.LastName = reader["lastName"].ToString();
                            CurrentClient.Instance.Username = reader["username"].ToString();
                            CurrentClient.Instance.Password = reader["password"].ToString();
                            CurrentClient.Instance.CardNumber = reader["cardNumber"].ToString();
                            CurrentClient.Instance.CVV = reader["CVV"].ToString();
                            CurrentClient.Instance.CardExpireDate = Convert.ToDateTime(reader["cardExpirationDate"]);
                            //CurrentClient.Instance.category_ID = char.Parse(reader["category_ID"].ToString());

                            // Open the menu page or perform other actions
                            MenuPage menuPage = new MenuPage();
                            menuPage.Show();
                        }
                        else
                        {
                            // Invalid username or password
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
        }
    }
}