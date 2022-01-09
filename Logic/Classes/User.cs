using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Logic.Classes;
using Logic.Interfaces;
using Logic.DTO;

namespace Logic
{
    class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }

        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string PostalCode { get; set; }

        public List<Product> Producten { get; set; }
        public List<Review> Reviews { get; set; }
        public Wishlist Wishlist { get; set; }

        private IProductDAO productDatabaseManager;
        private IReviewDAO reviewDatabaseManager;
        private IBidDAO bidDatabaseManager;
        public User(string _name, string _email, string _password, IProductDAO _productDatabaseManager, IReviewDAO _reviewDatabaseManager, IBidDAO _bidDatabaseManager)
        {
            //test 2
            this.Name = _name;
            this.Email = _email;
            this.Password = _password;
            this.RegisterDate = DateTime.Now;
            this.Producten = new List<Product>();
            this.Reviews = new List<Review>();
            this.Wishlist = new Wishlist();
            productDatabaseManager = _productDatabaseManager;
            reviewDatabaseManager = _reviewDatabaseManager;
            bidDatabaseManager = _bidDatabaseManager;
        }

        public void AddAdress(string _country, string _state, string _city, string _street, int _housenumber, string _postalCode)
        {
            this.Country = _country;
            this.State = _state;
            this.City = _city;
            this.Street = _street;
            this.HouseNumber = _housenumber;
            this.PostalCode = _postalCode;
        }

        public Product AddRegularProduct(string _name, string _description, decimal _price, int _available)
        {
            int ID = productDatabaseManager.AddProduct(new DTO.ProductDTO()
            {
                Name = _name,
                Description = _description,
                UserID = this.ID,
                Price = _price,
                //OrderID
                Available = _available,

            }) ;
            RegularProduct product = new RegularProduct(this.ID, _name, _price, _available);
            product.ID = ID;
            Producten.Add(product);
            return product;
        }

        public Product AddAuctionProduct(string _name, string _description, decimal _minimumPrice, List<Bid> _bids, DateTime _deadline, int _available)
        {
            int ID = productDatabaseManager.AddProduct(new DTO.ProductDTO()
            {
                Name = _name,
                Description = _description,
                UserID = this.ID,
                MinimumPrice = _minimumPrice,
                Bids = _bids,
                Deadline = _deadline,
                //OrderID
                Available = _available

            }) ;
            AuctionProduct product = new AuctionProduct(this.ID, _name, _minimumPrice, _bids, _deadline, _available);
            product.ID = ID;
            Producten.Add(product);

            return product;
        }

        public ProductReview AddProductReview(int _productID, string _text, int _stars)
        {
            int ID = reviewDatabaseManager.AddReview(new DTO.ProductReviewDTO()
            {
                ReviewerID = this.ID,
                ProductID = _productID,
                Text = _text,
                Stars = _stars

            }) ;
            ProductReview review = new ProductReview(this.ID, _productID, _text, _stars);
            Reviews.Add(review);
            return review;
        }

        public UserReview AddUserReview(int _userID, string _text, int _stars)
        {
            int ID = reviewDatabaseManager.AddReview(new DTO.UserReviewDTO()
            {
                ReviewerID = this.ID,
                ReviewedID = _userID,
                Text = _text,
                Stars = _stars

            });
            UserReview review = new UserReview(this.ID, _userID, _text, _stars);
            Reviews.Add(review);
            return review;
        }

        public void DeleteProductReview(int _ID)
        {
            ProductReviewDTO productReviewDTO = new ProductReviewDTO
            {
                ID = _ID
            };
            reviewDatabaseManager.DeleteReview(productReviewDTO);
        }

        public void DeleteUserReview(int _ID)
        {
            UserReviewDTO userReviewDTO = new UserReviewDTO
            {
                ID = _ID
            };
            reviewDatabaseManager.DeleteReview(userReviewDTO);
        }

        public void PlaceBid(int _productID, decimal _amount)
        {
            bidDatabaseManager.AddBid(new BidDTO()
            {
                UserID = this.ID,
                ProductID = _productID,
                Amount = _amount

            }) ;
        }
    }
}
