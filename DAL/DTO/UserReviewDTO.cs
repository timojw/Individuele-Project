using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class UserReviewDTO : ReviewDTO
    {
        public int ReviewerID { get; set; }
        public int ReviewedID { get; set; }
    }
}
