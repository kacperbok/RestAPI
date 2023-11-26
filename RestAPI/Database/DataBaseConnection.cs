using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    public class DataBaseConnection
    {
        const string DATA_SOURCE = "WIN-PC28Z1P7";
        const string INITIAL_CATALOG = "Rest";
        const bool INTEGRATED_SECURITY = true;
        private string connectionString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security={2}", DATA_SOURCE, INITIAL_CATALOG, INTEGRATED_SECURITY);

        public SqlConnection SqlConnection { get; private set; }

        public DataBaseConnection()
        {
            SqlConnection = new SqlConnection(connectionString);
            OpenConnection();
        }

        public void CloseConnection()
        {
            SqlConnection.Close();
        }

        private void OpenConnection()
        {
            if (!IsConnectionOpen())
            {
                SqlConnection.Open();

                    if (SqlConnection.State == System.Data.ConnectionState.Open)
                    {
                        Console.WriteLine("Connected successfully");
                    }
            }   
        }

        private bool IsConnectionOpen()
        {
            return SqlConnection.State == System.Data.ConnectionState.Open; 
        }
    }
}
