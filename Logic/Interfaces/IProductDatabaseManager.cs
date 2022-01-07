using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IProductDatabaseManager
    {
        List<ProductDTO> GetAllProducts();
        void AddProduct(ProductDTO productDTO);
    }
}