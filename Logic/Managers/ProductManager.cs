using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces;
using Logic.DTO;

namespace Logic.Managers
{
    public class ProductManager
    {
        IProductDAO productDAO;
        public ProductManager(IProductDAO iproductDAO)
        {
            productDAO = iproductDAO;
        }
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            List<ProductDTO> list = productDAO.GetAllProducts();
            foreach (var product1 in list)
            {
                Product product = new Product()
                {
                    ID = product1.ID,
                    Name = product1.Name,
                    Available = product1.Available,
                    UserID = product1.UserID
                };
                products.Add(product);
            }
            return products;
        }
    }
}
