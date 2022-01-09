using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IWishlistDAO
    {
        List<WishlistDTO> GetAllWishlists();
    }
}