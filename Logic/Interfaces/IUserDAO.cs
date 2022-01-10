using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IUserDAO
    {
        List<UserDTO> GetAllUsers();
        int AddUser(UserDTO userDTO);
        UserDTO GetUserByID(int id);
    }
}