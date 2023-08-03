using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC.Entities
{
    public class City
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public string Population { get; set; }
        public string CityCode { get; set; }
        public ICollection<CityPerson> CityPersons { get; set; } = new List<CityPerson>();
        public Country Country { get; set; } 


    }
}
