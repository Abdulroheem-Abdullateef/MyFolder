using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.DTO
{
    public class StudentDto
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DepartmentId { get; set; }
        public string Department { get; set; }

    }

    public class CreateStudentDto
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Department { get; set; }
    }

    public class UpdateStudentDto
    {
        public string Email { get; set; }
        
    }


}
