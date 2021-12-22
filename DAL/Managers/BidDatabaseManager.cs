using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL.Managers
{
    class BidDatabaseManager : DatabaseManager
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
    }
}
