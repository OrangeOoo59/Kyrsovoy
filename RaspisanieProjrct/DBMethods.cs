using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RaspisanieProjrct
{
    static class DBMethods
    {
        public static DataTable GetTableCommand(string sqlCommand)
        {
            using (SqlConnection connection = Connect())
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    connection.Open();
                    //Console.WriteLine(connection.State);
                    
                    SqlDataAdapter dataAdepter = new SqlDataAdapter(sqlCommand, connection);
                    DataTable dataTable = new DataTable();
                    dataAdepter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        public static void ExecuteSqlCommand(string sqlCommand)
        {
            using (SqlConnection connection = Connect())
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    connection.Open();
                    Console.WriteLine(connection.State);
                    command.ExecuteNonQuery();
                }
            }
        }
        private static SqlConnection Connect()
        {
            string connectionString = GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            return connection;
        }
        static private string GetConnectionString()
        {
            return "Data Source=ORANGE;" +
                "Initial Catalog=Raspisanie;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False";
        }
    }
}
