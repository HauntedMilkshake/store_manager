using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics.Eventing.Reader;

namespace inventory_management
{
    public partial class ProductManagement : Form
    {
        public int userID { get; set; }
        public ProductManagement()
        {
            InitializeComponent();
        }
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyAccessDB"].ConnectionString;
        }

      
        private void LoadProducts()
        {
            string query = "SELECT * FROM product";
            DataTable products = Database.ExecuteQuery(query);
            productDGV.DataSource = products;
        }

        private void InitializeComponent()
        {
            this.productManagementGB = new System.Windows.Forms.GroupBox();
            this.checkShelfLife = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.shelfLife = new System.Windows.Forms.DateTimePicker();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.productDGV = new System.Windows.Forms.DataGridView();
            this.productManagementGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // productManagementGB
            // 
            this.productManagementGB.Controls.Add(this.checkShelfLife);
            this.productManagementGB.Controls.Add(this.refresh);
            this.productManagementGB.Controls.Add(this.productID);
            this.productManagementGB.Controls.Add(this.label1);
            this.productManagementGB.Controls.Add(this.warning);
            this.productManagementGB.Controls.Add(this.shelfLife);
            this.productManagementGB.Controls.Add(this.delete);
            this.productManagementGB.Controls.Add(this.edit);
            this.productManagementGB.Controls.Add(this.inventory);
            this.productManagementGB.Controls.Add(this.history);
            this.productManagementGB.Controls.Add(this.label4);
            this.productManagementGB.Controls.Add(this.pCategory);
            this.productManagementGB.Controls.Add(this.label3);
            this.productManagementGB.Controls.Add(this.pPrice);
            this.productManagementGB.Controls.Add(this.label2);
            this.productManagementGB.Controls.Add(this.pName);
            this.productManagementGB.Controls.Add(this.nameLabel);
            this.productManagementGB.Controls.Add(this.add);
            this.productManagementGB.Controls.Add(this.productDGV);
            this.productManagementGB.Location = new System.Drawing.Point(12, 13);
            this.productManagementGB.Name = "productManagementGB";
            this.productManagementGB.Size = new System.Drawing.Size(1160, 536);
            this.productManagementGB.TabIndex = 0;
            this.productManagementGB.TabStop = false;
            // 
            // checkShelfLife
            // 
            this.checkShelfLife.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShelfLife.Location = new System.Drawing.Point(117, 433);
            this.checkShelfLife.Name = "checkShelfLife";
            this.checkShelfLife.Size = new System.Drawing.Size(82, 37);
            this.checkShelfLife.TabIndex = 20;
            this.checkShelfLife.Text = "check";
            this.checkShelfLife.UseVisualStyleBackColor = true;
            this.checkShelfLife.Click += new System.EventHandler(this.checkShelfLife_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(116, 493);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(83, 36);
            this.refresh.TabIndex = 19;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(172, 34);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(131, 20);
            this.productID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product ID";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.Location = new System.Drawing.Point(54, 383);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(201, 23);
            this.warning.TabIndex = 16;
            this.warning.Text = "Fields mustn\'t be empty !";
            this.warning.Visible = false;
            // 
            // shelfLife
            // 
            this.shelfLife.Location = new System.Drawing.Point(103, 268);
            this.shelfLife.Name = "shelfLife";
            this.shelfLife.Size = new System.Drawing.Size(200, 20);
            this.shelfLife.TabIndex = 15;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(205, 314);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(87, 36);
            this.delete.TabIndex = 14;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(6, 314);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(84, 36);
            this.edit.TabIndex = 13;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // inventory
            // 
            this.inventory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(205, 493);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(98, 36);
            this.inventory.TabIndex = 12;
            this.inventory.Text = "inventory";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(12, 493);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(98, 36);
            this.history.TabIndex = 11;
            this.history.Text = "history";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Shelf Life:";
            // 
            // pCategory
            // 
            this.pCategory.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCategory.FormattingEnabled = true;
            this.pCategory.Items.AddRange(new object[] {
            "Плодове",
            "Зеленчуци",
            "Месо ",
            "Риба ",
            "Млечни",
            "Животински",
            "Други",
            "Био"});
            this.pCategory.Location = new System.Drawing.Point(172, 177);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(131, 22);
            this.pCategory.TabIndex = 9;
            this.pCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pPrice
            // 
            this.pPrice.Location = new System.Drawing.Point(172, 131);
            this.pPrice.Name = "pPrice";
            this.pPrice.Size = new System.Drawing.Size(131, 20);
            this.pPrice.TabIndex = 5;
            this.pPrice.TextChanged += new System.EventHandler(this.pPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price:";
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(172, 82);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(131, 20);
            this.pName.TabIndex = 3;
            this.pName.TextChanged += new System.EventHandler(this.pName_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(2, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(123, 23);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Product name:";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(96, 314);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(103, 36);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // productDGV
            // 
            this.productDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDGV.Location = new System.Drawing.Point(309, 19);
            this.productDGV.Name = "productDGV";
            this.productDGV.Size = new System.Drawing.Size(844, 511);
            this.productDGV.TabIndex = 0;
            this.productDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDGV_CellContentClick);
            // 
            // ProductManagement
            // 
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.productManagementGB);
            this.Name = "ProductManagement";
            this.productManagementGB.ResumeLayout(false);
            this.productManagementGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
        private bool canAdd()
        {
            if(!string.IsNullOrEmpty(pName.Text) && !string.IsNullOrEmpty(pPrice.Text) && !string.IsNullOrEmpty(pCategory.Text) && !string.IsNullOrEmpty(shelfLife.Text)){
                return true;
            }else {
                return false;
            }



        }
        private void add_Click(object sender, EventArgs e)
        {
            if (canAdd())
            {

                string productId = productID.Text;
                string name = pName.Text;
                decimal price = Convert.ToDecimal(pPrice.Text);
                string category = pCategory.SelectedItem.ToString();
                string pShelfLife = shelfLife.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string lastUpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                int lastUpdatedBy = userID; // Replace this with the current user's ID


                string query = "INSERT INTO product (id, name, price, category, shelf_life, last_updated_at, last_updated_by) VALUES (?, ?, ?, ?, ?, ?, ?)";
                OleDbParameter[] parameters = {
                new OleDbParameter("@id", productId),
                new OleDbParameter("@name", name),
                new OleDbParameter("@price", price),
                new OleDbParameter("@category", category),
                new OleDbParameter("@shelf_life", pShelfLife),
                new OleDbParameter("@last_updated_at", lastUpdatedAt),
                new OleDbParameter("@last_updated_by", lastUpdatedBy)
            };

                Database.ExecuteNonQuery(query, parameters);
                LoadProducts();
                resetText();
                warning.Visible = false;
            }
            else
            {
                warning.Visible = true;
            }
        }
        public void resetText()
        {
            productID.Text = string.Empty;
            pName.Text = string.Empty;
            pPrice.Text = string.Empty;
            pCategory.Text = string.Empty;

        }
        private void edit_Click(object sender, EventArgs e)
        {
            if (productDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product from the table to edit.");
                return;
            }

            string productId = productID.Text;
            string name = pName.Text;
            decimal price;
            Console.WriteLine("pPrice.Text: '" + pPrice.Text + "'");
            decimal price;
            if (!decimal.TryParse(pPrice.Text, out price))
            {
                MessageBox.Show("Price must be a valid decimal number.");
                return;
            }
            string category = pCategory.SelectedItem.ToString();
            string pShelfLife = shelfLife.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string lastUpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int lastUpdatedBy = userID; // Replace this with the current user's ID

            string updateQuery = "UPDATE product SET name = ?, price = ?, category = ?, shelf_life = ?, last_updated_at = ?, last_updated_by = ? WHERE id = ?";

            OleDbParameter[] parameters = {
    new OleDbParameter("@Name", name),
    new OleDbParameter("@Price", price),
    new OleDbParameter("@Category", category),
    new OleDbParameter("@ShelfLife", pShelfLife),
    new OleDbParameter("@LastUpdatedAt", lastUpdatedAt),
    new OleDbParameter("@LastUpdatedBy", lastUpdatedBy),
    new OleDbParameter("@ProductId", productId)
    };

            Database.ExecuteNonQuery(updateQuery, parameters);
            LoadProducts();
            resetText();
            add.Text = "Add"; // Switch back to Add mode after updating
        }



        private void delete_Click(object sender, EventArgs e)
        {
            if (productDGV.SelectedRows.Count > 0)
            {
                string id = productDGV.SelectedRows[0].Cells[0].Value.ToString();  // Assuming 'ID' is in the first column of your DataGridView
                string deleteQuery = "DELETE FROM product WHERE id = ?";
                OleDbParameter[] parameters = {
            new OleDbParameter("@id", id)
        };
                Database.ExecuteNonQuery(deleteQuery, parameters);
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.userID = this.userID;
            this.Hide();
            history.ShowDialog();
        }

        private void pPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void pName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventory_Click(object sender, EventArgs e)
        {
           InventoryManagement inventoryManagement = new InventoryManagement(); 
            inventoryManagement.userID = this.userID;
            this.Hide();
            inventoryManagement.ShowDialog();   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void checkShelfLife_Click(object sender, EventArgs e)
        {
            if (productDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product row first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectedRow = productDGV.SelectedRows[0];
            string productId = selectedRow.Cells["id"].Value.ToString();
            DateTime shelfLife = Convert.ToDateTime(selectedRow.Cells["shelf_life"].Value);

            // Check if product exists in inventory.
            if (!ProductExistsInInventory(productId))
            {
                MessageBox.Show("The selected product does not have an inventory entry. Please create one.", "Product Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DateTime.Now > shelfLife)
            {
                MessageBox.Show("The selected product has expired. Updating product shelf life and inventory quantity to 0.", "Product Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateExpiredProduct(productId);
                LoadProducts();
            }
            else
            {
                MessageBox.Show("The selected product is within its shelf life.", "Product Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ProductExistsInInventory(string productId)
        {
            bool exists = false;
            using (OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM inventory WHERE product_id = ?";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@product_id", productId);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    exists = count > 0;
                }
            }
            return exists;
        }



        private bool IsExpired(DateTime lastUpdatedAt, int shelfLifeInDays)
        {
            return DateTime.Now > lastUpdatedAt.AddDays(shelfLifeInDays);
        }

        private void UpdateExpiredProduct(string productId)
        {
            string updateProductQuery = "UPDATE product SET shelf_life = 0 WHERE id = ?";
            Database.ExecuteNonQuery(updateProductQuery, new OleDbParameter[] { new OleDbParameter("@id", productId) });

            string updateInventoryQuery = "UPDATE inventory SET quantity = 0 WHERE product_id = ?";
            Database.ExecuteNonQuery(updateInventoryQuery, new OleDbParameter[] { new OleDbParameter("@product_id", productId) });
        }

        private void productDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.productDGV.Rows[e.RowIndex];

                productID.Text = row.Cells["id"].Value.ToString();
                pName.Text = row.Cells["name"].Value.ToString();
                pPrice.Text = row.Cells["price"].Value.ToString();
                pCategory.SelectedItem = row.Cells["category"].Value.ToString();
                shelfLife.Value = Convert.ToDateTime(row.Cells["shelf_life"].Value);
                add.Text = "Update"; // Switch the button to Update mode
            }
        }
    }
}
