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
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientrepo;
        private readonly IUserRepository _userrepo;
        private readonly IRoleRepository _rolerepo;
        private readonly IWebHostEnvironment _webroot;

        public PatientService(IPatientRepository patientrepo, IUserRepository userrepo, IRoleRepository rolerepo, IWebHostEnvironment webroot)
        {
            _patientrepo = patientrepo;
            _userrepo = userrepo;
            _rolerepo = rolerepo;
            _webroot = webroot;
        }

        public BaseResponse<bool> Delete(int id)
        {
            var pat = _patientrepo.Get(id);
            if (pat == null)
            {
                return new BaseResponse<bool>
                {
                    Message = "Patient not found",
                    Suceeded = false
                };
            }
            _patientrepo.Delete(pat);
            return new BaseResponse<bool>
            {
                Message = "Patient successfully Deleted",
                Suceeded = true
            };
        }

        public BaseResponse<List<PatientDTO>> GetAll()
        {
            var pat = _patientrepo.GetAll();
            if (pat == null)
            {
                return new BaseResponse<List<PatientDTO>>
                {
                    Message = "No Patient Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<PatientDTO>>
            {
                Message = "Patient successfully retrieved",
                Suceeded = true,
                Data = pat
            };
        }
        public BaseResponse<PatientDTO> GetByEmail(string email)
        {
            var pats = _patientrepo.ExistByEmail(email);
            if (pats == false)
            {
                return new BaseResponse<PatientDTO>
                {
                    Message = "Patient not found",
                    Suceeded = false
                };
            }
            var pat = _patientrepo.GetByEmail(email);
            return new BaseResponse<PatientDTO>
            {
                Message = "Patient exist",
                Suceeded = true,
                Data = new PatientDTO
                {
                    FirstName = pat.FirstName,
                    LastName = pat.LastName,
                    Email = pat.Email,
                    Gender = pat.Gender,
                    Address = pat.Address,
                    PatientPhoto = pat.PatientPhoto,
                    DateOfBirth = pat.DateOfBirth,
                    PhoneNumber = pat.PhoneNumber,
                    BloodGroup = pat.BloodGroup,
                    Genotype = pat.Genotype
                }
            };
        }
        public BaseResponse<PatientDTO> Register(CreatePatientModel model)
        {
            var name = _patientrepo.ExistByEmail(model.Email);
            if (name == true)
            {
                return new BaseResponse<PatientDTO>
                {
                    Message = "Patient already exists",
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
            var roled = _rolerepo.GetRoleByName("Patient");
            var userRole = new UserRole
            {
                Role = roled,
                RoleId = roled.Id,
                User = user,
                UserId = user.Id
            };
            user.UserRole.Add(userRole);
            var patient = new Patient
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Gender = model.Gender,
                Address = model.Address,
                PatientPhoto = model.PatientPhoto,
                DateOfBirth = model.DateOfBirth,
                PhoneNumber = model.PhoneNumber,
                BloodGroup = model.BloodGroup,
                Genotype = model.Genotype,
                User = user,
                UserId = user.Id,
            };
            _userrepo.Create(user);
            var pat = _patientrepo.Create(patient);
            return new BaseResponse<PatientDTO>
            {
                Message = "Successfully created",
                Suceeded = true,
                Data = pat
            };
        }

        public BaseResponse<PatientDTO> ReturnById(int id)
        {
            var res = _patientrepo.ExistById(id);
            if (res == false)
            {
                return new BaseResponse<PatientDTO>
                {
                    Message = "Patient doesn't exist",
                    Suceeded = false
                };
            }
            var pat = _patientrepo.ReturnById(id);
            return new BaseResponse<PatientDTO>
            {
                Message = "Patient successfully retrieved",
                Suceeded = true,
                Data = pat
            };
        }

        public BaseResponse<PatientDTO> Update(UpdatetePatientModel model, int Id)
        {
            var res = _patientrepo.ExistById(Id);
            if (res == false)
            {
                return new BaseResponse<PatientDTO>
                {
                    Message = "Patient doesn't exist",
                    Suceeded = false
                };
            }
            var patientInfo = _patientrepo.Get(Id);
            var user = _userrepo.Get(patientInfo.UserId);
            patientInfo.FirstName = model.FirstName ?? patientInfo.FirstName;
            patientInfo.LastName = model.LastName ?? patientInfo.LastName;
            patientInfo.PhoneNumber = model.PhoneNumber ?? patientInfo.PhoneNumber;
            patientInfo.PatientPhoto = patientInfo.PatientPhoto;
            patientInfo.PhoneNumber = model.PhoneNumber ?? patientInfo.PhoneNumber;
            user.Password = model.Password ?? user.Password;
            var pat = _patientrepo.Update(patientInfo);
            _userrepo.Update(user);
            return new BaseResponse<PatientDTO>
            {
                Message = "Patient successfully updated",
                Suceeded = true,
                Data = new PatientDTO
                {
                    FirstName = pat.FirstName,
                    LastName = pat.LastName,
                    Email = pat.Email,
                    Gender = pat.Gender,
                    Address = pat.Address,
                    PatientPhoto = pat.PatientPhoto,
                    DateOfBirth = pat.DateOfBirth,
                    PhoneNumber = pat.PhoneNumber,
                    BloodGroup = pat.BloodGroup,
                    Genotype = pat.Genotype,
                }
            };
        }

    }
}