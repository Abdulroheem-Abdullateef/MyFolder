using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.DTO;

namespace WebApplicationMVC.Interfaces.Services
{
    public interface ICityServices
    {
        bool CreateCity(CreateCityDto city);
        bool UpdateCity(int id, UpdateCityDto city);
        CityDto GetCity(int id);
        IList<CityDto> GetAllCity();
        void DeleteCity(int id);
    }
}
