using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;


namespace DAL.Managers
{
    public class ProductDAO : DatabaseManager, IProductDAO
    {
        public ProductDAO()
        {

        }


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
                        //product.Deadline = reader.GetDateTime(9);
                        //product.Available = reader.GetInt32(10);

                        products.Add(product);
                    }
                }
            }
            return products;
        }
        public ProductDTO
            GetProduct(int id)
        {
            ProductDTO product = new();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand query = new SqlCommand("SELECT * FROM User WHERE [ID] = @id", conn))
            {
                query.Parameters.AddWithValue("@id", id);
                query.Connection.Open();

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        product.ID = Convert.ToInt32(reader["ID"]);
                        product.Name = reader["name"].ToString();
                        product.Available = Convert.ToInt32(reader["available"]);
                        product.Description = reader["description"].ToString();
                        product.Price = Convert.ToDecimal(reader["regularproduct_price"]);
                        product.MinimumPrice = Convert.ToDecimal(reader["biddingproduct_minimumPrice"]);
                        //product. = Convert.ToDecimal(reader["biddingproduct_highestBid"]);
                        product.Deadline = (DateTime)reader["biddingproduct_deadline"];
                    }
                }
            }
            return product;
        }
        public int AddProduct(ProductDTO ProductDTO)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using SqlCommand query = new SqlCommand("INSERT INTO [dbo].[Product] ([name], [description], [userID], [status], [orderID], [productType], [regularproduct_price], [biddingproduct_minimumPrice], [biddingproduct_deadline], [available]) VALUES (@name, @description, @userID, @status, @orderID, @productType, @regularproduct_price, @biddingproduct_minimumPrice, @biddingproduct_deadline, @available)" + "SELECT CAST(scope_identity() AS int)", conn);
                conn.Open();

                query.Parameters.AddWithValue("@name", ProductDTO.Name);
                query.Parameters.AddWithValue("@description", ProductDTO.Description);
                query.Parameters.AddWithValue("@userID", ProductDTO.UserID);
                query.Parameters.AddWithValue("@status", ProductDTO.Status);
                query.Parameters.AddWithValue("@orderID", ProductDTO.OrderID);
                query.Parameters.AddWithValue("@productType", ProductDTO.ProductType);
                query.Parameters.AddWithValue("@regularproduct_price", ProductDTO.Price);
                query.Parameters.AddWithValue("@biddingproduct_minimumPrice", ProductDTO.MinimumPrice);
                query.Parameters.AddWithValue("@biddingproduct_deadline", ProductDTO.Deadline);
                query.Parameters.AddWithValue("@available", ProductDTO.Available);

                var modified = query.ExecuteScalar();
                ProductDTO.ID = (int)modified;
                return ProductDTO.ID;
            }
        }
        public void DeleteProduct(ProductDTO product)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                SqlCommand query = new SqlCommand("DELETE FROM [dbo].[Product] WHERE [ID] = @id", conn);
                query.Parameters.AddWithValue("@id", product.ID);
                conn.Open();
                query.ExecuteNonQuery();
            }
        }
    }

}
