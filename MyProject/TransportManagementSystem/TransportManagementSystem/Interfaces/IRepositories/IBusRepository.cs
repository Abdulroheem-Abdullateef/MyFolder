using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Dtos;
using TransportManagementSystem.Entities;

namespace TransportManagementSystem.Interfaces.IRepositories
{
    public interface IBusRepository
    {
        public bool CreateBus(Bus bus);
        public BusDto GetBusById(int id);
        public Bus GetBusId(int id);
        public BusDto GetBusByRegistrationNumber(string registrationnumber);
        public bool DeleteBus(Bus bus);
        public List<BusDto> GetAllBuses();
        public bool UpDate(Bus bus);
        public Bus ReturnGetBusByRegistrationNumber(string registrationnumber);

    }
}
