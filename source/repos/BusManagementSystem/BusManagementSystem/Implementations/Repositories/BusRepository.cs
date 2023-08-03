using BusManagementSystem.contest;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Interfaces;
using BusManagementSystem.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Repository
{
    public class BusRepository : IBusRepository
    {
        private readonly ApplicationDBContext _context;

        public BusRepository()
        {
            _context = new ApplicationDBContext();
        }

        public Bus Create(Bus bus)
        {
            _context.Buses.Add(bus);
            _context.SaveChanges();
            return bus;
        }


        public void Delete(Bus bus)
        {

            _context.Buses.Remove(bus);
            _context.SaveChanges();

        }

        public bool ExistById(int id)
        {
            return _context.Buses.Any(b => b.Id == id);
        }

        public bool ExistByRegNumber(string regNum)
        {
            return _context.Buses.Any(b => b.RegistrationNumber == regNum);
        }

        public List<BusDto> GetAll()
        {

            return _context.Buses.Select(a => new BusDto 
            {
                PlateNumber = a.PlateNumber,
                RegistrationNumber = a.RegistrationNumber,
                Model = a.Model,
                BusType = a.BusType,
                TripStatus = a.TripStatus,
                AvailabilityStatus = a.AvailabilityStatus
            }).ToList();
        }

        public List<BusDto> GetAvailableBuses()
        {
            return _context.Buses.Where(bus => bus.AvailabilityStatus == true).Select( busdto => new BusDto
            {
                PlateNumber = busdto.PlateNumber,
                RegistrationNumber = busdto.RegistrationNumber,
                Model = busdto.Model,
                BusType = busdto.BusType,
                TripStatus = busdto.TripStatus,
                AvailabilityStatus = busdto.AvailabilityStatus


            }).ToList();
        }

        public Bus Get(int id)
        {
            var bus = _context.Buses.Find(id);

            return bus;
        }

        public Bus GetByRegistrationNumber(string registrationNumber)
        {
            var bus = _context.Buses.SingleOrDefault(x => x.RegistrationNumber == registrationNumber);

            return bus;
        }

        public Bus Update(Bus bus)
        {
            _context.Buses.Update(bus);
            _context.SaveChanges();
            return bus;
        }
    }
}
