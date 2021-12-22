using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.DTO
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public int Status { get; set; }
        public int OrderID { get; set; }
        public int ProductType { get; set; }
        public decimal Price { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal HighestBid { get; set; }
        public DateTime Deadline { get; set; }
        public int Available { get; set; }
    }
}
