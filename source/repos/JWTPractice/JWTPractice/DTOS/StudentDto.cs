using JWTPractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTPractice.DTOS
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }

    public class LoginResponseDto : StudentDto
    {
        public string Token { get; set; }
    }

    public class CreateStudentRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }

    public class UpdateStudentRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
    }

    public class LoginStudentDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }


}
