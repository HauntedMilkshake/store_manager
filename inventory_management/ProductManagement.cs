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
            this.shelfLife = new System.Windows.Forms.DateTimePicker();
            this.warning = new System.Windows.Forms.Label();
            this.productManagementGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // productManagementGB
            // 
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
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pPrice
            // 
            this.pPrice.Location = new System.Drawing.Point(172, 103);
            this.pPrice.Name = "pPrice";
            this.pPrice.Size = new System.Drawing.Size(131, 20);
            this.pPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price:";
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(172, 19);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(131, 20);
            this.pName.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(6, 19);
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
            // 
            // shelfLife
            // 
            this.shelfLife.Location = new System.Drawing.Point(103, 268);
            this.shelfLife.Name = "shelfLife";
            this.shelfLife.Size = new System.Drawing.Size(200, 20);
            this.shelfLife.TabIndex = 15;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.Location = new System.Drawing.Point(44, 405);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(201, 23);
            this.warning.TabIndex = 16;
            this.warning.Text = "Fields mustn\'t be empty !";
            this.warning.Visible = false;
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


                string name = pName.Text;
                decimal price = Convert.ToDecimal(pPrice.Text);
                string category = pCategory.SelectedItem.ToString();
                string pShelfLife = shelfLife.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string lastUpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                int lastUpdatedBy = userID; // Replace this with the current user's ID


                string query = "INSERT INTO product (name, price, category, shelf_life, last_updated_at, last_updated_by) VALUES (?, ?, ?, ?, ?, ?)";
                OleDbParameter[] parameters = {
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
            }
            else
            {
                warning.Visible = true;
            }
        }
        public void resetText()
        {
            pName.Text = string.Empty;
            pPrice.Text = string.Empty;
            pCategory.Text = string.Empty;

        }
        private void edit_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();
                string name = pName.Text;
                decimal price = Convert.ToDecimal(pPrice.Text);
                string category = pCategory.SelectedItem.ToString();
                string pShelfLife = shelfLife.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string lastUpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                int lastUpdatedBy = userID; // Replace this with the current user's ID

                string updateQuery = "UPDATE product SET name = ?, price = ?, category = ?, shelf_life = ?, last_updated_at = ?, last_updated_by = ? WHERE id = ?";

                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@ShelfLife", shelfLife);
                    command.Parameters.AddWithValue("@LastUpdatedAt", lastUpdatedAt);
                    command.Parameters.AddWithValue("@LastUpdatedBy", lastUpdatedBy);
                    command.Parameters.AddWithValue("@ProductId", getProductId(name));

                    command.ExecuteNonQuery();
                }
            }
            LoadProducts();
            resetText();
        }
        private int getProductId(string name)
        {
            using (OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();

                string selectQuery = "SELECT id FROM product WHERE name = ?";

                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", name);

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

        private void delete_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(Database.GetConnectionString()))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM product WHERE id = ?";

                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", getProductId(pName.Text));

                    command.ExecuteNonQuery();
                }
            }
            LoadProducts();
            resetText();
        }
    }
}
