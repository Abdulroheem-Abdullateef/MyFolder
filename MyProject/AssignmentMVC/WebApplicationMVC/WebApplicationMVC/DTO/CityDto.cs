using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.Entities;

namespace WebApplicationMVC.DTO
{
    public class CityDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public string Population { get; set; }
        public string CityCode { get; set; }
        public List<Person> Person { get; set; } = new List<Person>();
        public Country Country { get; set; }


    }

    public class CreateCityDto
    {
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public string Population { get; set; }
        public string CityCode { get; set; }
        
    }

    public class UpdateCityDto
    {
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public string Population { get; set; }
        public string CityCode { get; set; }
        

    }
}
