using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Entities;
using TransportManagementSystem.Enums;

namespace TransportManagementSystem.Dtos
{
    public class TripDto
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
        public string BusModel { get; set; }
        public Entities.Driver Driver { get; set; }
        public string FullName { get; set;  }
        public int DriverId { get; set; }
        public int BusId { get; set; }
        public List<Booking> Bookings { get; set; }
    }

    public class CreateRequestTripModel
    {
        public Location TakeOfPoint { get; set; }
        public Location Distination { get; set; }
        public TripStatus TripStatus { get; set; }
        public DateTime TakeOfTime { get; set; }
        public decimal Price { get; set; }
        public string DriverLiceseNumber { get; set; }
        public DateTime LandingTime { get; set; }


    }

    public class UpdateRequestTripModel
    {
        public DateTime TakeOfTime { get; set; }
        public DateTime LandingTime { get; set; }
        public decimal Price { get; set; }
        public Location TakeOfPoint { get; set; }
        public Location Distination { get; set; }
        public int DriverId { get; set; }
        public int BusId { get; set; }

    }
}
