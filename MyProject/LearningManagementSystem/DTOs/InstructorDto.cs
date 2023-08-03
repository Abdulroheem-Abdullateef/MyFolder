using LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.DTOs
{
    public class InstructorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CourseName { get; set; }
        public string PassWord { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }
        public string  DepartmentName { get; set; }
        public string Gender { get; set; }
        public IList<Student> Students { get; set; } = new List<Student>();
        
    }

    public class CreateInstructorRequestModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Input valid email")]
        public string Email { get; set; }

        [DataType(DataType.Password, ErrorMessage = "password must required")]
        public string PassWord { get; set; }
        [Compare("PassWord", ErrorMessage = "PassWord must be equal")]
        public string ConfirmPassWord { get; set; }
        [Required]
        public string Address { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [Required]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
       
        public string CourseName { get; set; }
        

        
    }

        public class UpdateInstructorRequestModel
        {

            [Required(ErrorMessage = " Valid Email Required")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

            [DataType(DataType.Password)]
            public string PassWord { get; set; }

            [DataType(DataType.PhoneNumber)]
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
        }

        public class InstuctorLoginRequestModel
        {
            [Required(ErrorMessage = " Valid Email Required")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
    
}

