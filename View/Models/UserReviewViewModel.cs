using System;
using System.Collections.Generic;
using System.Text;

namespace View.Models
{
    class UserReviewViewModel:ReviewViewModel
    {
        public int ReviewedID { get; set; }

        public UserReviewViewModel(int _reviewerID, int _reviewedID, string _text, string _stars)
        {
            this.ReviewerID = _reviewerID;
            this.ReviewedID = _reviewedID;
            this.Text = _text;
            this.Stars = _stars;
        }

    }
}
