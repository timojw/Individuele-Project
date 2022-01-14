﻿using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IProductDAO
    {
        List<ProductDTO> GetAllProducts();
        int AddProduct(ProductDTO productDTO);
        ProductDTO GetProductByID(int ID);
        List<ProductDTO> GetProductsByUser(int ID);
    }
}