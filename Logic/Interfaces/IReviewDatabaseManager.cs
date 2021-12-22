using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IReviewDatabaseManager
    {
        List<ProductReviewDTO> GetAllProductReviews();
        List<ReviewDTO> GetAllReviews();
        List<UserReviewDTO> GetAllUserReviews();
    }
}