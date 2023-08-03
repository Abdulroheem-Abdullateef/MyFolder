using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Entities;

namespace TransportManagementSystem.Interfaces.IRepositories
{
    public interface IDriverRepository
    {
        Driver Create(Driver driver);
        Driver GetDriverById(int id);
        void DeleteDriver(Driver driver);
        Driver UpdateDriver(Driver driver);
        bool ExitById(int id);
        bool ExitByDriverlicenseNumber(string licensenumber);
        List<Driver> GetDrivers();
        IList<Driver> GetAllDrivers();


    }
}
