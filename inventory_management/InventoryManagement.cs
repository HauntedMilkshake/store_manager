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
    public partial class InventoryManagement : Form
    {
        public int userID {  get; set; }
        public InventoryManagement()
        {
            InitializeComponent();
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
            inventory.DataSource = inventoryDatatable;
            
        }
        private bool canAdd()
        {
            if (!string.IsNullOrEmpty(inventoryID.Text) && !string.IsNullOrEmpty(quantity.Text) && !string.IsNullOrEmpty(reorderQuantity.Text) && !string.IsNullOrEmpty(productID.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public void resetText()
        {
            inventoryID.Text = string.Empty;
            quantity.Text = string.Empty;   
            reorderLevel.Text = string.Empty;
            reorderQuantity.Text = string.Empty;
            productID.Text = string.Empty;
             
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadInventory();
            LoadProductsIntoComboBox();
        }
        private void LoadProductsIntoComboBox()
        {
            string selectQuery = "SELECT id, name FROM product";
            DataTable productDataTable = Database.ExecuteQuery(selectQuery);

            foreach (DataRow row in productDataTable.Rows)
            {
                string item = $"ID: {row["id"].ToString()} - Name: {row["name"].ToString()}";
                productID.Items.Add(item);
            }
        }
        private void products_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.userID = this.userID;
            this.Hide();
            productManagement.Show();
        }

        private void history_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.userID = this.userID;
            this.Hide();
            history.ShowDialog();
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            if (canAdd())
            {
                string inventoryId = inventoryID.Text;
                int quantityF = Int32.Parse(quantity.Text);
                int reorderLevelF = Int32.Parse(reorderLevel.Text);
                int reorderQuantityF = Int32.Parse(reorderQuantity.Text);
                string lastUpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                if (productID.SelectedItem == null)
                {
                    MessageBox.Show("Please select a product before proceeding.");
                    return;
                }
                string selectedProduct = productID.SelectedItem.ToString();
                string productIDF = selectedProduct.Split(' ')[1];  // extract the ID part from the string

                if (add.Text == "Update")
                {
                    string updateQuery = "UPDATE inventory SET quantity = ?, reorder_level = ?, restock = ?, product_id = ?, last_updated_at = ?, last_updated_by = ? WHERE id = ?";
                    OleDbParameter[] parameters = {
                new OleDbParameter("@quantity", quantityF),
                new OleDbParameter("@reorder_level", reorderLevelF),
                new OleDbParameter("@restock", reorderQuantityF),
                new OleDbParameter("@product_id", productIDF),
                new OleDbParameter("@last_updated_at", lastUpdatedAt),
                new OleDbParameter("@last_updated_by", userID),
                new OleDbParameter("@id", inventoryId)
            };
                    Database.ExecuteNonQuery(updateQuery, parameters);
                    add.Text = "Add"; // Switch back to the Add mode
                }
                else // the Add mode
                {
                    string insertQuery = "INSERT INTO inventory (id, quantity, reorder_level, restock, product_id, last_updated_at, last_updated_by) VALUES (?, ?, ?, ?, ?, ?, ?)";
                    OleDbParameter[] parameters = {
                new OleDbParameter("@id", inventoryId),
                new OleDbParameter("@quantity", quantityF),
                new OleDbParameter("@reorder_level", reorderLevelF),
                new OleDbParameter("@restock", reorderQuantityF),
                new OleDbParameter("@product_id", productIDF),
                new OleDbParameter("@last_updated_at", lastUpdatedAt),
                new OleDbParameter("@last_updated_by", userID),
            };
                    Database.ExecuteNonQuery(insertQuery, parameters);
                }
                LoadInventory();
                resetText();
                warning.Visible = false;
            }
            else
            {
                warning.Visible = true;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (inventory.SelectedRows.Count > 0)
            {
                string id = inventory.SelectedRows[0].Cells[0].Value.ToString();  // Assuming 'ID' is in the first column of your DataGridView
                string deleteQuery = "DELETE FROM inventory WHERE id = ?";
                OleDbParameter[] parameters = {
            new OleDbParameter("@id", id)
        };
                Database.ExecuteNonQuery(deleteQuery, parameters);
                LoadInventory();
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private bool IdExistsInInventory(string inventoryId)
        {
            using (OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();
                string selectQuery = "SELECT COUNT(*) FROM inventory WHERE id = ?";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", inventoryId);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (inventory.SelectedRows.Count > 0)
            {
                string id = inventory.SelectedRows[0].Cells[0].Value.ToString();
                inventoryID.Text = id;
                quantity.Text = inventory.SelectedRows[0].Cells[1].Value.ToString();
                reorderLevel.Text = inventory.SelectedRows[0].Cells[2].Value.ToString();
                reorderQuantity.Text = inventory.SelectedRows[0].Cells[3].Value.ToString();
                productID.Text = inventory.SelectedRows[0].Cells[4].Value.ToString();

                // switch to the edit mode 
                add.Text = "Update";
            }
            else
            {
                MessageBox.Show("Please select a row to edit");
            }
        }

        private void restock_Click(object sender, EventArgs e)
        {
            CheckAndRestockInventory();

        }
        private void CheckAndRestockInventory()
        {
            if (inventory.SelectedRows.Count > 0)
            {
                int inventoryId = Convert.ToInt32(inventory.SelectedRows[0].Cells[0].Value);
                int quantity = Convert.ToInt32(inventory.SelectedRows[0].Cells[1].Value);
                int reorderLevel = Convert.ToInt32(inventory.SelectedRows[0].Cells[2].Value);
                int restockAmount = Convert.ToInt32(inventory.SelectedRows[0].Cells[3].Value);

                if (quantity < reorderLevel)
                {
                    // Restock to the reorder level
                    int newQuantity = quantity + restockAmount;

                    string updateQuery = "UPDATE inventory SET quantity = @new_quantity, last_updated_at = @last_updated_at, last_updated_by = @last_updated_by WHERE id = @id";
                    OleDbParameter[] parameters = {
                new OleDbParameter("@new_quantity", newQuantity),
                new OleDbParameter("@last_updated_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                new OleDbParameter("@last_updated_by", userID),
                new OleDbParameter("@id", inventoryId)
            };

                    Database.ExecuteNonQuery(updateQuery, parameters);
                    LoadInventory();
                    MessageBox.Show("Inventory restocked.");
                }
            }
            else
            {
                MessageBox.Show("Please select an inventory item.");
            }
        }

    }
}

