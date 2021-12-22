using System;
using Logic.Interfaces;

namespace Logic
{
    public class RegularProduct:Product
    {
        private IProductDatabaseManager productDatabaseManager;
        public double Price { get; set; }

        public RegularProduct(string _userID, string _name, int _available, IProductDatabaseManager _productDatabaseManager)
        {
           this.productID = generateProductID("reg");
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
