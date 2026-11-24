
using System.Configuration;
using System.Data.SqlClient;

namespace ALILA_POS.Data
{
    public static class Db
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                ConfigurationManager
                    .ConnectionStrings["LargoPOS"]
                    .ConnectionString;

            return new SqlConnection(connectionString);
        }
    }
}
