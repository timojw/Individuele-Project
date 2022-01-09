﻿using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IReviewDAO
    {
        List<ProductReviewDTO> GetAllProductReviews();
        List<ReviewDTO> GetAllReviews();
        List<UserReviewDTO> GetAllUserReviews();
        int AddReview(ProductReviewDTO productReviewDTO);
        int AddReview(UserReviewDTO userReviewDTO);
        void DeleteReview(UserReviewDTO userReview);
        void DeleteReview(ProductReviewDTO productReview);
    }
}