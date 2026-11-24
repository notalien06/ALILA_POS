
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ALILA_POS.Data
{
    public class CategoryRepository
    {
        public Dictionary<int, string> GetAll()
        {
            var categories = new Dictionary<int, string>();

            using (SqlConnection conn = Db.GetConnection())
            {
                string query = @"
                    SELECT CategoryId, Name
                    FROM dbo.Categories
                    ORDER BY Name;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(
                                System.Convert.ToInt32(reader["CategoryId"]),
                                System.Convert.ToString(reader["Name"])
                            );
                        }
                    }
                }
            }

            return categories;
        }
    }
}
