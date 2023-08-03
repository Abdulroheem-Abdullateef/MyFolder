using System;
using System.Collections.Generic;
using ApiProject.Enums;

namespace ApiProject.Entities
{
    public class Patient : BaseEntity
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public Gender Gender {get; set;}
        public string Address {get; set;}
        public string PatientPhoto {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string PhoneNumber {get; set;}
        public BloodGroup BloodGroup {get; set;}
        public Genotype Genotype {get; set;}        
        public int UserId {get; set;}
        public User User {get; set;}       
        public List<MedicalRecord> MedicalRecord {get; set; } = new List<MedicalRecord>();               
    }
}