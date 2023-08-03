using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;

namespace ApiProject.Interfaces.IRepositories
{
    public interface IMedicalRecordRepository
    {
         MedicalRecordDTO Create(MedicalRecord MedicalRecord);
         MedicalRecord Update (MedicalRecord MedicalRecord);
         MedicalRecord Get(int id);
         List<MedicalRecordDTO> GetAll();
         void Delete(MedicalRecord MedicalRecord);
         MedicalRecordDTO ReturnById(int Id);
         bool ExistById(int id);
         IEnumerable<MedicalRecord> GetSelectedMedicalrecords(IList<int> ids);
         List<MedicalRecordDTO> RefferalNeededCases();
         List<MedicalRecordDTO> RefferalNotNeededCases();         
         List<MedicalRecordDTO> InitializedMedicalCases();     
         List<MedicalRecordDTO> AssignedMedicalCases();      
         List<MedicalRecordDTO> MedicalCases(int DoctorId);
         List<MedicalRecordDTO> TreatedMedicalCases();
         MedicalRecord GetByPatientId(int patientId); 
         List<MedicalRecordDTO> GetAllByPatientId(int patientId);
        List<MedicalRecordDTO> AssignedMedicalCases(int DoctorId);
        List<MedicalRecordDTO> TreatedMedicalCases(int DoctorId);
        List<MedicalRecordDTO> AssignedHospital(int HospitalId);
        MedicalRecordDTO GetComplainByPatientId(int PatientId);
    }
}