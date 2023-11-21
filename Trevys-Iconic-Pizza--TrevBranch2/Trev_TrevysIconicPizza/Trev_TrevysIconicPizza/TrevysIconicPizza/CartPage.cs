﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.IO;

namespace TrevysIconicPizza
{
    public partial class CartPage : Form
    {
        private static CartPage _instance;
        public CartPage()
        {
            InitializeComponent();
            checkEmpty();
        }

        public static CartPage GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CartPage();
                _instance.FormClosed += (sender, args) => _instance = null; // Handle the FormClosed event to reset the instance
            }
            return _instance;
        }




        private void removeButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to remove the selected item?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cartListBox.Items.RemoveAt(cartListBox.SelectedIndex);
                    checkEmpty();
                }
            }
        }


        //Checks if the listBox is empty
        public bool checkEmpty()
        {
            bool result = false;

            // If cart is empty display empty cart message
            if (cartListBox.Items.Count == 0)
            {
                emptyLabel.Show();
                editButton.Enabled = false;
                removeButton.Enabled = false;
                result = true;
            } else
            {
                emptyLabel.Hide();
                editButton.Enabled = true;
                removeButton.Enabled = true;
            }
            return result;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //This is for testing
            
            //Pizza p = new Pizza("vegetarian", "s", null);
            //cartListBox.Items.Add(p.ToString());
            

            List<String> test = new List<string>();

            foreach(String item in cartListBox.Items)
            {
                test.Add(item);
            }

            checkEmpty();
        }

        public void AddPizzaToCart(Pizza pizza)
        {
            //cartListBox.Refresh();
            cartListBox.Items.Add(pizza.ToString());
            checkEmpty();

            cartListBox.Refresh();

        }

        private void CartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the form when the close button is clicked
            
        }

        
    }
}
