using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;
using ApiProject.Interfaces.IServices;

namespace ApiProject.Implementations.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _rolerepo;

        public RoleService(IRoleRepository rolerepo)
        {
            _rolerepo = rolerepo;
        }

        public BaseResponse<bool> Delete(int id)
        {
            var role = _rolerepo.Get(id);
            if (role == null)
            {
                return new BaseResponse<bool>
                {
                    Message = "Role not found",
                    Suceeded = false
                };
            }
            _rolerepo.Delete(role);
            return new BaseResponse<bool>
            {
                Message = "Role successfully Deleted",
                Suceeded = true,
                Data = true
            };
        }

        public BaseResponse<List<RoleDTO>> GetAll()
        {
            var role = _rolerepo.GetAll();
            if (role == null)
            {
                return new BaseResponse<List<RoleDTO>>
                {
                    Message = "No Patient Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<RoleDTO>>
            {
                Message = "Roles successfully retrieved",
                Suceeded = true,
                Data = role
            };
        }

        public BaseResponse<RoleDTO> Register(CreateRoleModel model)
        {
            var name = _rolerepo.ExistByName(model.RoleName);
            if (name == true)
            {
                return new BaseResponse<RoleDTO>
                {
                    Message = "Role already exists",
                    Suceeded = false,
                };
            }
            var role = new Role
            {
                Description = model.Description,
                RoleName = model.RoleName
            };
            var roles = _rolerepo.Create(role);
            return new BaseResponse<RoleDTO>
            {
                Message = "Role Successfully created",
                Suceeded = true,
                Data = roles
            };
        }

        public BaseResponse<RoleDTO> ReturnById(int id)
        {
             var res = _rolerepo.ExistById(id);
            if(res == false)
            {
                return new BaseResponse<RoleDTO>
                {
                    Message = "Patient doesn't exist",
                    Suceeded = false
                };
            }
            var pat = _rolerepo.ReturnById(id);
            return new BaseResponse<RoleDTO>
            {
                Message = "Patient successfully retrieved",
                Suceeded = true,
                Data = pat               
            }; 
        }

        public BaseResponse<RoleDTO> Update(UpdateRoleModel model, int Id)
        {
            var role = _rolerepo.Get(Id);
            if (role == null)
            {
                return new BaseResponse<RoleDTO>
                {
                    Message = "Role does not exist",
                    Suceeded = false,
                };
            }
            role.Description =  model.Description ?? role.Description;
            role.RoleName =  model.RoleName ?? role.RoleName;
            _rolerepo.Update(role);
            return new BaseResponse<RoleDTO>
            {
                Message = "Successfully created",
                Suceeded = true,
                Data = new RoleDTO
                {
                    Description = role.Description,
                    RoleName = role.RoleName
                }
            };
        }
    }
}