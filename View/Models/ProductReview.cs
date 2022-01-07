using System;
using System.Collections.Generic;
using System.Text;

namespace View.Models
{
    class ProductReview:Review
    {
        private string returnmessage;
        public int ProductID { get; set; }

        public ProductReview(int _reviewerID, int _productID, string _text, string _stars)
        {
            this.ReviewerID = _reviewerID;
            this.ProductID = _productID;
            this.Text = _text;
            this.Stars = _stars;
        }
    }
}
