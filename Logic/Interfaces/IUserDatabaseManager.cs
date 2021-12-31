using Logic.DTO;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IUserDatabaseManager
    {
        List<UserDTO> GetAllUsers();
        void AddUser(UserDTO userDTO);
    }
}