using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class ProductReview:Review
    {
        private string returnmessage;
        public string ProductID { get; set; }

        public ProductReview(string tempReviewer, string tempReviewed, string tempText, string tempStars)
        {
            this.ReviewID = this.generateReviewID(1);
            this.ReviewerID = tempReviewer;
            this.ProductID = tempReviewed;
            this.returnmessage = this.changeText(tempText);
            this.returnmessage = this.changeStars(tempStars);
        }
    }
}
