using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;

namespace DAL.Managers
{
    public class ReviewDAO : DatabaseManager, IReviewDAO
    {
        public List<ProductReviewDTO> GetAllProductReviews()
        {
            List<ProductReviewDTO> productReviews = new List<ProductReviewDTO>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from ProductReview", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductReviewDTO productReview = new ProductReviewDTO();

                        productReview.ID = reader.GetInt32(0);
                        productReview.ReviewerID = reader.GetInt32(1);
                        productReview.ProductID = reader.GetInt32(2);
                        productReview.Text = reader.GetString(3);
                        productReview.Stars = reader.GetInt32(4);

                        productReviews.Add(productReview);
                    }
                }
            }
            return productReviews;
        }
        public List<UserReviewDTO> GetAllUserReviews()
        {
            List<UserReviewDTO> userReviews = new List<UserReviewDTO>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from UserReview", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        UserReviewDTO userReview = new UserReviewDTO();

                        userReview.ID = reader.GetInt32(0);
                        userReview.ReviewerID = reader.GetInt32(1);
                        userReview.ReviewedID = reader.GetInt32(2);
                        userReview.Text = reader.GetString(3);
                        userReview.Stars = reader.GetInt32(4);

                        userReviews.Add(userReview);
                    }
                }
            }
            return userReviews;
        }

        public List<ReviewDTO> GetAllReviews()
        {
            List<ReviewDTO> allReviews = new List<ReviewDTO>();
            foreach (var productreview in GetAllProductReviews())
            {
                allReviews.Add(productreview);
            }
            foreach (var userreview in GetAllUserReviews())
            {
                allReviews.Add(userreview);
            }
            return allReviews;
        }

        public List<ProductReviewDTO> GetReviewByProduct(int id)
        {
            List<ProductReviewDTO> reviews = new();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand query = new SqlCommand("SELECT * FROM ProductReview WHERE [productID] = @id", conn))
            {
                query.Parameters.AddWithValue("@id", id);
                query.Connection.Open();

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductReviewDTO review = new ProductReviewDTO();

                        review.ID = Convert.ToInt32(reader["ID"]);
                        review.ReviewerID = Convert.ToInt32(reader["reviewerID"]);
                        review.ProductID = Convert.ToInt32(reader["productID"]);
                        review.Text = reader["text"].ToString();
                        review.Stars = Convert.ToInt32(reader["stars"]);

                        reviews.Add(review);
                    }
                    
                }
            }
            return reviews;
        }

        int IReviewDAO.AddReview(ProductReviewDTO ProductReviewDTO)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using SqlCommand query = new SqlCommand("INSERT INTO [dbo].[ProductReview] ([reviewerID], [productID], [text], [stars]) VALUES (@reviewerID, @productID, @text, @stars" + "SELECT CAST(scope_identity() AS int)", conn);
                conn.Open();

                query.Parameters.AddWithValue("@reviewerID", ProductReviewDTO.ReviewerID);
                query.Parameters.AddWithValue("@productID", ProductReviewDTO.ProductID);
                query.Parameters.AddWithValue("@text", ProductReviewDTO.Text);
                query.Parameters.AddWithValue("@stars", ProductReviewDTO.Stars);


                var modified = query.ExecuteScalar();
                ProductReviewDTO.ID = (int)modified;
                return ProductReviewDTO.ID;
            }
        }

        int IReviewDAO.AddReview(UserReviewDTO userReviewDTO)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using SqlCommand query = new SqlCommand("INSERT INTO [dbo].[UserReview] ([reviewerID], [reviewedID], [text], [stars]) VALUES (@reviewerID, @reviewedID, @text, @stars" + "SELECT CAST(scope_identity() AS int)", conn);
                conn.Open();

                query.Parameters.AddWithValue("@reviewerID", userReviewDTO.ReviewerID);
                query.Parameters.AddWithValue("@reviewedID", userReviewDTO.ReviewedID);
                query.Parameters.AddWithValue("@text", userReviewDTO.Text);
                query.Parameters.AddWithValue("@stars", userReviewDTO.Stars);


                var modified = query.ExecuteScalar();
                userReviewDTO.ID = (int)modified;
                return userReviewDTO.ID;
            }
        }

        public void DeleteReview(UserReviewDTO userReview)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                SqlCommand query = new SqlCommand("DELETE FROM [dbo].[UserReview] WHERE [ID] == @id", conn);
                query.Parameters.AddWithValue("@id", userReview.ID);
                conn.Open();
                query.ExecuteNonQuery();
            }
        }

        public void DeleteReview(ProductReviewDTO productReview)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                SqlCommand query = new SqlCommand("DELETE FROM [dbo].[ProductReview] WHERE [ID] == @id", conn);
                query.Parameters.AddWithValue("@id", productReview.ID);
                conn.Open();
                query.ExecuteNonQuery();
            }
        }


    }
}
