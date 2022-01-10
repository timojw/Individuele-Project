﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class UserReview:Review
    {
        public int ReviewedID { get; set; }

        public UserReview(int _reviewerID, int _reviewedID, string _text, int _stars)
        {
            this.ReviewerID = _reviewerID;
            this.ReviewedID = _reviewedID;
            this.Text = _text;
            this.Stars = _stars;
        }
    }
}