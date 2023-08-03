using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Dtos;
using TransportManagementSystem.Entities;
using DriverDto = TransportManagementSystem.Dtos.DriverDto;

namespace TransportManagementSystem.Interfaces.IServices
{
    public interface IDriverServices
    {

        DriverDto Create(CreateRequestDriverModel driver);
        DriverDto GetDriverById(int id);
        void DeleteDriver(Driver driver);
        DriverDto GetDriverByRegistrationNumber(string registrationnumber);
        DriverDto UpdateDriver(UpdateRequestDriverModel driver);
        bool ExitById(int id);
        bool ExitByDriverlicenseNumber(string licensenumber);
        List<Driver>GetDrivers();
        IList<Driver> GetAllDrivers();
    }
}
