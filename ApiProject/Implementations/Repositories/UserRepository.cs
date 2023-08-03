using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Implementations.Repositories
{
    public class UserRepository : IUserRepository
    {
        public readonly MyContext _context;

        public UserRepository(MyContext context)
        {
            _context = context;
        }

        public UserDTO Create(User User)
        {
            _context.Users.Add(User);
            _context.SaveChanges();
            return new UserDTO
            {
                Email = User.Email,
                LastName = User.LastName,
                FirstName = User.FirstName
            };
        }

        public void Delete(User User)
        {
            _context.Users.Remove(User);
            _context.SaveChanges();
        }

        public bool ExistByEmail(string email)
        {
            return _context.Users.Any(t => t.Email == email);
        }

        public User Get(int Id)
        {
            return _context.Users.FirstOrDefault(t => t.Id == Id);
        }

        public List<UserDTO> GetAll()
        {
            return _context.Users.Select(pat => new UserDTO
            {
              
               FirstName = pat.FirstName,
               LastName = pat.LastName,
               Email = pat.Email,
               
            }).ToList();
        }

        public User GetByEmail(string email)
        {
            return _context.Users.Include(a => a.UserRole).ThenInclude(a => a.Role).SingleOrDefault(r => r.Email == email);
        }

        public UserDTO Update(User User)
        {
           _context.Users.Update(User);
           _context.SaveChanges();
           return new UserDTO
           {               
                Email = User.Email,
                LastName = User.LastName,
                FirstName = User.FirstName
           };
        }
    }
}