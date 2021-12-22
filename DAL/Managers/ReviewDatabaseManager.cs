using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;

namespace DAL.Managers
{
    public class ReviewDatabaseManager : DatabaseManager, IReviewDatabaseManager
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

    }
}
