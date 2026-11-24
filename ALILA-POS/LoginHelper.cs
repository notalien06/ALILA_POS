
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ALILA_POS
{
    public static class LoginHelper
    {
        public static bool ValidateLogin(
            string username,
            string password,
            out string fullName,
            out string roleName)
        {
            fullName = "";
            roleName = "";

            string connectionString =
                ConfigurationManager.ConnectionStrings["LargoPOS"]
                .ConnectionString;

            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT u.PasswordHash, u.Salt,
                           u.FullName, r.RoleName
                    FROM dbo.Users u
                    INNER JOIN dbo.Roles r
                        ON u.RoleId = r.RoleId
                    WHERE u.Username = @Username
                      AND u.IsActive = 1;";

                using (SqlCommand cmd =
                    new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@Username", username);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        string storedHash =
                            reader["PasswordHash"].ToString();

                        string salt =
                            reader["Salt"].ToString();

                        string storedFullName =
                            reader["FullName"].ToString();

                        string storedRole =
                            reader["RoleName"].ToString();

                        string calculatedHash =
                            ComputeHash(salt, password);

                        if (!string.Equals(
                            storedHash,
                            calculatedHash,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            return false;
                        }

                        fullName = storedFullName;
                        roleName = storedRole;
                        return true;
                    }
                }
            }
        }

        private static string ComputeHash(
            string salt, string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(
                    salt + password);

                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder result = new StringBuilder();

                foreach (byte b in hash)
                    result.Append(b.ToString("X2"));

                return result.ToString();
            }
        }
    }
}