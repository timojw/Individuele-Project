using System;
using System.Collections.Generic;
using System.Text;
using Logic.Classes;

namespace Logic
{
    public class AuctionProduct:Product
    {
        public decimal MinimumPrice { get; set; }
        public List<Bid> Bids { get; set; }
        public DateTime Deadline { get; set; }
        public AuctionProduct(int _userID, string _name, decimal _minimumPrice, List<Bid> _bids, DateTime _deadline, int _available)
        {
           this.UserID = _userID;
           this.Name = _name;
           this.MinimumPrice = _minimumPrice;
           this.Bids = _bids;
           this.Deadline = _deadline;
           this.Available = _available;
        }
    }
}
