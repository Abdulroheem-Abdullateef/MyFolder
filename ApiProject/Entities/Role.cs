using System.Collections.Generic;

namespace ApiProject.Entities
{
    public class Role : BaseEntity
    {
        public string RoleName {get; set;}
        public string Description {get; set;}
        public ICollection<UserRole> UserRole {get; set;} = new List<UserRole>();
    }
}