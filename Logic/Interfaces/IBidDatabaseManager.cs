using System.Collections.Generic;
using Logic.DTO;

namespace Logic.Interfaces
{
    public interface IBidDatabaseManager
    {
        List<BidDTO> GetAllBids();
        void AddBid(BidDTO bidDTO);
    }
}