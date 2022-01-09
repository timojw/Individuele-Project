using System;
using Logic.Interfaces;

namespace Logic
{
    public class RegularProduct:Product
    {
        public decimal Price { get; set; }

        public RegularProduct(int _userID, string _name, decimal _price, int _available)
        {
           this.UserID = _userID;
           this.Name = _name;
           this.Price = _price;
           this.Available = _available;
        }
    }
}
