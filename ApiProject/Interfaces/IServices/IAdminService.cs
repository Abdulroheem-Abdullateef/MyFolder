using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Interfaces.IRepositories;
using Microsoft.AspNetCore.Http;

namespace ApiProject.Interfaces.IServices
{
    public interface IAdminService 
    {
        BaseResponse<AdminDTO> Register (CreateAdminModel model);
        BaseResponse<AdminDTO> Update (UpdateAdminModel model, int Id);
        BaseResponse<bool> Delete (int id);
        BaseResponse<AdminDTO> GetByEmail(string email);
        BaseResponse<AdminDTO> ReturnById(int id);
        BaseResponse<List<AdminDTO>> GetAll();
    }
}