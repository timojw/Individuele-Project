using System.Collections.Generic;
using Logic.Interfaces;
using Logic.DTO;
using Logic.Classes;

namespace Logic.Managers
{
    public class ProductManager
    {
        IProductDAO productDAO;
        IReviewDAO reviewDAO;
        IBidDAO BidDAO;
        public ProductManager(IProductDAO iproductDAO, IReviewDAO ireviewDAO, IBidDAO ibidDAO)
        {
            productDAO = iproductDAO;
            reviewDAO = ireviewDAO;
            BidDAO = ibidDAO;
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
                    UserID = product1.UserID,
                    Descripion = product1.Description,
                    Price = product1.Price
                };
                products.Add(product);
            }
            return products;
        }
        public Product GetProduct(int id)
        {
            ProductDTO product1 = productDAO.GetProductByID(id);
            Product product = new Product()
            {
                ID = product1.ID,
                Name = product1.Name,
                Available = product1.Available,
                UserID = product1.UserID,
                Descripion = product1.Description,
                Price= product1.Price
            };            
            return product;
        }
        //public List<Bid> GetAllBids(Product product)
        //{
        //    List<Bid> bids = new List<Bid>();
        //    BidDAO.
        //}
        public List<Product> GetProductsByUser(int id)
        {
            List<Product> products = new List<Product>();
            List<ProductDTO> list = productDAO.GetProductsByUser(id);
            foreach (var product1 in list)
            {
                Product product = new Product()
                {
                    ID = product1.ID,
                    Name = product1.Name,
                    Available = product1.Available,
                    UserID = product1.UserID,
                    Descripion = product1.Description,
                    Price = product1.Price
                };
                products.Add(product);
            }
            return products;
        }
        public List<ProductReview> GetAllReviews(Product product)
        {
            List<ProductReview> reviews = new List<ProductReview>();
            foreach (var review1 in reviewDAO.GetReviewByProduct(product.ID))
            {
                ProductReview review = new ProductReview(review1.ReviewerID, review1.ProductID, review1.Text, review1.Stars) {
                    ID = review1.ID
                    
                };
                reviews.Add(review);
            }
            return reviews;
        }
        public void AddProduct(Product product)
        {
            ProductDTO productDto = new ProductDTO()
            {
                ID = product.ID,
                Name = product.Name,
                Description = product.Descripion,
                UserID = product.UserID,
                Available = product.Available,
                Price = product.Price,
                MinimumPrice = product.MinimumPrice,
                Deadline = product.Deadline            
            };
            productDAO.AddProduct(productDto);
        }
        public void AddReview(ProductReview review)
        {
            ProductReviewDTO reviewDto = new ProductReviewDTO()
            {
                Stars = review.Stars,
                ProductID = review.ProductID,
                ReviewerID = review.ReviewerID,
                Text = review.Text
            };
            reviewDAO.AddReview(reviewDto);
        }
    }
}
