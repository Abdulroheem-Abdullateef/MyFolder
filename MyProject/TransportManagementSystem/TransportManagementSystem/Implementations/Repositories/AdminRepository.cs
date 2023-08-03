using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Context;
using TransportManagementSystem.Entities;
using TransportManagementSystem.Interfaces.IRepositories;

namespace TransportManagementSystem.Implementations.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly TransportManagementContext _context;

        public AdminRepository()
        {
            _context = new TransportManagementContext();
        }

        public Admin CreateAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
            return admin;
        }

        public void DeleteAdmin(Admin id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public Admin GetAdmin(int id)
        {
            var admin = _context.Admins.Find(id);
            return admin;
        }

        public IList<Admin> GetAllAdmin()
        {
            return _context.Admins.ToList();
        }

        public Admin UpdateAdmin(int id, Admin admin)
        {
            _context.Admins.Find(id);
            _context.Admins.UpdateRange(admin);
            _context.SaveChanges();
            return admin;
        }
    }
}
