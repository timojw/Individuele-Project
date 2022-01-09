using System.Collections.Generic;
using Logic.DTO;

namespace Logic.Interfaces
{
    public interface IBidDAO
    {
        List<BidDTO> GetAllBids();
        void AddBid(BidDTO bidDTO);
    }
}