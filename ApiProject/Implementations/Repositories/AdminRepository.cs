using System.Collections.Generic;
using System.Linq;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;

namespace ApiProject.Implementations.Repositories
{
    
    public class AdminRepository : IAdminRepository
    {
        private readonly MyContext _context;

        public AdminRepository(MyContext context)
        {
            _context = context;
        }

        public AdminDTO Create(Admin Admin)
        {
            _context.Admins.Add(Admin);
            _context.SaveChanges();
            return new AdminDTO
            {
                Id = Admin.Id,
                FirstName = Admin.FirstName,
                LastName = Admin.LastName,
                Address = Admin.Address,
                DateOfBirth = Admin.DateOfBirth,
                Email = Admin.Email,
                Gender = Admin.Gender,
                PhoneNumber = Admin.PhoneNumber 
            };
        }

        public void Delete(Admin Admin)
        {
           _context.Admins.Remove(Admin);
           _context.SaveChanges();
        }

        public bool ExistByEmail(string Email)
        {
            return _context.Admins.Any(t => t.Email == Email);
        }

        public bool ExistById(int Id)
        {
            return _context.Admins.Any(t => t.Id == Id);
        }

        public Admin Get(int id)
        {
           return _context.Admins.FirstOrDefault(d => d.UserId == id);
        }

        public List<AdminDTO> GetAll()
        {
            return _context.Admins.Select(Admin => new AdminDTO
            {
                Id = Admin.Id,
                FirstName = Admin.FirstName,
                LastName = Admin.LastName,
                Address = Admin.Address,
                DateOfBirth = Admin.DateOfBirth,
                Email = Admin.Email,
                Gender = Admin.Gender,
                PhoneNumber = Admin.PhoneNumber 
            }).ToList();
        }

        public Admin GetByEmail(string Email)
        {
            return _context.Admins.SingleOrDefault(x => x.Email == Email);
        }

        public AdminDTO ReturnById(int Id)
        {
            var Admin = _context.Admins.FirstOrDefault(x => x.Id == Id);
            return new AdminDTO
            {
                Id = Admin.Id,
                FirstName = Admin.FirstName,
                LastName = Admin.LastName,
                Address = Admin.Address,
                DateOfBirth = Admin.DateOfBirth,
                Email = Admin.Email,
                Gender = Admin.Gender,
                PhoneNumber = Admin.PhoneNumber 
            };
        }

        public Admin Update(Admin Admin)
        {
          _context.Admins.Update(Admin);
          _context.SaveChanges();
          return Admin;
        }
       
    }
}