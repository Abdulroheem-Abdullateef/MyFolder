using System.Collections.Generic;
using System.Linq;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Implementations.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly MyContext _context;
        public DoctorRepository(MyContext context)
        {
            _context = context;
        }
        public DoctorDTO Create(Doctor Doctor)
        {
            _context.Doctors.Add(Doctor);
            _context.SaveChanges();
            return new DoctorDTO
            {
                Id = Doctor.Id,
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
            };
        }
        public void Delete(Doctor Doctor)
        {
            _context.Doctors.Remove(Doctor);
            _context.SaveChanges();
        }
        public bool ExistByEmail(string Email)
        {
            return _context.Doctors.Any(t => t.Email == Email);
        }
        public bool ExistById(int Id)
        {
            return _context.Doctors.Any(t => t.Id == Id);
        }
        public Doctor Get(int id)
        {
            return _context.Doctors.SingleOrDefault(d => d.Id == id);
        }
        public List<DoctorDTO> GetAllApprovedDoctors()
        {
            return _context.Doctors.Where(e => e.RegistrationStatus == Enums.RegistrationStatus.Approved).Select(Doctor => new DoctorDTO
            {
                Id = Doctor.Id,
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
            }).ToList();
        }
        public List<DoctorDTO> GetAllAvailableDoctors()
        {
            return _context.Doctors.Where(u => u.AvailabilityStatus == true && u.RegistrationStatus == Enums.RegistrationStatus.Approved)
            .Select(res => new DoctorDTO
            {
                Id = res.Id,
                FirstName = res.FirstName,
                LastName = res.LastName,
                AreaOfSpec = res.AreaOfSpec,
                Email = res.Email,
                PhoneNumber = res.PhoneNumber,
                DoctorPhoto = res.DoctorPhoto,
                StaffNumber = res.StaffNumber,
                Gender = res.Gender,
                Address = res.Address,
                AvailabilityStatus = res.AvailabilityStatus,
                DateOfBirth = res.DateOfBirth
            }).ToList();
        }
        public List<DoctorDTO> GetAllDentists()
        {
            return _context.Doctors.Where(t => t.AreaOfSpec == Enums.AreaOfSpec.Dentist && t.RegistrationStatus == Enums.RegistrationStatus.Approved)
            .Select(res => new DoctorDTO
            {
                Id = res.Id,
                FirstName = res.FirstName,
                LastName = res.LastName,
                Email = res.Email,
                PhoneNumber = res.PhoneNumber,
                AreaOfSpec = res.AreaOfSpec,
                DoctorPhoto = res.DoctorPhoto,
                StaffNumber = res.StaffNumber
            }).ToList();
        }
        public List<DoctorDTO> GetAllGynaeocologists()
        {
            return _context.Doctors.Where(t => t.AreaOfSpec == Enums.AreaOfSpec.Gynaeocologist && t.RegistrationStatus == Enums.RegistrationStatus.Approved)
            .Select(res => new DoctorDTO
            {
                Id = res.Id,
                FirstName = res.FirstName,
                LastName = res.LastName,
                Email = res.Email,
                PhoneNumber = res.PhoneNumber,
                AreaOfSpec = res.AreaOfSpec,
                DoctorPhoto = res.DoctorPhoto,
                StaffNumber = res.StaffNumber
            }).ToList();
        }
        public List<DoctorDTO> GetAllHaemotologistics()
        {
            return _context.Doctors.Where(t => t.AreaOfSpec == Enums.AreaOfSpec.Haematologists && t.RegistrationStatus == Enums.RegistrationStatus.Approved)
            .Select(res => new DoctorDTO
            {
                Id = res.Id,
                FirstName = res.FirstName,
                LastName = res.LastName,
                Email = res.Email,
                PhoneNumber = res.PhoneNumber,
                AreaOfSpec = res.AreaOfSpec,
                DoctorPhoto = res.DoctorPhoto,
                StaffNumber = res.StaffNumber
            }).ToList();
        }

        public List<DoctorDTO> GetAllInitializedDoctors()
        {
            return _context.Doctors.Where(r => r.RegistrationStatus == Enums.RegistrationStatus.Initialized).Select(res => new DoctorDTO
            {
                Id = res.Id,
                FirstName = res.FirstName,
                LastName = res.LastName,
                Address = res.Address,
                DateOfBirth = res.DateOfBirth,
                Email = res.Email,
                Gender = res.Gender,
                PhoneNumber = res.PhoneNumber,
                AreaOfSpec = res.AreaOfSpec,
                DoctorPhoto = res.DoctorPhoto,
                StaffNumber = res.StaffNumber
            }).ToList();
        }

        public List<DoctorDTO> GetAllOpticians()
        {
            return _context.Doctors.Where(t => t.AreaOfSpec == Enums.AreaOfSpec.Optician && t.RegistrationStatus == Enums.RegistrationStatus.Approved)
            .Select(res => new DoctorDTO
            {
                Id = res.Id,
                FirstName = res.FirstName,
                LastName = res.LastName,
                Email = res.Email,
                PhoneNumber = res.PhoneNumber,
                AreaOfSpec = res.AreaOfSpec,
                DoctorPhoto = res.DoctorPhoto,
                StaffNumber = res.StaffNumber
            }).ToList();
        }
        public List<DoctorDTO> GetAllOrthopaedics()
        {
            return _context.Doctors.Where(t => t.AreaOfSpec == Enums.AreaOfSpec.Orthopaedics && t.RegistrationStatus == Enums.RegistrationStatus.Approved)
            .Select(res => new DoctorDTO
            {
                Id = res.Id,
                FirstName = res.FirstName,
                LastName = res.LastName,
                Email = res.Email,
                PhoneNumber = res.PhoneNumber,
                AreaOfSpec = res.AreaOfSpec,
                DoctorPhoto = res.DoctorPhoto,
                StaffNumber = res.StaffNumber
            }).ToList();
        }
        public List<DoctorDTO> GetAllPadaestrics()
        {
            return _context.Doctors.Where(t => t.AreaOfSpec == Enums.AreaOfSpec.Padaestrics && t.RegistrationStatus == Enums.RegistrationStatus.Approved)
            .Select(res => new DoctorDTO
            {
                Id = res.Id,
                FirstName = res.FirstName,
                LastName = res.LastName,
                Email = res.Email,
                PhoneNumber = res.PhoneNumber,
                AreaOfSpec = res.AreaOfSpec,
                DoctorPhoto = res.DoctorPhoto,
                StaffNumber = res.StaffNumber
            }).ToList();
        }
        public List<DoctorDTO> GetAllPharmacologist()
        {
            return _context.Doctors.Where(t => t.AreaOfSpec == Enums.AreaOfSpec.Pharmacologist && t.RegistrationStatus == Enums.RegistrationStatus.Approved)
            .Select(res => new DoctorDTO
            {
                Id = res.Id,
                FirstName = res.FirstName,
                LastName = res.LastName,
                Email = res.Email,
                PhoneNumber = res.PhoneNumber,
                AreaOfSpec = res.AreaOfSpec,
                DoctorPhoto = res.DoctorPhoto,
                StaffNumber = res.StaffNumber
            }).ToList();
        }
        public Doctor GetByEmail(string Email)
        {
            return _context.Doctors.SingleOrDefault(x => x.Email == Email);
        }
        public DoctorDTO ReturnById(int Id)
        {
            var Doctor = _context.Doctors.SingleOrDefault(x => x.Id == Id);
            return new DoctorDTO
            {
                Id = Doctor.Id,
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
            };
        }
        public Doctor Update(Doctor Doctor)
        {
            _context.Doctors.Update(Doctor);
            _context.SaveChanges();
            return Doctor;
        }

        // public DoctorDTO ViewAssignedPatient(int MedicalRecordId)
        // {
        //    return _context.Doctors.Where(c => c.DoctorMedicalRecords).
        // }
    }
}