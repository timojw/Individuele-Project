using System;
using System.Collections.Generic;
using System.Text;

namespace View.Models
{
    class UserReview:Review
    {
        public int ReviewedID { get; set; }

        public UserReview(int _ID, int _reviewerID, int _reviewedID, string _text, string _stars)
        {
            this.ID = _ID;
            this.ReviewerID = _reviewerID;
            this.ReviewedID = _reviewedID;
            this.Text = _text;
            this.Stars = _stars;
        }

    }
}
