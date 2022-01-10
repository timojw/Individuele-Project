using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class ProductReview:Review
    {
        private string returnmessage;
        public int ProductID { get; set; }

        public ProductReview(int _reviewerID, int _productID, string _text, int _stars)
        {
            this.ReviewerID = _reviewerID;
            this.ProductID = _productID;
            this.returnmessage = this.changeText(_text);
            this.returnmessage = this.changeStars(_stars);
        }
    }
}
