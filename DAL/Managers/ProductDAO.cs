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
                using (SqlCommand query = new SqlCommand("select * from [dbo].[Product]", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        products.Add(new ProductDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = reader["name"].ToString(),
                            Description = reader["description"].ToString(),
                            UserID = Convert.ToInt32(reader["userID"]),
                            Status = Convert.ToInt32(reader["status"]),
                            OrderID = Convert.ToInt32(reader["orderID"]),
                            ProductType = Convert.ToInt32(reader["productType"]),
                            Price = Convert.ToDecimal(reader["regularproduct_price"]),
                            MinimumPrice = Convert.ToDecimal(reader["biddingproduct_minimumPrice"]),
                            // = Convert.ToDecimal(reader["biddingproduct_highestBid"]);
                            Deadline = (DateTime)reader["biddingproduct_deadline"],
                            Available = Convert.ToInt32(reader["available"])
                        });
                    }
                }
            }
            return products;
        }
        public List<ProductDTO> GetProductsByUser(int id)
        {
            
            List<ProductDTO> products = new List<ProductDTO>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand query = new SqlCommand("SELECT * FROM [dbo].[Product] WHERE [userID] = @id", conn))       
            {
                
                query.Parameters.AddWithValue("@id", id);
                query.Connection.Open();

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductDTO product = new();
                        
                        product.ID = Convert.ToInt32(reader["ID"]);
                        product.Name = reader["name"].ToString();
                        product.Description = reader["description"].ToString();
                        product.Price = Convert.ToDecimal(reader["regularproduct_price"]);
                        product.UserID = Convert.ToInt32(reader["userID"]);
                        product.Status = Convert.ToInt32(reader["status"]);
                        product.OrderID = Convert.ToInt32(reader["orderID"]);
                        product.ProductType = Convert.ToInt32(reader["productType"]);
                        product.MinimumPrice = Convert.ToDecimal(reader["biddingproduct_minimumPrice"]);
                        //product. = Convert.ToDecimal(reader["biddingproduct_highestBid"]);
                        product.Deadline = (DateTime)reader["biddingproduct_deadline"];
                        product.Available = Convert.ToInt32(reader["available"]);

                        products.Add(product);
                    }
                }
            }
            return products;
        }
        public ProductDTO GetProductByID(int id)
        {
            ProductDTO product = new ProductDTO();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand query = new SqlCommand("SELECT * FROM [dbo].[Product] WHERE [ID] = @id", conn))
            {

                query.Parameters.AddWithValue("@id", id);
                query.Connection.Open();

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        product.ID = Convert.ToInt32(reader["ID"]);
                        product.Name = reader["name"].ToString();
                        product.Description = reader["description"].ToString();
                        product.Price = Convert.ToDecimal(reader["regularproduct_price"]);
                        product.UserID = Convert.ToInt32(reader["userID"]);
                        product.Status = Convert.ToInt32(reader["status"]);
                        product.OrderID = Convert.ToInt32(reader["orderID"]);
                        product.ProductType = Convert.ToInt32(reader["productType"]);
                        product.MinimumPrice = Convert.ToDecimal(reader["biddingproduct_minimumPrice"]);
                        product.Deadline = (DateTime)reader["biddingproduct_deadline"];
                        product.Available = Convert.ToInt32(reader["available"]);
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
