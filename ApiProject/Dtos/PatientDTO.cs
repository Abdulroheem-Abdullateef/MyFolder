using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ApiProject.Entities;
using ApiProject.Enums;
using Microsoft.AspNetCore.Http;

namespace ApiProject.Dtos
{
    public class PatientDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string PatientPhoto { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public Genotype Genotype { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<MedicalRecordDTO> MedicalRecord { get; set; } = new List<MedicalRecordDTO>();

    }
    public class CreatePatientModel
    {
        [Required(ErrorMessage = "This field is required to be filled")]
        [MaxLength(30), MinLength(5)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        [MaxLength(30), MinLength(5)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        public string Address { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        public string PatientPhoto { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        public BloodGroup BloodGroup { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        public Genotype Genotype { get; set; }
    }
    public class UpdatetePatientModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string PatientPhoto { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public Genotype Genotype { get; set; }
    }
}