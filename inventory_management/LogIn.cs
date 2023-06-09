﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management
{
    public partial class LogIn : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
     
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        
        private void procede_Click(object sender, EventArgs e)
        {
            try
            {
                if (canContinue())
                {
                    if (ValidateUserCredentials(Username, Password))
                    {
                        addLastLogin(Username);
                        ProductManagement form = new ProductManagement();
                        form.userID = GetUserIdByUsername(Username);
                        this.Hide();
                        this.Close();
                        form.ShowDialog();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private bool ValidateUserCredentials(string username, string password)
        {
            using (OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();

                string selectQuery = "SELECT COUNT(*) FROM users WHERE username = ? AND password = ?";

                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                   
                }
            }
        }
        private void addLastLogin(string username)
        {
           using(OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();

                string selectQuery = "UPDATE users SET last_login = ? WHERE username = ?";

                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@LastLogin", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@Username", username);

                    command.ExecuteNonQuery(); // Add this line
                }
            }
        }
        public static int GetUserIdByUsername(string username)
        {
            using (OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();

                string selectQuery = "SELECT id FROM users WHERE username = ?";

                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int userId))
                    {
                        return userId;
                    }
                    else
                    {
                        return -1; // Return -1 if the user ID is not found or there's an issue with the data.
                    }
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.ShowDialog();
        }

        private Boolean canContinue()
        {
            Username = username.Text; 
            Password = password.Text;
            if(!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password)) 
            {
                return true;
            }
            else
            {
                warning.Visible = true;
                return false;
            }
        }
    }
}
