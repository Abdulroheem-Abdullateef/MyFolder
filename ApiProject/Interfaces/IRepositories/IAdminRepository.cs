using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;

namespace ApiProject.Interfaces.IRepositories
{
    public interface IAdminRepository
    {
         AdminDTO Create(Admin Admin);
         Admin Update (Admin Admin);
         Admin Get(int id);
         Admin GetByEmail(string Email);
         List<AdminDTO> GetAll();
         void Delete(Admin Admin);
         bool ExistById(int Id);
         bool ExistByEmail(string Email);
         AdminDTO ReturnById(int Id);
    }
}