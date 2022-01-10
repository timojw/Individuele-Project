using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;

namespace DAL.Managers
{
    public class BidDAO : DatabaseManager, IBidDAO
    {

        public List<BidDTO> GetAllBids()
        {
            List<BidDTO> bids = new List<BidDTO>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from Bid", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        BidDTO bid = new BidDTO();

                        bid.ProductID = reader.GetInt32(0);
                        bid.UserID = reader.GetInt32(1);
                        bid.Amount = reader.GetDecimal(2);

                        bids.Add(bid);
                    }
                }
            }
            return bids;
        }
        void IBidDAO.AddBid(BidDTO BidDTO)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using SqlCommand query = new SqlCommand("INSERT INTO [dbo].[Bid] ([productID], [userID], [amount]) VALUES (@productID, @userID, @amount" + "SELECT CAST(scope_identity() AS int)", conn);
                conn.Open();

                query.Parameters.AddWithValue("@productID", BidDTO.ProductID);
                query.Parameters.AddWithValue("@userID", BidDTO.UserID);
                query.Parameters.AddWithValue("@amount", BidDTO.Amount);


                var modified = query.ExecuteScalar();
            }
        }
    }
}
