using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Dtos;
using TransportManagementSystem.Entities;

namespace TransportManagementSystem.Interfaces.IServices
{
    public interface IBusServices
    {
        public bool CreateBus(CreateRequestBusModel bus);
        public BusDto GetBusById(int id);
        public Bus GetBusId(int id);
        public BusDto GetBusByRegistrationNumber(string registrationnumber);
        public bool DeleteBus(string registrationnumber);
        public List<BusDto> GetAllBuses();
        public bool UpDate(UpdateRequestBusModel bus, string registrationnuumber);



    }
}
