using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportManagementSystem.Entities
{
    public class Passenger : User
    {
        public List<Booking> Bookings { get; set; }
    }
}
