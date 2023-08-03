using System.Collections.Generic;
using ApiProject.Dtos;

namespace ApiProject.Interfaces.IServices
{
    public interface IRoleService
    {
        BaseResponse<RoleDTO> Register (CreateRoleModel model);
        BaseResponse<RoleDTO> Update (UpdateRoleModel model, int Id);
        BaseResponse<bool> Delete (int id);
        BaseResponse<RoleDTO> ReturnById(int id);
        BaseResponse<List<RoleDTO>> GetAll(); 
    }
}