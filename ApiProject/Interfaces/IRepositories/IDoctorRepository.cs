using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;

namespace ApiProject.Interfaces.IRepositories
{
    public interface IDoctorRepository
    {
        DoctorDTO Create(Doctor Doctor);
        Doctor Update(Doctor Doctor);
        Doctor Get(int id);
        List<DoctorDTO> GetAllApprovedDoctors();
        void Delete(Doctor Doctor);
        Doctor GetByEmail(string Email);
        bool ExistById(int Id);
        bool ExistByEmail(string Email);
        DoctorDTO ReturnById(int Id);
        List<DoctorDTO> GetAllPharmacologist();
        List<DoctorDTO> GetAllDentists();
        List<DoctorDTO> GetAllOpticians();
        List<DoctorDTO> GetAllPadaestrics();
        List<DoctorDTO> GetAllHaemotologistics();
        List<DoctorDTO> GetAllOrthopaedics();
        List<DoctorDTO> GetAllGynaeocologists();   
        List<DoctorDTO> GetAllAvailableDoctors();
        List<DoctorDTO> GetAllInitializedDoctors();
       // DoctorDTO ViewAssignedPatient(int MedicalRecordId);
    }
}