using System;
using Logic.Interfaces;

namespace Logic
{
    public class RegularProduct:Product
    {
        public double Price { get; set; }

        public RegularProduct(int _userID, string _name, int _available)
        {
           this.productID = generateProductID();
           this.userID = _userID;
           this.name = _name;
           this.available = _available;
        }
    }
}
