using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.DTO;

namespace WebApplicationMVC.Interfaces.Services
{
    public interface ICountryServices
    {
        bool CreateCountry(CreateCountryDto country);
        bool UpdateCountry(int id, UpdateCountryDto country);
        CountryDto GetCountry(int id);
        IList<CountryDto> GetAllCountry();
        void DeleteCountry(int id);
   
    }
}
