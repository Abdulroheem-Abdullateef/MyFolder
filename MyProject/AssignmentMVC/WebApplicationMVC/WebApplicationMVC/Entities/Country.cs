using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }
        public string Region { get; set; }
        public int Independent { get; set; }
        public int SurfaceArea { get; set; }
        public string CountryPhoto { get; set; }
        public List<City> Citie { get; set; } = new List<City>();


    }
}
