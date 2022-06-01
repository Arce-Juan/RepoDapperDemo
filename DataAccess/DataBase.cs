
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataBase
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DapperConnectionString"].ConnectionString;
            }
        }

        public static SqlConnection GetSqlConnection()
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();

            return conn;
        }


    }
}
