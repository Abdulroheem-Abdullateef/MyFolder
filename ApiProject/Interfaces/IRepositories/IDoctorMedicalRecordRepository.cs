using ApiProject.Dtos;

namespace ApiProject.Interfaces.IRepositories
{
    public interface IDoctorMedicalRecordRepository
    {
           MedicalRecordDTO ViewAssignedPatient(int PatientId);
          MedicalRecordDTO ViewAssignedDoctor(int DoctorId);
    }
}