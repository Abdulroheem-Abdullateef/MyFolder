using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Context;
using TransportManagementSystem.Dtos;
using TransportManagementSystem.Entities;
using TransportManagementSystem.Interfaces.IRepositories;

namespace TransportManagementSystem.Implementations.Repositories
{
    public class BusRepository : IBusRepository
    {
        private readonly TransportManagementContext _context;

        public BusRepository()
        {
            _context = new TransportManagementContext();
        }

        

        public bool CreateBus(Bus bus)
        {
            _context.Buses.Add(bus);
            _context.SaveChanges();
            return true;
        }

       
        public bool DeleteBus(Bus bus)
        {
            _context.Buses.Remove(bus);
            _context.SaveChanges();
            return true;
        }

        public List<BusDto> GetAllBuses()
        {
            return _context.Buses.Select(a =>  new BusDto
            {
                Id = a.Id,
                AvailabilityStatus = a.AvailabilityStatus,
                Capacity = a.Capacity,
                EngineNumber = a.EngineNumber,
                Model = a.Model,
                RegistrationNumber = a.RegistrationNumber,
                PlateNumber = a.PlateNumber,
                BusClass = a.BusClass,
            }).ToList();
        }

        public BusDto GetBusById(int id)
        {
            var bus = _context.Buses.Find(id);

            var buses = new BusDto
            {
                Id = bus.Id,
                AvailabilityStatus = bus.AvailabilityStatus,
                Capacity = bus.Capacity,
                EngineNumber = bus.EngineNumber,
                Model = bus.Model,
                RegistrationNumber = bus.RegistrationNumber,
                PlateNumber = bus.PlateNumber
              
            }; return buses;

        }
        
        public BusDto GetBusByRegistrationNumber(string registrationnumber)
        {
            var bus = _context.Buses.SingleOrDefault(a => a.RegistrationNumber == registrationnumber);

            var busDto = new BusDto
            {
                AvailabilityStatus = bus.AvailabilityStatus,
                Model = bus.Model
            }; return busDto;
        }

        public Bus GetBusId(int id)
        {
            var bus = _context.Buses.Find(id);
            if (bus == null)
            {
                throw new KeyNotFoundException($"the bus with id {id} does not exist");
            }
            return bus;
        }

        public Bus ReturnGetBusByRegistrationNumber(string registrationnumber)
        {
            var bus = _context.Buses.SingleOrDefault(a => a.RegistrationNumber == registrationnumber);
            return bus;
        }

        public bool UpDate(Bus bus)
        {
            var bus1 = _context.Buses.Update(bus);
            _context.SaveChanges();
            return true;
        }
    }
}
