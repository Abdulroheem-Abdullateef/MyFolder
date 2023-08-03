using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Interfaces.IRepositories;

namespace ApiProject.Interfaces.IServices
{
    public interface IHospitalService 
    {
        BaseResponse<HospitalDTO> Register (CreateHospitalModel model);
        BaseResponse<HospitalDTO> Update (UpdateHospitalModel model, int Id);
        BaseResponse<bool> Delete (int id);       
        BaseResponse<HospitalDTO> ReturnById(int id);
        BaseResponse<List<HospitalDTO>> GetAll();
    }
}