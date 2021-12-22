using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IWishlistDatabaseManager
    {
        List<WishlistDTO> GetAllWishlists();
    }
}