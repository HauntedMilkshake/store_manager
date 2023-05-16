using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management
{
    public partial class SignUp : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public SignUp()
        {
            InitializeComponent();
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

        private void procede_Click(object sender, EventArgs e)
        {
            if (canContinue()) 
            {
                Username = username.Text;
                Password = password.Text;
                FirstName = firstName.Text;
                LastName = lastName.Text;
                checkRole();
                InsertUser(Username, Password, FirstName, LastName, Role);
                /*
                if (!AddUser(Username, Password, FirstName, LastName, Role))
                {
                    Console.WriteLine("error when adding user");
                }
                */
               LogIn login = new LogIn();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void SignUpUI_Load(object sender, EventArgs e)
        {

        }
       private bool canContinue()
        {
            Username = username.Text;
            Password = password.Text;
            FirstName = firstName.Text;
            LastName = lastName.Text;
            if(!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)) {
                return true;
            }
            else
            {
                warning.Visible = true;
                return false;
            }
        }
        private void checkRole()
        {
            if (userMode.Checked)
            {
                Role = "user";
            }
            else if(adminMode.Checked)
            {
                Role = "admin";
            }
        }

        

        private void InsertUser(string username, string password, string firstName, string lastName, string role)
        {
            using (OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();

                string insertQuery = "INSERT INTO users (username, [password], first_name, last_name, role, created_at) VALUES (?, ?, ?, ?, ?, ?)";

                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("User added successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding user: " + ex.Message);
                    }
                }
            }
        }


        /*
        public static bool AddUser(string username, string password, string firstName, string lastName, string role)
        {
            try
            {
                string query = "INSERT INTO users (Username, Password, FirstName, LastName, Role) VALUES (@Username, @Password, @FirstName, @LastName, @Role)";
                OleDbParameter[] parameters = new OleDbParameter[]
                {
                    new OleDbParameter("@Username", username),
                    new OleDbParameter("@Password", password),
                    new OleDbParameter("@FirstName", firstName),
                    new OleDbParameter("@LastName", lastName),
                    new OleDbParameter("@Role", role)
                };

                int rowsAffected = Database.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        */
        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameWarning_Click(object sender, EventArgs e)
        {

        }

        private void nameGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
