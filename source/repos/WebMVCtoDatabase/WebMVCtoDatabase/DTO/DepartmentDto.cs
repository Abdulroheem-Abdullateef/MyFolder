
using MVCConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.DTO
{
    public class DepartmentDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentCode { get; set; }
        public List<StudentDto> Students { get; set; } = new List<StudentDto>();

    }

    public class CreateRequestDepartmentDto
    {
        public string Name { get; set; }
        public string DepartmentCode { get; set; }
    

    }

    public class UpdateDepartmentDto
    {
        public string Name { get; set; }
        public string DepartmentCode { get; set; }

    }

}
