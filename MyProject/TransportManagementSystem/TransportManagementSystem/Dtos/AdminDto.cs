using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportManagementSystem.Dtos
{
    public class AdminDto
    {
         public int StaffId { get; set; }
    }

    public class CreateRequestAdminModel
    {
         public int StaffId { get; set; }
    }

    public class UpdateRequestAdminModel
    {
        public int StaffId { get; set; }
    }
}
