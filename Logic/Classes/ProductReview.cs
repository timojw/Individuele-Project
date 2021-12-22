using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class ProductReview:Review
    {
        private string returnmessage;
        public string reviewedProductID { get; set; }

        public ProductReview(string tempReviewer, string tempReviewed, string tempText, string tempStars)
        {
            this.reviewID = this.generateReviewID(1);
            this.reviewerID = tempReviewer;
            this.reviewedProductID = tempReviewed;
            this.returnmessage = this.changeText(tempText);
            this.returnmessage = this.changeStars(tempStars);
        }
    }
}
