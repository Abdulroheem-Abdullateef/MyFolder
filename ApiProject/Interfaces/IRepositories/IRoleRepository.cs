using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;

namespace ApiProject.Interfaces.IRepositories
{
    public interface IRoleRepository
    {
        RoleDTO Create(Role Role);
        RoleDTO Update(Role Role);
        Role Get(int id);
        List<RoleDTO> GetAll();
        void Delete(Role Role);
        bool ExistByName(string name);
        bool ExistById(int Id);
        Role GetRoleByName(string name);
        RoleDTO ReturnById(int Id);

    }
}