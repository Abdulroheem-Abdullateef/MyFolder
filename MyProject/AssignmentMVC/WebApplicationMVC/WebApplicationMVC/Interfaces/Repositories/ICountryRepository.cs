using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.Entities;

namespace WebApplicationMVC.Interfaces.Repositories
{
    public interface ICountryRepository
    {
        Country CreateCountry(Country person);
        Country Update(int id, Country person);
        Country GetCountry(int id);
        IList<Country> GetAllCountry();
        void Delete(Country id);
        IEnumerable<Country> GetSelectedCountry(IList<int> ids);

    }
}
