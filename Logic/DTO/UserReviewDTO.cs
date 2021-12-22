using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.DTO
{
    public class UserReviewDTO : ReviewDTO
    {
        public int ReviewerID { get; set; }
        public int ReviewedID { get; set; }
    }
}
