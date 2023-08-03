using System.Collections.Generic;
using ApiProject.Dtos;
namespace ApiProject.Interfaces.IServices
{
    public interface IMedicalRecordService
    {
        BaseResponse<MedicalRecordDTO> Register(int patientId, CreateMedicalRecordModel model);
        BaseResponse<bool> Delete(int id);
        BaseResponse<MedicalRecordDTO> ReturnById(int id);
        BaseResponse<List<MedicalRecordDTO>> GetAll();
        BaseResponse<IList<MedicalRecordDTO>> GetMedicalRecords();
        BaseResponse<MedicalRecordDTO> AssignPatientToDoctor(int MedicalRecordId, AssignDoctorRequestModel model);
        BaseResponse<MedicalRecordDTO> AssignPatientToHospital(int MedicalRecordId, AssignHospitalRequestModel request);
        BaseResponse<MedicalRecordDTO> TreatedRefferedCases(int MedicalRecordId, int DoctorId, TreatedRefferedPatientCasesModel model);
        BaseResponse<List<MedicalRecordDTO>> RefferalNeededCases();
        BaseResponse<List<MedicalRecordDTO>> RefferalNotNeededCases();
        BaseResponse<List<MedicalRecordDTO>> MedicalCases(int DoctorId);
        BaseResponse<List<MedicalRecordDTO>> InitializedMedicalCases();
        BaseResponse<List<MedicalRecordDTO>> TreatedMedicalCases();
        BaseResponse<List<MedicalRecordDTO>> AssignedMedicalCases();
        BaseResponse<MedicalRecordDTO> GetByPatientId(int patientId);
        BaseResponse<List<MedicalRecordDTO>> GetAllByPatientId(int patientId);
        BaseResponse<List<MedicalRecordDTO>> AssignedMedicalCases(int DoctorId);
        BaseResponse<List<MedicalRecordDTO>> TreatedMedicalCases(int DoctorId);
        BaseResponse<List<MedicalRecordDTO>> AssignedHospital(int HospitalId);
        BaseResponse<MedicalRecordDTO> ViewAssignedDoctor(int DoctorId);
        BaseResponse<MedicalRecordDTO> ViewAssignedPatient(int PatientId);
        BaseResponse<MedicalRecordDTO> GetComplainByPatientId(int PatientId);
    }
}