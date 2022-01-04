using System;
using Logic.Interfaces;

namespace Logic
{
    public class RegularProduct:Product
    {
        private IProductDatabaseManager productDatabaseManager;
        public double Price { get; set; }

        public RegularProduct(int _userID, string _name, int _available, IProductDatabaseManager _productDatabaseManager)
        {
           this.productID = generateProductID();
           this.userID = _userID;
           this.name = _name;
           this.available = _available;
           this.productDatabaseManager = _productDatabaseManager;
        }

        public void Deez()
        {
            productDatabaseManager.GetAllProducts();
        }
    }
}
