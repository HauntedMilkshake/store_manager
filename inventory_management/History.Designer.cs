namespace inventory_management
{
    partial class History
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
            this.historyGB = new System.Windows.Forms.GroupBox();
            this.refreshInventory = new System.Windows.Forms.Button();
            this.refreshProducts = new System.Windows.Forms.Button();
            this.inventoryHistory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.productsHistory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.productsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.historyGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // historyGB
            // 
            this.historyGB.Controls.Add(this.refreshInventory);
            this.historyGB.Controls.Add(this.refreshProducts);
            this.historyGB.Controls.Add(this.inventoryHistory);
            this.historyGB.Controls.Add(this.label3);
            this.historyGB.Controls.Add(this.productsHistory);
            this.historyGB.Controls.Add(this.label2);
            this.historyGB.Controls.Add(this.productsButton);
            this.historyGB.Controls.Add(this.inventoryButton);
            this.historyGB.Location = new System.Drawing.Point(13, 13);
            this.historyGB.Name = "historyGB";
            this.historyGB.Size = new System.Drawing.Size(1314, 776);
            this.historyGB.TabIndex = 0;
            this.historyGB.TabStop = false;
            // 
            // refreshInventory
            // 
            this.refreshInventory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshInventory.Location = new System.Drawing.Point(7, 458);
            this.refreshInventory.Name = "refreshInventory";
            this.refreshInventory.Size = new System.Drawing.Size(75, 23);
            this.refreshInventory.TabIndex = 8;
            this.refreshInventory.Text = "refresh";
            this.refreshInventory.UseVisualStyleBackColor = true;
            this.refreshInventory.Click += new System.EventHandler(this.refreshInventory_Click);
            // 
            // refreshProducts
            // 
            this.refreshProducts.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshProducts.Location = new System.Drawing.Point(6, 101);
            this.refreshProducts.Name = "refreshProducts";
            this.refreshProducts.Size = new System.Drawing.Size(75, 23);
            this.refreshProducts.TabIndex = 7;
            this.refreshProducts.Text = "refresh";
            this.refreshProducts.UseVisualStyleBackColor = true;
            this.refreshProducts.Click += new System.EventHandler(this.refreshProducts_Click);
            // 
            // inventoryHistory
            // 
            this.inventoryHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryHistory.Location = new System.Drawing.Point(7, 487);
            this.inventoryHistory.Name = "inventoryHistory";
            this.inventoryHistory.Size = new System.Drawing.Size(1301, 289);
            this.inventoryHistory.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(642, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventory";
            // 
            // productsHistory
            // 
            this.productsHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsHistory.Location = new System.Drawing.Point(7, 130);
            this.productsHistory.Name = "productsHistory";
            this.productsHistory.Size = new System.Drawing.Size(1301, 289);
            this.productsHistory.TabIndex = 4;
            this.productsHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsHistory_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Products";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // productsButton
            // 
            this.productsButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.Location = new System.Drawing.Point(1156, 19);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(152, 38);
            this.productsButton.TabIndex = 1;
            this.productsButton.Text = "products";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.Location = new System.Drawing.Point(7, 20);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(152, 38);
            this.inventoryButton.TabIndex = 0;
            this.inventoryButton.Text = "inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 801);
            this.Controls.Add(this.historyGB);
            this.Name = "History";
            this.Text = "History";
            this.historyGB.ResumeLayout(false);
            this.historyGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox historyGB;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.DataGridView productsHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView inventoryHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button refreshInventory;
        private System.Windows.Forms.Button refreshProducts;
    }
}