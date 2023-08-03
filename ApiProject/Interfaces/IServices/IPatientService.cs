using System.Collections.Generic;
using ApiProject.Dtos;

namespace ApiProject.Interfaces.IServices
{
    public interface IPatientService
    {
        BaseResponse<PatientDTO> Register (CreatePatientModel model);
        BaseResponse<PatientDTO> Update (UpdatetePatientModel model, int Id);
        BaseResponse<bool> Delete (int id);
        BaseResponse<PatientDTO> GetByEmail(string email);
        BaseResponse<PatientDTO> ReturnById(int id);
        BaseResponse<List<PatientDTO>> GetAll();
        // BaseResponse<MedicalRecordDTO> GetByPatientId(int patientId);
    }
}