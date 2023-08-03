using System.Collections.Generic;
using System.Linq;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;

namespace ApiProject.Implementations.Repositories

{
    public class PatientRepository : IPatientRepository
    {
        private readonly MyContext _context;

        public PatientRepository(MyContext context)
        {
            _context = context;
        }

        public PatientDTO Create(Patient Patient)
        {
            _context.Patients.Add(Patient);
            _context.SaveChanges();
            return new PatientDTO
            {
                Id = Patient.Id,
                FirstName = Patient.FirstName,
                LastName = Patient.LastName,
                Email = Patient.Email,
                Gender = Patient.Gender,
                Address = Patient.Address,
                PatientPhoto = Patient.PatientPhoto,
                DateOfBirth = Patient.DateOfBirth,
                PhoneNumber = Patient.PhoneNumber,
                BloodGroup = Patient.BloodGroup,
                Genotype = Patient.Genotype
            };
        }

        public void Delete(Patient Patient)
        {
            _context.Patients.Remove(Patient);
            _context.SaveChanges();
        }

        public bool ExistByEmail(string Email)
        {
            return _context.Patients.Any(r => r.Email == Email);
        }

        public bool ExistById(int Id)
        {
            return _context.Patients.Any(r => r.Id == Id);
        }

        public Patient Get(int id)
        {
            return _context.Patients.FirstOrDefault(d => d.UserId == id);
        }

        public List<PatientDTO> GetAll()
        {
            return _context.Patients.Select(pat => new PatientDTO
            {
                Id = pat.Id,
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
            }).ToList();
        }

        public Patient GetByEmail(string Email)
        {
            return _context.Patients.FirstOrDefault(d => d.Email == Email);
        }
     

        public PatientDTO ReturnById(int Id)
        {
            var pat = _context.Patients.FirstOrDefault(x => x.Id == Id);
            return new PatientDTO
            {
                Id = pat.Id,
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
            };

        }

        public Patient Update(Patient Patient)
        {
            _context.Patients.Update(Patient);
            _context.SaveChanges();
            return Patient;
        }
    }
}