using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Entities;

namespace TransportManagementSystem.Dtos
{
   public class PassengerDto
   {
        public List<Booking> Bookings { get; set; }
   }

    public class CreateRequestPassengerModel
    {
        public List<Booking> Bookings { get; set; }
    }
    public class UpdateRequestPassengerModel
    {
        public List<Booking> Bookings { get; set; }
    }
}
