using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonAddress { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string PersonPhoto { get; set; }
        public int CityId { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<CityPerson> CityPersons { get; set; } = new List<CityPerson>();

    }
}
