using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ApiProject.Entities;
using ApiProject.Enums;
using Microsoft.AspNetCore.Http;

namespace ApiProject.Dtos
{
    public class DoctorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public AreaOfSpec AreaOfSpec { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string DoctorPhoto { get; set; }
        public string DoctorCertificate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public bool AvailabilityStatus { get; set; }
        public string NextOfKin { get; set; }
        public string StaffNumber { get; set; }
        public List<MedicalRecordDTO> MedicalRecords { get; set; } = new List<MedicalRecordDTO>();
    }
    public class CreateDoctorModel
    {
        [Required(ErrorMessage = "This field is required to be filled")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required to be filled")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public AreaOfSpec AreaOfSpec { get; set; }
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        public string Address { get; set; }
        public bool AvailabilityStatus { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        public string DoctorPhoto { get; set; }
        public string DoctorCertificate { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        public string NextOfKin { get; set; }
        public string StaffNumber { get; set; }
    }
    public class UpdateDoctorModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public AreaOfSpec AreaOfSpec { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public RegistrationStatus RegistrationStatus {get; set;}
        public string DoctorPhoto { get; set; }
        public string DoctorCertificate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string NextOfKin { get; set; }
        public string StaffNumber { get; set; }
    }
}