using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces;
using ApiProject.Interfaces.IRepositories;
using ApiProject.Interfaces.IServices;

namespace ApiProject.Implementations.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly IHospitalRepository _hospitalrepo;
        private readonly IRoleRepository _rolerepo;
        private readonly IUserRepository _userrepo;
       

        public HospitalService(IHospitalRepository hospitalrepo, IRoleRepository rolerepo, IUserRepository userrepo)
        {
            _hospitalrepo = hospitalrepo;
            _rolerepo = rolerepo;
            _userrepo = userrepo;
            
        }

        public BaseResponse<bool> Delete(int id)
        {
            var hospital = _hospitalrepo.Get(id);
            if (hospital == null)
            {
                return new BaseResponse<bool>
                {
                    Message = "Hospital not found",
                    Suceeded = false,
                    Data = false
                };
            }
            _hospitalrepo.Delete(hospital);
            return new BaseResponse<bool>
            {
                Message = "Hospital successfully Deleted",
                Suceeded = true,
                Data = true
            };
        }

        public BaseResponse<List<HospitalDTO>> GetAll()
        {
            var hospital = _hospitalrepo.GetAll();
            if (hospital == null)
            {
                return new BaseResponse<List<HospitalDTO>>
                {
                    Message = "No Hospital Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<HospitalDTO>>
            {
                Message = "Hospital successfully retrieved",
                Suceeded = true,
                Data = hospital
            };
        }

        public BaseResponse<HospitalDTO> Register(CreateHospitalModel model)
        {
            var res = _hospitalrepo.ExistByMail(model.Hospitalmail);
            if (res == true)
            {
                return new BaseResponse<HospitalDTO>
                {
                    Message = "Hospital already exists",
                    Suceeded = false,
                };
            }
             var user = new User
            {
                Email = model.Hospitalmail,
                FirstName = model.Name,                
                Password = model.Password
            };   
            var roled = _rolerepo.GetRoleByName("Hospital");         
            var userRole = new UserRole
            {
                User = user,
                UserId = user.Id,
                Role = roled,
                RoleId = roled.Id
            };
            user.UserRole.Add(userRole);
            var hospital = new Hospital
            {
                Name = model.Name,
                Hospitalmail = model.Hospitalmail,
                Address = model.Address,
                User =  user,
                UserId = user.Id
            };
            _userrepo.Create(user);
            var hosp = _hospitalrepo.Create(hospital);
            return new BaseResponse<HospitalDTO>
            {
                Message = "Successfully created",
                Suceeded = true,
                Data = hosp
            };
        }

        public BaseResponse<HospitalDTO> ReturnById(int id)
        {
            var hosps = _hospitalrepo.ExistById(id);
            if (hosps == false)
            {
                return new BaseResponse<HospitalDTO>
                {
                    Message = "Doctor doesn't exist",
                    Suceeded = false
                };
            }
            var hosp = _hospitalrepo.ReturnById(id);
            return new BaseResponse<HospitalDTO>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = hosp
            };
        }

        public BaseResponse<HospitalDTO> Update(UpdateHospitalModel model, int Id)
        {
            var hosps = _hospitalrepo.ExistById(Id);
            if (hosps == false)
            {
                return new BaseResponse<HospitalDTO>
                {
                    Message = "Hospital doesn't exist",
                    Suceeded = false
                };
            }
            var hospitalInfo = _hospitalrepo.Get(Id);            
            hospitalInfo.Name =  model.Name ?? hospitalInfo.Name;
            hospitalInfo.Address =  model.Address ?? hospitalInfo.Address ;
            var hosp = _hospitalrepo.Update(hospitalInfo);
            return new BaseResponse<HospitalDTO>
            {
                Message = "Hospital successfully updated",
                Suceeded = true,
                Data = new HospitalDTO
                {
                    Name = hosp.Name,
                    Address = hosp.Address
                }
            };
        }
    }
}