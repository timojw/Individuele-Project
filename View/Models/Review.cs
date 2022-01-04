using System;
using System.Collections.Generic;
using System.Text;

namespace View.Models
{
    class Review
    {
        public int reviewID { get; set; }
        public int reviewerID { get; set; }
        protected string text { get; set; }
        protected string stars { get; set; }

    }
}
