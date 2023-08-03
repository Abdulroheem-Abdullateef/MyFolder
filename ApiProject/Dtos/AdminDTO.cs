using System;
using System.ComponentModel.DataAnnotations;
using ApiProject.Entities;
using ApiProject.Enums;
using Microsoft.AspNetCore.Http;

namespace ApiProject.Dtos
{
    public class AdminDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //public string Password {get; set;}
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string AdminPhoto { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        // public int UserId {get; set;}
        // public User User {get; set;}
    }
    public class CreateAdminModel
    {
        [Required(ErrorMessage = "This field is required to be filled")]        
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]        
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]        
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]        
        public string Address { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]        
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]        
        public string AdminPhoto { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class UpdateAdminModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string AdminPhoto { get; set; }
    }
}