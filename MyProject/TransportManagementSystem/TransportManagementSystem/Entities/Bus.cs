using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Enums;

namespace TransportManagementSystem.Entities
{
    public  class Bus
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string EngineNumber { get; set; }
        public string PlateNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public int Capacity { get; set; }
        public BusClass BusClass { get; set; }
        public bool AvailabilityStatus { get; set; }
        public List<Trip> Trips { get; set; } 


    }
}
