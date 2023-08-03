using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;

namespace ApiProject.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        UserDTO Create (User User);
        UserDTO Update (User User);
        User Get(int Id);
        User GetByEmail(string email);
        bool ExistByEmail(string email);
        List<UserDTO> GetAll();
        void Delete(User User);
        
    }
}