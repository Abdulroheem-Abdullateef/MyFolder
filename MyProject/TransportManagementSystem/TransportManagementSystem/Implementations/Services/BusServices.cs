using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Dtos;
using TransportManagementSystem.Entities;
using TransportManagementSystem.Implementations.Repositories;
using TransportManagementSystem.Interfaces.IRepositories;
using TransportManagementSystem.Interfaces.IServices;

namespace TransportManagementSystem.Implementations.Services
{
    public class BusServices : IBusServices
    {
        private readonly BusRepository _busRepository;

        public BusServices()
        {
            _busRepository = new BusRepository();
        }
        public bool CreateBus(CreateRequestBusModel bus)
        {
            var bus1 = new Bus
            {
                Model = bus.Model,
                BusClass = bus.BusClass,
                PlateNumber = bus.PlateNumber,
                EngineNumber = bus.EngineNumber,
                RegistrationNumber = Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 7),
                AvailabilityStatus = true


            };
            _busRepository.CreateBus(bus1);
            return true;
        }

        public bool DeleteBus(string registrationnumber)
        {
            var bus = _busRepository.ReturnGetBusByRegistrationNumber(registrationnumber);
            if (bus == null)
            {
                throw new KeyNotFoundException($" the bus with {registrationnumber} does not exit ");

            }
            _busRepository.DeleteBus(bus);
            return true;
        }

        public List<BusDto> GetAllBuses()
        {
            var bus = _busRepository.GetAllBuses();
            return bus;
        }

        public BusDto GetBusById(int id)
        {
            var bus = _busRepository.GetBusById(id);
            return bus;

        }

        public BusDto GetBusByRegistrationNumber(string registrationnumber)
        {
            var bus = _busRepository.GetBusByRegistrationNumber(registrationnumber);
            return bus;
        }

        public Bus GetBusId(int id)
        {
            var bus = _busRepository.GetBusId(id);
            if (bus == null)
            {
                throw new KeyNotFoundException($"not found");
            }
            return bus;
        }

        public bool UpDate(UpdateRequestBusModel bus, string registrationnuumber)
        {
            var bus1 = _busRepository.ReturnGetBusByRegistrationNumber(registrationnuumber);
            if (bus1 == null)
            {
                throw new KeyNotFoundException($"not found");
            }
            bus1.PlateNumber = bus.PlateNumber;
            bus1.BusClass = bus.BusClass;
            _busRepository.UpDate(bus1);
            return true;
        }

       
    }
}
