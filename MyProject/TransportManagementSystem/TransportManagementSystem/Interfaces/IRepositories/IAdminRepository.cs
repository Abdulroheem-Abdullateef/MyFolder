using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Entities;

namespace TransportManagementSystem.Interfaces.IRepositories
{
    public interface IAdminRepository
    {
        Admin CreateAdmin(Admin admin);
        void DeleteAdmin(Admin id);
        Admin GetAdmin(int id);
        Admin UpdateAdmin(int id, Admin admin);
        IList<Admin> GetAllAdmin();
    }
}
