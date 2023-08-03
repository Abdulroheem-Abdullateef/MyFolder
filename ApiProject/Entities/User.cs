using System.Collections.Generic;

namespace ApiProject.Entities
{
    public class User : BaseEntity
    {
        //public string UserName {get; set;}
        //public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}        
        public Doctor Doctors {get; set;}       
        public Patient Patients {get; set;}        
        public Admin Admin {get; set;}
        public Hospital Hospital {get; set;}
        public ICollection<UserRole> UserRole {get; set;} = new List<UserRole>(); 
    }
}