using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class UserReview:Review
    {
        private string returnmessage;
        public string reviewedUserID { get; set; }

        public UserReview(string tempReviewer, string tempReviewed, string tempText, string tempStars)
        {
            this.reviewID = this.generateReviewID(2);
            this.reviewerID = tempReviewer;
            this.reviewedUserID = tempReviewed;
            this.returnmessage = this.changeText(tempText);
            this.returnmessage = this.changeStars(tempStars);
        }
    }
}
