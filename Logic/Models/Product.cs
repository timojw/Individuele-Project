using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Logic.Classes
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Available { get; set; }
        public string Descripion { get; set; }
        public decimal Price { get; set; }
        public decimal MinimumPrice { get; set; }
        public List<Bid> Bids { get; set; }
        public DateTime Deadline { get; set; }
    }
}
