using System.Collections.Generic;
using ApiProject.Dtos;

namespace ApiProject.Interfaces.IServices
{
    public interface IUserService
    {
        BaseResponse<UserDTO> LogIn (UserLogInModel model);
        BaseResponse<List<UserDTO>> GetAll();
        BaseResponse<UserDTO> Get(int Id);
        BaseResponse<bool> Delete (int id);
    }
}