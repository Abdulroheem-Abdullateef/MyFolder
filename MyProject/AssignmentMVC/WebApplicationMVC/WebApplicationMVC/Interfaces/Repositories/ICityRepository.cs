using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.Entities;

namespace WebApplicationMVC.Interfaces.Repositories
{
    public interface ICityRepository
    {
        City CreateCity(City person);
        City Update(int id, City person);
        City GetCity(int id);
        IList<City> GetAllCity();
        void Delete(City id);
        IEnumerable<City> GetSelectedCities(IList<int> ids);
    }
}
