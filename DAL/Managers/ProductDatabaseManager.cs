using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace DAL.Managers
{
    class ProductDatabaseManager : DatabaseManager
    {
        public List<ProductDTO> GetAllProducts()
        {
            List<ProductDTO> products = new List<ProductDTO>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from Product", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductDTO product = new ProductDTO();

                        product.ID = reader.GetInt32(0);
                        product.Name = reader.GetString(1);
                        product.Description = reader.GetString(2);
                        product.UserID = reader.GetInt32(3);
                        product.Status = reader.GetInt32(4);
                        product.OrderID = reader.GetInt32(5);
                        product.ProductType = reader.GetInt32(6);
                        product.Price = reader.GetDecimal(7);
                        product.MinimumPrice = reader.GetDecimal(8);
                        product.HighestBid = reader.GetDecimal(9);
                        product.Deadline = reader.GetDateTime(10);
                        product.Available = reader.GetInt32(11);
            
                        products.Add(product);
                    }
                }
            }
            return products;
        }
    }
}
