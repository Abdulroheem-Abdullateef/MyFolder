using System.Collections.Generic;

namespace ApiProject.Entities
{
    public class Hospital : BaseEntity
    {
        public string Name {get; set;}
        public string Address {get; set;}
        public string Hospitalmail {get; set;}
        public string Password {get; set;}
        public int UserId {get; set;}
        public User User {get; set;}
        public List<MedicalRecord> MedicalRecords {get; set;} = new List<MedicalRecord>();
    }
}