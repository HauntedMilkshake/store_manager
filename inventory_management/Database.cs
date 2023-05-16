using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace inventory_management
{
    public static class Database
    {
        // Set your connection string here
        private static string connectionString = ConfigurationManager.ConnectionStrings["MyAccessDB"].ConnectionString;

        public static string GetConnectionString()
        {
            return connectionString;
        }

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }

        public static int ExecuteNonQuery(string query, OleDbParameter[] parameters = null)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteQuery(string query, OleDbParameter[] parameters = null)
        {
            using (OleDbConnection connection = GetConnection())
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable result = new DataTable();
                        adapter.Fill(result);
                        return result;
                    }
                }
            }
        }
    }
}
