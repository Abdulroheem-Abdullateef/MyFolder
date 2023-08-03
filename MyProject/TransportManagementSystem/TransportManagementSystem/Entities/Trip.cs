using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Enums;

namespace TransportManagementSystem.Entities
{
    public class Trip
    {
        public int Id { get; set; }
        public string TripReference { get; set; }
        public Location TakeOfPoint { get; set; }
        public Location Distination { get; set; }
        public DateTime TakeOfTime { get; set; }
        public double ExpectedDoration { get; set; }
        public int NumberOfStopOver { get; set; }
        public TripStatus TripStatus { get; set; }
        public double Price { get; set; }
        public Bus Bus { get; set; }
        public Driver Driver { get; set; }
        public int DriverId { get; set; }
        public int BusId { get; set; }
         public List<Booking> Bookings { get; set; }
    }
}
