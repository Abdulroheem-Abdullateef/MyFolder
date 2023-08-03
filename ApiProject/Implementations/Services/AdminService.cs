using System;
using System.Collections.Generic;
using System.IO;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;
using ApiProject.Interfaces.IServices;
using Microsoft.AspNetCore.Hosting;
using ApiProject.Implementations.Repositories;
using Microsoft.AspNetCore.Http;

namespace ApiProject.Implementations.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminrepo;
        private readonly IUserRepository _userrepo;
        private readonly IRoleRepository _rolerepo;
        private readonly IWebHostEnvironment _webroot;

        public AdminService(IAdminRepository adminrepo, IUserRepository userrepo, IRoleRepository rolerepo, IWebHostEnvironment webroot)
        {
            _adminrepo = adminrepo;
            _userrepo = userrepo;
            _rolerepo = rolerepo;
            _webroot = webroot;
        }

        public BaseResponse<bool> Delete(int id)
        {
            var admin = _adminrepo.Get(id);
            if (admin == null)
            {
                return new BaseResponse<bool>
                {
                    Message = "Admin not found",
                    Suceeded = false,
                    Data = false

                };
            }
            _adminrepo.Delete(admin);
            return new BaseResponse<bool>
            {
                Message = "Admin successfully Deleted",
                Suceeded = true,
                Data = true
            };
        }

        public BaseResponse<List<AdminDTO>> GetAll()
        {
            var admins = _adminrepo.GetAll();
            if (admins == null)
            {
                return new BaseResponse<List<AdminDTO>>
                {
                    Message = "No admin Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<AdminDTO>>
            {
                Message = "Admin successfully retrieved",
                Suceeded = true,
                Data = admins
            };
        }

        public BaseResponse<AdminDTO> GetByEmail(string email)
        {
            var res = _adminrepo.ExistByEmail(email);
            if ( res == false)
            {
                return new BaseResponse<AdminDTO>
                {
                    Message = "Admin not exist",
                    Suceeded = false
                };
            }
            var model = _adminrepo.GetByEmail(email);
            return new BaseResponse<AdminDTO>
            {
                Message = "Admin exist",
                Suceeded = true,
                Data = new AdminDTO
                {
                    Address = model.Address,
                    DateOfBirth = model.DateOfBirth,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    Gender = model.Gender,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                }
            };
        }

        public BaseResponse<AdminDTO> Register(CreateAdminModel model)
        {
            var name = _adminrepo.ExistByEmail(model.Email);
             if(name == true) 
            {
                return new BaseResponse<AdminDTO>
                {
                    Message = "Admin already exists",
                    Suceeded = false,
                };
            }           
            var user = new User
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Password = model.Password
            };            
            var roled = _rolerepo.GetRoleByName("Admin");
            var userRole = new UserRole
            {
                User = user,
                UserId = user.Id,
                Role = roled,
                RoleId = roled.Id
            };
            user.UserRole.Add(userRole);
            var admin = new Admin
            {
                Address = model.Address,
                DateOfBirth = model.DateOfBirth,
                Email = model.Email,
                FirstName = model.FirstName,
                Gender = model.Gender,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                AdminPhoto = model.AdminPhoto,
                User = user,
                UserId = user.Id,
            };
            _userrepo.Create(user);
            var admins = _adminrepo.Create(admin);
            return new BaseResponse<AdminDTO>
            {
                Message = "Successfully created",
                Suceeded = true,
                Data = admins
            };
        }

        public BaseResponse<AdminDTO> ReturnById(int id)
        {
            var res = _adminrepo.ExistById(id);
            if (res == false)
            {
                return new BaseResponse<AdminDTO>
                {
                    Message = "Admin doesn't exist",
                    Suceeded = false
                };
            }
            var admin = _adminrepo.ReturnById(id);
            return new BaseResponse<AdminDTO>
            {
                Message = "Admin successfully retrieved",
                Suceeded = true,
                Data = admin
            };
        }

        public BaseResponse<AdminDTO> Update(UpdateAdminModel model, int Id)
        {
            var res = _adminrepo.ExistById(Id);
            if ( res == false)
            {
                return new BaseResponse<AdminDTO>
                {
                    Message = "Admin doesn't exist",
                    Suceeded = false
                };
            }
            var adminInfo = _adminrepo.Get(Id);
            var user = _userrepo.Get(adminInfo.UserId);
            adminInfo.FirstName =  model.FirstName ?? adminInfo.FirstName;
            adminInfo.LastName = model.LastName ?? adminInfo.LastName;
            adminInfo.PhoneNumber = model.PhoneNumber ?? adminInfo.PhoneNumber;
            user.Password = user.Password ?? user.Password;
            var admin = _adminrepo.Update(adminInfo);
            _userrepo.Update(user);
            return new BaseResponse<AdminDTO>
            {
                Message = "Admin successfully updated",
                Suceeded = true,
                Data = new AdminDTO
                {
                    FirstName = admin.FirstName,
                    LastName = admin.LastName,
                    Email = admin.Email,
                    PhoneNumber = admin.PhoneNumber,
                    Gender = admin.Gender
                }
            };
        }
    }
}