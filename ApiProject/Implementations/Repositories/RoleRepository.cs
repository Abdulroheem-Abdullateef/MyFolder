using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;
using System.Linq;

namespace ApiProject.Implementations.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly MyContext _context;

        public RoleRepository(MyContext context)
        {
            _context = context;
        }

        public RoleDTO Create(Role Role)
        {
             _context.Roles.Add(Role);
            _context.SaveChanges();
            return new RoleDTO
            {
                RoleName = Role.RoleName,
                Description = Role.Description
            };
        }

        public void Delete(Role Role)
        {
            _context.Roles.Remove(Role);
            _context.SaveChanges();
        }

        public bool ExistById(int Id)
        {
           return _context.Roles.Any(d => d.Id == Id);
        }

        public bool ExistByName(string name)
        {
            return _context.Roles.Any(d => d.RoleName == name);
        }

        public Role Get(int id)
        {
           return _context.Roles.FirstOrDefault(q => q.Id == id);
        }

        public List<RoleDTO> GetAll()
        {
             return _context.Roles.Select(role => new RoleDTO
            {
                Id = role.Id,
                RoleName = role.RoleName,
                Description = role.Description
            }).ToList();
        }

        public Role GetRoleByName(string name)
        {
            return _context.Roles.SingleOrDefault(x => x.RoleName == name);
        }

        public RoleDTO ReturnById(int Id)
        {
            var pat = _context.Roles.FirstOrDefault(x => x.Id == Id);
            return new RoleDTO
            {
               Id = pat.Id,
               RoleName = pat.RoleName,
               Description = pat.Description              
            };
        }

        public RoleDTO Update(Role Role)
        {
            _context.Roles.Update(Role);
            _context.SaveChanges();
           return new RoleDTO
           {
               Id = Role.Id,
               RoleName = Role.RoleName,
               Description = Role.RoleName
           };
        }
    }
}