using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportManagementSystem.Entities
{
    public class Driver : User
    {
        public string LicenseNumberId { get; set; }
        public List<Trip> Trips { get; set; }
    }
}
