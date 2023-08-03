using System;
using System.Collections.Generic;
using System.Linq;
using ApiProject.Dtos;
using ApiProject.Interfaces.IRepositories;
using ApiProject.Interfaces.IServices;

namespace ApiProject.Implementations.Services
{
    
    public class UserService : IUserService
    {
        private readonly IUserRepository _userrepo;

        public UserService(IUserRepository userrepo)
        {
            _userrepo = userrepo;
        }

        public BaseResponse<bool> Delete(int id)
        {
             var user = _userrepo.Get(id);
            if (user == null)
            {
                return new BaseResponse<bool>
                {
                    Message = "User not found",
                    Suceeded = false
                };
            }
            _userrepo.Delete(user);
            return new BaseResponse<bool>
            {
                Message = "User successfully Deleted",
                Suceeded = true,
                Data = true
            };
        }

        public BaseResponse<UserDTO> Get(int Id)
        {
            var use = _userrepo.Get(Id);
            if(use == null)
            {
                return new BaseResponse<UserDTO>
                {
                    Message = "User not found",
                    Suceeded = false,
                };
            }
            return new BaseResponse<UserDTO>
            {
                Message = " User found",
                Suceeded = true,
                Data = new UserDTO
                {
                    Email = use.Email,
                    FirstName = use.FirstName,
                    LastName = use.LastName
                }
            };
        }

        public BaseResponse<List<UserDTO>> GetAll()
        {
            var pat = _userrepo.GetAll();
            if(pat ==null)
            {
                return new BaseResponse<List<UserDTO>>
                {
                    Message = "No Patient Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<UserDTO>>
            {
                Message = "Patient successfully retrieved",
                Suceeded = true,
                Data = pat
            };
        }

        public BaseResponse<UserDTO> LogIn(UserLogInModel model)
        {
           var use = _userrepo.GetByEmail(model.Email);
           if(use == null || use.Password != model.Password)
           {
               return new BaseResponse<UserDTO>
               {
                   Message = "Email or password not found",
                   Suceeded = false                   
               };
           }
           return new BaseResponse<UserDTO>
           {
               Message = "User Successfully Logged In",
               Suceeded = true,
               Data = new UserDTO
               {
                    Id = use.Id,
                    Email = use.Email,
                    FirstName = use.FirstName,
                    LastName = use.LastName,
                    Roles = use.UserRole.Select(a => new RoleDTO
                    {
                        RoleName = a.Role.RoleName
                    }).ToList()
               }
           };
        }
    }
}