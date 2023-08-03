using System.Collections.Generic;
using ApiProject.Entities;

namespace ApiProject.Dtos
{
    public class RoleDTO
    {
        public int Id {get; set;}
        public string RoleName {get; set;}
        public string Description {get; set;}
        public ICollection<UserDTO> UserRole {get; set;} = new List<UserDTO>();
    }
    public class CreateRoleModel
    {
        public string RoleName {get; set;}
        public string Description {get; set;}
    }
    public class UpdateRoleModel
    {
        public string RoleName {get; set;}
        public string Description {get; set;}
    }
}