using System;
using System.Collections.Generic;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;

namespace Testen
{
    public class MockProductDAO : IProductDAO
    {
        public string Name { get; set; }
        public int AddProduct(ProductDTO productDTO)
        {
            Name = productDTO.Name;
            return productDTO.ID;
        }

        public List<ProductDTO> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public ProductDTO GetProductByID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> GetProductsByUser(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
