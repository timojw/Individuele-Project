using System;

namespace Logic
{
    public class RegularProduct:Product
    {
        public double Price { get; set; }

        public RegularProduct(string _userID, string _name, int _available)
        {
           this.productID = generateProductID("reg");
           this.userID = _userID;
           this.name = _name;
           this.available = _available;
        }
    }
}
