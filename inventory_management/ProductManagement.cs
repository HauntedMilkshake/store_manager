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

namespace inventory_management
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
        }
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyAccessDB"].ConnectionString;
        }

        private void AccessDatabaseExample()
        {
            string connectionString = GetConnectionString();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM Products", connection);

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Do something with the data, for example, display it in a DataGridView.
            }


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ProductManagement
            // 
            this.ClientSize = new System.Drawing.Size(933, 601);
            this.Name = "ProductManagement";
            this.ResumeLayout(false);

        }
    }
}
