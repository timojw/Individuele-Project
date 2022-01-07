using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class AuctionProduct:Product
    {
        public decimal MinimumPrice { get; set; }
        public decimal HighestBid { get; set; }
        public DateTime Deadline { get; set; }
        public AuctionProduct(int _ID, int _userID, string _name, int _available)
        {
           this.ID = _ID;
           this.UserID = _userID;
           this.Name = _name;
           this.Available = _available;
        }
    }
}
