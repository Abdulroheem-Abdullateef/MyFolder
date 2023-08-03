using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Dtos;

namespace TransportManagementSystem.Interfaces.IServices
{
    public interface IAdminServices
    {
        bool CreateAdmin(CreateRequestAdminModel admin);
        bool UpdateAdmin(int id, UpdateRequestAdminModel admin);
        AdminDto GetAdmin(int id);
        IList<AdminDto> GetAllAdmin();
        void Delete(int id);

    }
}
