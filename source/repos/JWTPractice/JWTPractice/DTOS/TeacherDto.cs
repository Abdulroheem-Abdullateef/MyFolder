using JWTPractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTPractice.DTOS
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public IList<Student> Students { get; set; }
    }

    public class LoginResponseDtos : TeacherDto
    {
        public string Token { get; set; }
    }
    public class CreateTeacherRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
       
    }

    public class UpdateTeacherRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
    }
    public class LoginTeacherDto
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
