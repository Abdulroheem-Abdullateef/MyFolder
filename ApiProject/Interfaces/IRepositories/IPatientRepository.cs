using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;

namespace ApiProject.Interfaces.IRepositories
{
    public interface IPatientRepository
    {
         PatientDTO Create(Patient Patient);
         Patient Update (Patient Patient);
         Patient Get(int id);
         List<PatientDTO> GetAll();
         void Delete(Patient Patient);
         Patient GetByEmail(string Email);         
         bool ExistById(int Id);
         bool ExistByEmail(string Email);
         PatientDTO ReturnById(int Id); 
        // PatientDTO ViewAssignedDoctor(int MedicalRecordId);
    }
}