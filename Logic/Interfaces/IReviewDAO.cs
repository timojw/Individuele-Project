using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IReviewDAO
    {
        List<ProductReviewDTO> GetAllProductReviews();
        List<ReviewDTO> GetAllReviews();
        List<UserReviewDTO> GetAllUserReviews();
        List<ProductReviewDTO> GetReviewByProduct(int id);
        int AddReview(ProductReviewDTO productReviewDTO);
        int AddReview(UserReviewDTO userReviewDTO);
        void DeleteReview(UserReviewDTO userReview);
        void DeleteReview(ProductReviewDTO productReview);

    }
}