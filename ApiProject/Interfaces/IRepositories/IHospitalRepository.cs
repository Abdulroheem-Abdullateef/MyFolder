using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;

namespace ApiProject.Interfaces.IRepositories
{
    public interface IHospitalRepository
    {
         HospitalDTO Create(Hospital Hospital);
         Hospital Update (Hospital Hospital);
         Hospital Get(int id);
         List<HospitalDTO> GetAll();
         void Delete(Hospital Hospital);
         HospitalDTO ReturnById(int Id);   
         bool ExistByName(string name);
         bool ExistById(int id);
         Hospital GetByMail(string email);
         bool ExistByMail(string Email);
    }
}