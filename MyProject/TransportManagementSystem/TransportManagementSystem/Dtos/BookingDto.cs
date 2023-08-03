using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Entities;
using TransportManagementSystem.Enums;

namespace TransportManagementSystem.Dtos
{
    public class BookingDto
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

    public class CreateRequestBookingModel
    {
        
        public string BookingReference { get; set; }

        public int NumberOfPassenger { get; set; }

        public Passenger Passenger { get; set; }

        public Trip Trip { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public bool IsPaid { get; set; }
    }

    public class UpdateRequestBookingModel
    {

        public string BookingReference { get; set; }

        public int NumberOfPassenger { get; set; }

        public Passenger Passenger { get; set; }

        public Trip Trip { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public bool IsPaid { get; set; }
    }
}
