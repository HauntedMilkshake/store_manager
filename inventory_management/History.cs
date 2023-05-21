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
    public partial class History : Form
    {
        public int userID { get; set; }

        public History()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
      
        private void productsButton_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.userID = this.userID;
            this.Hide();
            productManagement.Show();
        }
        /*
        private DataTable GetProductHistory()
        {
            string selectQuery = "SELECT product.[id], product.[name], product.[price], product.[category], product.[shelf_life], product.[last_updated_at], users.[username] AS [last_updated_by] FROM [product] INNER JOIN [users] ON product.[last_updated_by] = users.[id]";

            return Database.ExecuteQuery(selectQuery);
        }
        */
        private void LoadProductData()
        {
            using (OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();
                string selectQuery = "SELECT product.id, product.name, product.price, product.category, product.shelf_life, product.last_updated_at, users.username AS last_updated_by FROM product INNER JOIN users ON product.last_updated_by = users.id";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        productsHistory.DataSource = dt;
                    }
                }
            }
        }

        private void LoadInventory()
        {
            string query = @"
        SELECT 
            inventory.id, 
            inventory.quantity, 
            inventory.reorder_level, 
            inventory.restock, 
            inventory.product_id, 
            inventory.last_updated_at, 
            users.username AS last_updated_by
        FROM 
            inventory 
        INNER JOIN 
            users 
        ON 
            inventory.last_updated_by = users.id
    ";

            DataTable inventoryDatatable = Database.ExecuteQuery(query);
            inventoryHistory.DataSource = inventoryDatatable;

        }
        private void productsHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshProducts_Click(object sender, EventArgs e)
        {

            LoadProductData();


            string role = GetUserRoleById(userID);
            if (role == "user")
            {
                productsHistory.ReadOnly = true;
            }
            else if (role == "admin")
            {
                productsHistory.ReadOnly = false;
            }
        }
        public string GetUserRoleById(int userId)
        {
            string userRole = "";
            using (OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();

                string selectQuery = "SELECT role FROM users WHERE id = ?";

                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", userId);

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        userRole = reader.GetString(0);
                    }
                }
            }
            return userRole;
        }

        private void refreshInventory_Click(object sender, EventArgs e)
        {
            LoadInventory();
            string role = GetUserRoleById(userID);
            if (role == "user")
            {
                productsHistory.ReadOnly = true;
            }
            else if (role == "admin")
            {
                productsHistory.ReadOnly = false;
            }
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            InventoryManagement form = new InventoryManagement();
            form.userID = this.userID;
            this.Hide();
            form.Show();
        }
    }

}
