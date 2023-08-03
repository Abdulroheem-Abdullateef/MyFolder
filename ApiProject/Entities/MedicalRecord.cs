using System;
using System.Collections.Generic;
using ApiProject.Enums;

namespace ApiProject.Entities
{
    public class MedicalRecord : BaseEntity
    {
        public string Diagnosis {get; set;}
        public string Prescription {get; set;}
        public DateTime? DateVisited {get; set;}
        public string PatientComplain {get; set;}
        public string DoctorReport {get; set;}
        public int PatientId {get; set;}
        public Patient Patient {get; set;}
        public int? DoctorId {get; set;}
        public Doctor Doctor {get; set;}
        public Refferral Refferral {get; set;}
        public int? HospitalId {get; set;}
        public Hospital Hospital {get; set;}
        public MedicalRecordStatus MedicalRecordStatus {get; set;}
        public ICollection<DoctorMedicalRecord> DoctorMedicalRecords {get; set;} = new List<DoctorMedicalRecord>(); 
    }
}