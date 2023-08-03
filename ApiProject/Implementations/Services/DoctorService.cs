using System;
using System.Collections.Generic;
using System.IO;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;
using ApiProject.Interfaces.IServices;
using Microsoft.AspNetCore.Hosting;

namespace ApiProject.Implementations.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorrepo;
        private readonly IUserRepository _userrepo;
        private readonly IRoleRepository _rolerepo;
        private readonly IMedicalRecordRepository _medicalrepo;
        private readonly IWebHostEnvironment _webroot;
        public DoctorService(IDoctorRepository doctorrepo, IUserRepository userrepo, IRoleRepository rolerepo, IMedicalRecordRepository medicalrepo, IWebHostEnvironment webroot)
        {
            _doctorrepo = doctorrepo;
            _userrepo = userrepo;
            _rolerepo = rolerepo;
            _medicalrepo = medicalrepo;
            _webroot = webroot;
        }

        public BaseResponse<DoctorDTO> ApproveDoctor(int DoctorId)
        {
            var doctor = _doctorrepo.Get(DoctorId);            
            if (doctor == null)
            {
                return new BaseResponse<DoctorDTO>
                {
                    Message = "This doctor record does not exist",
                    Suceeded = false
                };
            }
            doctor.RegistrationStatus = Enums.RegistrationStatus.Approved;
            _doctorrepo.Update(doctor);
            return new BaseResponse<DoctorDTO>
            {
                Message = "This doctor exists",
                Suceeded = true,
                Data = new DoctorDTO
                {
                    FirstName = doctor.FirstName,
                    LastName = doctor.LastName,
                    Address = doctor.Address,
                    DateOfBirth = doctor.DateOfBirth,
                    Email = doctor.Email,
                    Gender = doctor.Gender,
                    PhoneNumber = doctor.PhoneNumber,
                    AreaOfSpec = doctor.AreaOfSpec,
                    DoctorPhoto = doctor.DoctorPhoto,
                    StaffNumber = doctor.StaffNumber,
                }
            };           
        }

        public BaseResponse<bool> Delete(int id)
        {
            var doctor = _doctorrepo.Get(id);
            if (doctor == null)
            {
                return new BaseResponse<bool>
                {
                    Message = "Doctor not found",
                    Suceeded = false,
                    Data = false
                };
            }
            _doctorrepo.Delete(doctor);
            return new BaseResponse<bool>
            {
                Message = "Doctor successfully Deleted",
                Suceeded = true,
                Data = true
            };
        }

        public BaseResponse<bool> DissaprovedDoctors(int DoctorId)
        {
            var doctor = _doctorrepo.Get(DoctorId);
            if (doctor == null)
            {
                return new BaseResponse<bool>
                {
                    Message = "Doctor does not exists",
                    Suceeded = false,
                    Data = false
                };
            }           
            _doctorrepo.Delete(doctor);           
            return new BaseResponse<bool>
            {
                Message = "Doctor Successfully Dissaproved and Deleted",
                Suceeded = true,
                Data = true
            };
        }

        public BaseResponse<List<DoctorDTO>> GetAllApprovedDoctors()
        {
            var doctors = _doctorrepo.GetAllApprovedDoctors();
            if (doctors == null)
            {
                return new BaseResponse<List<DoctorDTO>>
                {
                    Message = "No Doctor Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<DoctorDTO>>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = doctors
            };
        }
        public BaseResponse<List<DoctorDTO>> GetAllAvailableDoctors()
        {
           var availabledoctors = _doctorrepo.GetAllAvailableDoctors();
           if (availabledoctors == null)
           {
               return new BaseResponse<List<DoctorDTO>>
               {
                   Message = "No doctor is currently available",
                   Suceeded = false
               };
           }
           return new BaseResponse<List<DoctorDTO>>
           {
               Message = "Here are doctors Available",
               Suceeded = true,
               Data = availabledoctors
           };
        }
        public BaseResponse<List<DoctorDTO>> GetAllDentists()
        {
            var doctors = _doctorrepo.GetAllDentists();
            if (doctors == null)
            {
                return new BaseResponse<List<DoctorDTO>>
                {
                    Message = "No Doctor Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<DoctorDTO>>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = doctors
            };
        }
        public BaseResponse<List<DoctorDTO>> GetAllGynaeocologists()
        {
            var doctors = _doctorrepo.GetAllGynaeocologists();
            if (doctors == null)
            {
                return new BaseResponse<List<DoctorDTO>>
                {
                    Message = "No Doctor Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<DoctorDTO>>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = doctors
            };
        }
        public BaseResponse<List<DoctorDTO>> GetAllHaemotologistics()
        {
            var doctors = _doctorrepo.GetAllHaemotologistics();
            if (doctors == null)
            {
                return new BaseResponse<List<DoctorDTO>>
                {
                    Message = "No Doctor Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<DoctorDTO>>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = doctors
            };
        }

        public BaseResponse<List<DoctorDTO>> GetAllInitializedDoctors()
        {
            var doctors = _doctorrepo.GetAllInitializedDoctors();
             if (doctors == null)
            {
                return new BaseResponse<List<DoctorDTO>>
                {
                    Message = "No Doctor Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<DoctorDTO>>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = doctors
            };
        }

        public BaseResponse<List<DoctorDTO>> GetAllOpticians()
        {
            var doctors = _doctorrepo.GetAllOpticians();
            if (doctors == null)
            {
                return new BaseResponse<List<DoctorDTO>>
                {
                    Message = "No Doctor Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<DoctorDTO>>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = doctors
            };
        }
        public BaseResponse<List<DoctorDTO>> GetAllOrthopaedics()
        {
            var doctors = _doctorrepo.GetAllOrthopaedics();
            if (doctors == null)
            {
                return new BaseResponse<List<DoctorDTO>>
                {
                    Message = "No Doctor Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<DoctorDTO>>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = doctors
            };
        }
        public BaseResponse<List<DoctorDTO>> GetAllPadaestrics()
        {
            var doctors = _doctorrepo.GetAllPadaestrics();
            if (doctors == null)
            {
                return new BaseResponse<List<DoctorDTO>>
                {
                    Message = "No Doctor Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<DoctorDTO>>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = doctors
            };
        }
        public BaseResponse<List<DoctorDTO>> GetAllPharmacologist()
        {
            var doctors = _doctorrepo.GetAllPharmacologist();
            if (doctors == null)
            {
                return new BaseResponse<List<DoctorDTO>>
                {
                    Message = "No Doctor Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<DoctorDTO>>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = doctors
            };
        }
        public BaseResponse<DoctorDTO> GetByEmail(string email)
        {
            var docs = _doctorrepo.ExistByEmail(email);
            if (docs == false)
            {
                return new BaseResponse<DoctorDTO>
                {
                    Message = "Doctor not exist",
                    Suceeded = false
                };
            }
            var Doctor = _doctorrepo.GetByEmail(email);
            return new BaseResponse<DoctorDTO>
            {
                Message = "Doctor exist",
                Suceeded = true,
                Data = new DoctorDTO
                {
                    FirstName = Doctor.FirstName,
                    LastName = Doctor.LastName,
                    Address = Doctor.Address,
                    DateOfBirth = Doctor.DateOfBirth,
                    Email = Doctor.Email,
                    Gender = Doctor.Gender,
                    PhoneNumber = Doctor.PhoneNumber,
                    AreaOfSpec = Doctor.AreaOfSpec,
                    DoctorPhoto = Doctor.DoctorPhoto,
                    StaffNumber = Doctor.StaffNumber
                }
            };
        }
        public BaseResponse<DoctorDTO> Register(CreateDoctorModel model)
        {
            var name = _doctorrepo.ExistByEmail(model.Email);
            if (name == true)
            {
                return new BaseResponse<DoctorDTO>
                {
                    Message = "Doctor already exists",
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
            var roled = _rolerepo.GetRoleByName("Doctor");
            var userRole = new UserRole
            {
                Role = roled,
                RoleId = roled.Id,
                User = user,
                UserId = user.Id
            };
            user.UserRole.Add(userRole);
            var doctor = new Doctor
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                DateOfBirth = model.DateOfBirth,
                Email = model.Email,
                Gender = model.Gender,
                PhoneNumber = model.PhoneNumber,
                AreaOfSpec = model.AreaOfSpec,
                DoctorPhoto = model.DoctorPhoto,
                DoctorCertificate = model.DoctorCertificate,
                RegistrationStatus = Enums.RegistrationStatus.Initialized,
                AvailabilityStatus = true,
                StaffNumber = $" VHA {Guid.NewGuid().ToString().Substring(0, 10).Replace("-", "").ToUpper()}",
                User = user,
                UserId = user.Id,
            };
            _userrepo.Create(user);
            var doctors = _doctorrepo.Create(doctor);
            return new BaseResponse<DoctorDTO>
            {
                Message = "Successfully created",
                Suceeded = true,
                Data = doctors
            };
        }
        public BaseResponse<DoctorDTO> ReturnById(int id)
        {
            if (!(_doctorrepo.ExistById(id)))
            {
                return new BaseResponse<DoctorDTO>
                {
                    Message = "Doctor doesn't exist",
                    Suceeded = false
                };
            }
            var doctor = _doctorrepo.ReturnById(id);
            return new BaseResponse<DoctorDTO>
            {
                Message = "Doctor successfully retrieved",
                Suceeded = true,
                Data = doctor
            };
        } 
        public BaseResponse<DoctorDTO> Update(UpdateDoctorModel model, int Id)
        {
            var docs = _doctorrepo.ExistById(Id);
            if (docs == false)
            {
                return new BaseResponse<DoctorDTO>
                {
                    Message = "Doctor doesn't exist",
                    Suceeded = false
                };
            }
            var doctorInfo = _doctorrepo.Get(Id);
            var user = _userrepo.Get(doctorInfo.UserId);
            doctorInfo.FirstName = model.FirstName ?? doctorInfo.FirstName;
            doctorInfo.LastName = model.LastName ?? doctorInfo.LastName;
            doctorInfo.PhoneNumber = model.PhoneNumber ?? doctorInfo.PhoneNumber;
            doctorInfo.DoctorPhoto = doctorInfo.DoctorPhoto;
            doctorInfo.PhoneNumber = model.PhoneNumber ?? doctorInfo.PhoneNumber;
            user.Password = user.Password ?? model.Password;
            var doctor = _doctorrepo.Update(doctorInfo);
            _userrepo.Update(user);
            return new BaseResponse<DoctorDTO>
            {
                Message = "Doctor successfully updated",
                Suceeded = true,
                Data = new DoctorDTO
                {
                    FirstName = doctor.FirstName,
                    LastName = doctor.LastName,
                    Address = doctor.Address,
                    DateOfBirth = doctor.DateOfBirth,
                    Email = doctor.Email,
                    Gender = doctor.Gender,
                    PhoneNumber = doctor.PhoneNumber,
                    AreaOfSpec = doctor.AreaOfSpec,
                    DoctorPhoto = doctor.DoctorPhoto,
                    StaffNumber = doctor.StaffNumber,
                }
            };
        }
    }
}