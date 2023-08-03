using System.Collections.Generic;
using System.Linq;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;

namespace ApiProject.Implementations.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly MyContext _context;

        public HospitalRepository(MyContext context)
        {
            _context = context;
        }

        public HospitalDTO Create(Hospital Hospital)
        {
            _context.Hospitals.Add(Hospital);
            _context.SaveChanges();
            return new HospitalDTO
            {
                Id = Hospital.Id,
                Name = Hospital.Name,
                Address = Hospital.Address
            };
        }

        public void Delete(Hospital Hospital)
        {
            _context.Hospitals.Remove(Hospital); 
            _context.SaveChanges();
        }

        public bool ExistById(int id)
        {
             return _context.Hospitals.Any(t => t.Id == id);
        }

        public bool ExistByMail(string Email)
        {
            return _context.Hospitals.Any(t => t.Hospitalmail == Email);
        }

        public bool ExistByName(string name)
        {
            return _context.Hospitals.Any(t => t.Name == name);
        }

        public Hospital Get(int id)
        {
           return _context.Hospitals.SingleOrDefault(t => t.UserId == id);
        }

        public List<HospitalDTO> GetAll()
        {
            return _context.Hospitals.Select(host => new HospitalDTO
            {
                Id = host.Id,
                Address = host.Address,
                Name = host.Name
            }).ToList();
        }

        public Hospital GetByMail(string email)
        {
            return _context.Hospitals.SingleOrDefault(h => h.Hospitalmail == email);
        }

        public HospitalDTO ReturnById(int Id)
        {
            var host = _context.Hospitals.SingleOrDefault(r => r.Id == Id);
            return new HospitalDTO
            {
                Id = host.Id,
                Address = host.Address,
                Name = host.Name,
            };
        }

        public Hospital Update(Hospital Hospital)
        {
            _context.Hospitals.Update(Hospital);
            _context.SaveChanges();
            return Hospital;
        }
    }
}