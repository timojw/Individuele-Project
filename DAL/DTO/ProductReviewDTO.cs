using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class ProductReviewDTO : ReviewDTO
    {
        public int ReviewerID { get; set; }
        public int ProductID { get; set; }

    }
}
