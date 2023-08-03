using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Interfaces.IRepositories;

namespace ApiProject.Interfaces.IServices
{
    public interface IDoctorService
    {
        BaseResponse<DoctorDTO> Register(CreateDoctorModel model);
        BaseResponse<DoctorDTO> Update(UpdateDoctorModel model, int Id);
        BaseResponse<bool> Delete(int id);
        BaseResponse<DoctorDTO> GetByEmail(string email);
        BaseResponse<DoctorDTO> ReturnById(int id);
        BaseResponse<List<DoctorDTO>> GetAllApprovedDoctors();
        BaseResponse<List<DoctorDTO>> GetAllPharmacologist();
        BaseResponse<List<DoctorDTO>> GetAllDentists();
        BaseResponse<List<DoctorDTO>> GetAllOpticians();
        BaseResponse<List<DoctorDTO>> GetAllPadaestrics();
        BaseResponse<List<DoctorDTO>> GetAllHaemotologistics();
        BaseResponse<List<DoctorDTO>> GetAllOrthopaedics();
        BaseResponse<List<DoctorDTO>> GetAllGynaeocologists();
        BaseResponse<List<DoctorDTO>> GetAllAvailableDoctors();
        BaseResponse<List<DoctorDTO>> GetAllInitializedDoctors();
        BaseResponse<DoctorDTO> ApproveDoctor(int DoctorId);
        BaseResponse<bool> DissaprovedDoctors(int DoctorId);
    }
}