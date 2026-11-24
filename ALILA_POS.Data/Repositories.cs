
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ALILA_POS.Domain;

namespace ALILA_POS.Data
{
    public class ProductRepository
    {
        public List<Product> GetAll()
        {
            var products = new List<Product>();

            using (SqlConnection conn = Db.GetConnection())
            {
                string query = @"
                    SELECT ProductId, Sku, Barcode, Name,
                           CategoryId, Price, Cost, StockQty,
                           ReorderLevel, Image, IsActive
                    FROM dbo.Products
                    ORDER BY Name;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                ProductId = GetInt(reader, "ProductId"),
                                Sku = GetString(reader, "Sku"),
                                Barcode = GetString(reader, "Barcode"),
                                Name = GetString(reader, "Name"),
                                CategoryId = GetInt(reader, "CategoryId"),
                                Price = GetDecimal(reader, "Price"),
                                Cost = GetDecimal(reader, "Cost"),
                                StockQty = GetInt(reader, "StockQty"),
                                ReorderLevel = GetInt(reader, "ReorderLevel"),
                                Image = reader["Image"] == DBNull.Value
                                    ? null
                                    : (byte[])reader["Image"],
                                IsActive = GetBool(reader, "IsActive")
                            });
                        }
                    }
                }
            }

            return products;
        }

        private static int GetInt(SqlDataReader reader, string column)
        {
            return reader[column] == DBNull.Value
                ? 0
                : Convert.ToInt32(reader[column]);
        }

        private static decimal GetDecimal(
            SqlDataReader reader, string column)
        {
            return reader[column] == DBNull.Value
                ? 0m
                : Convert.ToDecimal(reader[column]);
        }

        private static string GetString(
            SqlDataReader reader, string column)
        {
            return reader[column] == DBNull.Value
                ? null
                : Convert.ToString(reader[column]);
        }

        private static bool GetBool(
            SqlDataReader reader, string column)
        {
            return reader[column] != DBNull.Value
                && Convert.ToBoolean(reader[column]);
        }

        public Dictionary<string, int> GetInventoryMetrics()
        {
            var metrics = new Dictionary<string, int>();

            using (SqlConnection conn = Db.GetConnection())
            {
                string query = @"
            SELECT
                COUNT(*) AS TotalProducts,
                SUM(CASE
                    WHEN StockQty <= ReorderLevel THEN 1
                    ELSE 0
                END) AS LowStockItems,
                COALESCE(SUM(StockQty), 0) AS TotalStockUnits,
                SUM(CASE
                    WHEN IsActive = 1 THEN 1
                    ELSE 0
                END) AS ActiveProducts
            FROM dbo.Products;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            metrics["TotalProducts"] =
                                Convert.ToInt32(reader["TotalProducts"]);

                            metrics["LowStockItems"] =
                                Convert.ToInt32(reader["LowStockItems"]);

                            metrics["TotalStockUnits"] =
                                Convert.ToInt32(reader["TotalStockUnits"]);

                            metrics["ActiveProducts"] =
                                Convert.ToInt32(reader["ActiveProducts"]);
                        }
                    }
                }
            }

            return metrics;
        }

        // INSERT PRODUCT
        public int Insert(Product product)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                string query = @"
            INSERT INTO dbo.Products
            (
                Sku,
                Barcode,
                Name,
                CategoryId,
                Price,
                Cost,
                StockQty,
                ReorderLevel,
                IsActive
            )
            VALUES
            (
                @Sku,
                @Barcode,
                @Name,
                @CategoryId,
                @Price,
                @Cost,
                @StockQty,
                @ReorderLevel,
                @IsActive
            );

            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Sku", product.Sku);
                    cmd.Parameters.AddWithValue(
                        "@Barcode",
                        string.IsNullOrWhiteSpace(product.Barcode)
                            ? (object)DBNull.Value
                            : product.Barcode);

                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Cost", product.Cost);
                    cmd.Parameters.AddWithValue("@StockQty", product.StockQty);
                    cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
                    cmd.Parameters.AddWithValue("@IsActive", true);

                    conn.Open();

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void Delete(int productId)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                string query = @"
            DELETE FROM dbo.Products
            WHERE ProductId = @ProductId;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // UPDATE PRODUCT
        public void Update(Product product)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                string query = @"
                    UPDATE dbo.Products
                    SET
                        Sku = @Sku,
                        Barcode = @Barcode,
                        Name = @Name,
                        CategoryId = @CategoryId,
                        Price = @Price,
                        Cost = @Cost,
                        StockQty = @StockQty,
                        ReorderLevel = @ReorderLevel
                    WHERE ProductId = @ProductId;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                    cmd.Parameters.AddWithValue("@Sku", product.Sku);

                    cmd.Parameters.AddWithValue(
                        "@Barcode",
                        string.IsNullOrWhiteSpace(product.Barcode)
                            ? (object)DBNull.Value
                            : product.Barcode);

                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Cost", product.Cost);
                    cmd.Parameters.AddWithValue("@StockQty", product.StockQty);
                    cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}