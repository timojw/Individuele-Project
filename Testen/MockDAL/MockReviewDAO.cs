using System;
using System.Collections.Generic;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;

namespace Testen
{
    public class MockReviewDAO : IReviewDAO
    {
        public int AddReview(ProductReviewDTO productReviewDTO)
        {
            throw new NotImplementedException();
        }

        public int AddReview(UserReviewDTO userReviewDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(UserReviewDTO userReview)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(ProductReviewDTO productReview)
        {
            throw new NotImplementedException();
        }

        public List<ProductReviewDTO> GetAllProductReviews()
        {
            throw new NotImplementedException();
        }

        public List<ReviewDTO> GetAllReviews()
        {
            throw new NotImplementedException();
        }

        public List<UserReviewDTO> GetAllUserReviews()
        {
            throw new NotImplementedException();
        }

        public List<ProductReviewDTO> GetReviewByProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
