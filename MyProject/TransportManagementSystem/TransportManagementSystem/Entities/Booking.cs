using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Enums;

namespace TransportManagementSystem.Entities
{
    public class Booking
    {
        public int Id { get; set; }

        public string BookingReference { get; set; }

        public int NumberOfPassenger { get; set; }

        public int PassengerId { get; set; }

        public Passenger Passenger { get; set; }

        public int TripId { get; set; }

        public Trip Trip { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public bool IsPaid { get; set; }
    }
}
