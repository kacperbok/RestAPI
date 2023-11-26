using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace RestAPI
{
    public static class DataBaseEntity
    {
        public static int GetCurrentNumberRange()
        {
            var AS = 0;
            var DBDataBaseConnection = new DataBaseConnection();
            var GetCurrentNumberRangeQuery = String.Format("SELECT NUMBER_RANGE_CURRENT FROM TABLE_NUMBER_RANGE WHERE NUMBER_RANGE_ID = 1");
            var sqlCommand = new SqlCommand(GetCurrentNumberRangeQuery, DBDataBaseConnection.SqlConnection);
            
            SqlDataReader result = sqlCommand.ExecuteReader();
            Console.WriteLine("result " + result.ToString());
            ///////////////////////
            if (result.Read()) 
            {
               var finalResult = result[0].ToString;
               Console.WriteLine("finalResult "+ finalResult);
            }
            DBDataBaseConnection.CloseConnection();

            return AS;
        }


        public static int GetCurrentShipmentId()
        {
            var AS = 0;
            var DBDataBaseConnection = new DataBaseConnection();

            string GetCurrentNumberRangeFromDataBaseQuery = String.Format("select MAX(SHIPMENT_ID) from TABLE_SHIPMENT");

            var sqlCommand = new SqlCommand(GetCurrentNumberRangeFromDataBaseQuery, DBDataBaseConnection.SqlConnection);
            SqlDataReader result = sqlCommand.ExecuteReader();

            ///////////////////////
            while (result.Read())
            {
                var finalResult = result.GetValue(0);
            }
            DBDataBaseConnection.CloseConnection();

            return AS;
        }

        public static void InsertIntoDatabase(Shipment shipment)
        {
            var DBDataBaseConnection = new DataBaseConnection();
            var GetCurrentNumberRangeQuery = String.Format("INSERT INTO TABLE_SHIPMENT VALUES ('={0}','={1}')", shipment.ReceiverName1, shipment.ReceiverName2);
            var sqlCommand = new SqlCommand(GetCurrentNumberRangeQuery, DBDataBaseConnection.SqlConnection);
            SqlDataReader result = sqlCommand.ExecuteReader();

            ///////////////////////
            while (result.Read())
            {
                var finalResult = result.GetValue(1);
            }
            DBDataBaseConnection.CloseConnection();

           
        }

        }
}
