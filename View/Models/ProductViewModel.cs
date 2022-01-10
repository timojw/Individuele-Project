using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Logic;
using Logic.Classes;

namespace View.Models
{
    public class ProductViewModel
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Available { get; set; }
        public decimal Price { get; set; }
        public decimal MinimumPrice { get; set; }
        public List<Bid> Bids { get; set; }
        public List<ProductReview> Reviews { get; set; }
        public DateTime Deadline { get; set; }
    }
}
