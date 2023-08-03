using LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.DTOs
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string StudentPhoto { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<CourseDto> Courses { get; set; } = new List<CourseDto>();
        
    }

    public class CreateStudentRequestModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required(ErrorMessage = " Valid Email Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [DataType(DataType.Password)]
        [Compare("PassWord",ErrorMessage ="PassWord must be equal")]
        public string ConfirmPassWord { get; set; }
        public string StudentPhoto { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<int> CourseIds { get; set; } = new List<int>();
       
        
       

    }

    public class UpdateStudentRequestModel
    {
        [Required(ErrorMessage = " Valid Email Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address { get; set; }

        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public string StudentPhoto { get; set; }
       
    }

    public class LoginRequestModel
    {   
        [Required(ErrorMessage =" Valid Email Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

