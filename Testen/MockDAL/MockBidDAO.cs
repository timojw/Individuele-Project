using System;
using System.Collections.Generic;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;

namespace Testen
{
    public class MockBidDAO : IBidDAO
    {
        public void AddBid(BidDTO bidDTO)
        {
            throw new NotImplementedException();
        }

        public List<BidDTO> GetAllBids()
        {
            throw new NotImplementedException();
        }
    }
}
