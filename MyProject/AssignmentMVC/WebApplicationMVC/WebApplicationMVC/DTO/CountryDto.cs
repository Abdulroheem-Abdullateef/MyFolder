using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC.DTO
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }
        public string Region { get; set; }
        public int Independent { get; set; }
        public int SurfaceArea { get; set; }
        public string AllCityNames { get; set; }
        public List<CityDto> Cities { get; set; } = new List<CityDto>();

    }

    public class CreateCountryDto
    {
        
        public string CountryName { get; set; }
        public int Population { get; set; }
        public string Region { get; set; }
        public int Independent { get; set; }
        public int SurfaceArea { get; set; }
       public  IList<int> Cities { get; set; }
       



    }

    public class UpdateCountryDto
    {
        public string CountryName { get; set; }
        public int Population { get; set; }
        public string Region { get; set; }
        public int Independent { get; set; }
        public int SurfaceArea { get; set; }
        public IList<PersonDto> People { get; set; } = new List<PersonDto>();
        public IList<CityDto> Cities { get; set; } = new List<CityDto>();

    }
}
