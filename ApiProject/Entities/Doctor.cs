using System;
using System.Collections.Generic;
using ApiProject.Enums;

namespace ApiProject.Entities
{
    public class Doctor : BaseEntity
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public AreaOfSpec AreaOfSpec {get; set;}
        public Gender Gender {get; set;}
        public string Address {get; set;}
        public RegistrationStatus RegistrationStatus {get; set;}
        public string DoctorPhoto {get; set;}
        public string DoctorCertificate {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string PhoneNumber {get; set;}
        public string NextOfKin {get; set;}        
        public string StaffNumber {get; set;}
        public bool AvailabilityStatus {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}       
        public ICollection<DoctorMedicalRecord> DoctorMedicalRecords {get; set;} = new List<DoctorMedicalRecord>();      
    }
}