using System.Data.OleDb;
using System.Data;
using System.Configuration;
namespace inventory_management
{
    partial class ProductManagement
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

        private System.Windows.Forms.GroupBox productManagementGB;
        private System.Windows.Forms.DataGridView productDGV;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox pPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.ComboBox pCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.DateTimePicker shelfLife;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button checkShelfLife;
    }
}

