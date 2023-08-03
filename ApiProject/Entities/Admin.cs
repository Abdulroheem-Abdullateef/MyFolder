using System;
using ApiProject.Enums;

namespace ApiProject.Entities
{
    public class Admin : BaseEntity
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        //public string Password {get; set;}
        public Gender Gender {get; set;}
        public string AdminPhoto {get; set;}
        public string Address {get; set;}
        public DateTime DateOfBirth {get; set;}        
        public string PhoneNumber {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}
    }
}