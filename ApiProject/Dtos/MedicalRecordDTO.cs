using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ApiProject.Entities;
using ApiProject.Enums;

namespace ApiProject.Dtos
{
    public class MedicalRecordDTO
    {
        public int Id { get; set; }
        public string Diagnosis { get; set; }
        public string Prescription { get; set; }
        public DateTime? DateVisited { get; set; }
        public string PatientComplain { get; set; }
        public string DoctorReport { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientPhoto {get; set;}
        public int? DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorPhoto {get; set;}
        public AreaOfSpec DoctorAreaOfSpec {get; set;}
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public MedicalRecordStatus MedicalRecordStatus {get; set;}
        public Refferral Refferral { get; set; }
        public List<DoctorDTO> Doctors { get; set; } = new List<DoctorDTO>();
    }
    public class CreateMedicalRecordModel
    {
        [Required]
        public string PatientComplain { get; set; }
        public DateTime? DateVisited { get; set; }

    }
    public class AssignDoctorRequestModel
    {
        public int DoctorId { get; set; }
        //public int PatientId { get; set; }

    }
    public class TreatedRefferedPatientCasesModel
    {
        //public int DoctorId { get; set; }
        [Required]
        public string Diagnosis { get; set; }
        [Required]
        public string Prescription { get; set; }
        [Required]
        public string DoctorReport { get; set; }
        public Refferral Refferral { get; set; }
    }
    public class AssignHospitalRequestModel
    {
        public int HospitalId { get; set; }
    }
}