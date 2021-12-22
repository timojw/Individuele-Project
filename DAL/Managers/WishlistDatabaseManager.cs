using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;

namespace DAL.Managers
{
    public class WishlistDatabaseManager : DatabaseManager, IWishlistDatabaseManager
    {
        public List<WishlistDTO> GetAllWishlists()
        {
            List<WishlistDTO> wishlists = new List<WishlistDTO>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from Wishlist", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        WishlistDTO wishlist = new WishlistDTO();

                        wishlist.ID = reader.GetInt32(0);
                        wishlist.UserID = reader.GetInt32(1);
                        wishlist.ProductID = reader.GetInt32(2);

                        wishlists.Add(wishlist);
                    }
                }
            }
            return wishlists;
        }
    }
}
