using Microsoft.EntityFrameworkCore;
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
    public class DriverRepository : IDriverRepository
    {
        private readonly TransportManagementContext _context;

        public DriverRepository()
        {
            _context = new TransportManagementContext();
        }

        public Driver Create(Driver driver)
        {
            _context.Drivers.Add(driver);
            _context.SaveChanges();
            return driver;
        }

        public void DeleteDriver(Driver driver)
        {
             _context.Drivers.Remove(driver);
            _context.SaveChanges();
        }

        public bool ExitByDriverlicenseNumber(string licensenumber)
        {
            return _context.Drivers.Any(l => l.LicenseNumberId == licensenumber);
            
        }

        public bool ExitById(int id)
        {
            return _context.Drivers.Any(i => i.Id == id);
        }

        public IList<Driver> GetAllDrivers()
        {
            var driver = _context.Drivers.ToList();
            return driver;
        }

        public Driver GetDriverById(int id)
        {
            var driver = _context.Drivers.Find(id);
            return driver;
        }

       
        public List<Driver> GetDrivers()
        {
            var driver = _context.Drivers.ToList();
            return driver;

        }

        public Driver UpdateDriver(Driver driver)
        {
            _context.Drivers.Update(driver);
            _context.SaveChanges();
            return driver;
        }
    }
}
