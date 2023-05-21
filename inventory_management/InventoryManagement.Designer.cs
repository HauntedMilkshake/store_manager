namespace inventory_management
{
    partial class InventoryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.reorderQuantity = new System.Windows.Forms.TextBox();
            this.reorderLevel = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.inventoryID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.ComboBox();
            this.restock = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.restock);
            this.groupBox1.Controls.Add(this.productID);
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.warning);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Controls.Add(this.products);
            this.groupBox1.Controls.Add(this.history);
            this.groupBox1.Controls.Add(this.reorderQuantity);
            this.groupBox1.Controls.Add(this.reorderLevel);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.inventoryID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inventory);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(140, 494);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(97, 36);
            this.refresh.TabIndex = 23;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // warning
            // 
            this.warning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.warning.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.Location = new System.Drawing.Point(89, 292);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(210, 23);
            this.warning.TabIndex = 22;
            this.warning.Text = "All fields must have input! ";
            this.warning.Visible = false;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(119, 340);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(149, 36);
            this.add.TabIndex = 20;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(283, 340);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(98, 36);
            this.delete.TabIndex = 19;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(6, 340);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(98, 36);
            this.edit.TabIndex = 18;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // products
            // 
            this.products.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.Location = new System.Drawing.Point(285, 494);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(98, 36);
            this.products.TabIndex = 17;
            this.products.Text = "products";
            this.products.UseVisualStyleBackColor = true;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(6, 494);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(98, 36);
            this.history.TabIndex = 16;
            this.history.Text = "history";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // reorderQuantity
            // 
            this.reorderQuantity.Location = new System.Drawing.Point(263, 168);
            this.reorderQuantity.Name = "reorderQuantity";
            this.reorderQuantity.Size = new System.Drawing.Size(120, 20);
            this.reorderQuantity.TabIndex = 9;
            // 
            // reorderLevel
            // 
            this.reorderLevel.Location = new System.Drawing.Point(263, 127);
            this.reorderLevel.Name = "reorderLevel";
            this.reorderLevel.Size = new System.Drawing.Size(120, 20);
            this.reorderLevel.TabIndex = 8;
            this.reorderLevel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(263, 76);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(120, 20);
            this.quantity.TabIndex = 7;
            // 
            // inventoryID
            // 
            this.inventoryID.Location = new System.Drawing.Point(263, 21);
            this.inventoryID.Name = "inventoryID";
            this.inventoryID.Size = new System.Drawing.Size(120, 20);
            this.inventoryID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product id:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity to reorder: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Under how many to reorder:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory ID:";
            // 
            // inventory
            // 
            this.inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory.Location = new System.Drawing.Point(389, 20);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(764, 510);
            this.inventory.TabIndex = 0;
            this.inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventory_CellContentClick);
            // 
            // productID
            // 
            this.productID.FormattingEnabled = true;
            this.productID.Location = new System.Drawing.Point(263, 218);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(121, 21);
            this.productID.TabIndex = 24;
            // 
            // restock
            // 
            this.restock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restock.Location = new System.Drawing.Point(140, 424);
            this.restock.Name = "restock";
            this.restock.Size = new System.Drawing.Size(97, 36);
            this.restock.TabIndex = 25;
            this.restock.Text = "restock";
            this.restock.UseVisualStyleBackColor = true;
            this.restock.Click += new System.EventHandler(this.restock_Click);
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "InventoryManagement";
            this.Text = "InventoryManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView inventory;
        private System.Windows.Forms.TextBox reorderQuantity;
        private System.Windows.Forms.TextBox reorderLevel;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox inventoryID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ComboBox productID;
        private System.Windows.Forms.Button restock;
    }
}