using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Entities;

namespace TransportManagementSystem.Dtos
{
    public class DriverDto
    {
        public string LicenseNumberId { get; set; }
        public List<Trip> Trips { get; set; }

    }
    
    public class CreateRequestDriverModel
    {
        public string LicenseNumberId { get; set; }
      
    }

    public class UpdateRequestDriverModel
    {
        public string LicenseNumberId { get; set; }
     
    }
}
