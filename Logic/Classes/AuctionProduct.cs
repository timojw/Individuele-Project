using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class AuctionProduct:Product
    {
        public AuctionProduct(string _userID, string _name, int _available)
        {
           this.productID = generateProductID("auc");
           this.userID = _userID;
           this.name = _name;
           this.available = _available;
        }
    }
}
