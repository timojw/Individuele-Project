using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class UserReview:Review
    {
        private string returnmessage;
        public string ReviewedID { get; set; }

        public UserReview(string tempReviewer, string tempReviewed, string tempText, string tempStars)
        {
            this.ReviewID = this.generateReviewID(2);
            this.ReviewerID = tempReviewer;
            this.ReviewedID = tempReviewed;
            this.returnmessage = this.changeText(tempText);
            this.returnmessage = this.changeStars(tempStars);
        }
    }
}
