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
                    Descripion = product1.Description
                };
                products.Add(product);
            }
            return products;
        }
        //public List<Bid> GetAllBids(Product product)
        //{
        //    List<Bid> bids = new List<Bid>();
        //    BidDAO.
        //}
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
    }
}
