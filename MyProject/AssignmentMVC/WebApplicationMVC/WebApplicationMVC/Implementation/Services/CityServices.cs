using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.DTO;
using WebApplicationMVC.Entities;
using WebApplicationMVC.Interfaces.Repositories;
using WebApplicationMVC.Interfaces.Services;

namespace WebApplicationMVC.Implementation.Services
{
    public class CityServices : ICityServices
    {
        private readonly ICityRepository _cityRepository;
        

        public CityServices(ICityRepository cityServices)
        {
            _cityRepository = cityServices;
           

        }

        public bool CreateCity(CreateCityDto city)
        {
            var citys = new City
            {
                CityCode = city.CityCode,
                CityName = city.CityName,
                Population = city.Population,
                CountryId = city.CountryId,
                
            };
            _cityRepository.CreateCity(citys);
            return true;
        }

        public void DeleteCity(int id)
        {
            var citys = _cityRepository.GetCity(id);
            _cityRepository.Delete(citys);

        }

        public IList<CityDto> GetAllCity()
        {
            return _cityRepository.GetAllCity().Select(city => new CityDto
            {
                CityCode = city.CityCode,
                CityName = city.CityName,
                Population = city.Population,
                Id = city.Id
                
            }).ToList();
        }

        public CityDto GetCity(int id)
        {
            var citys = _cityRepository.GetCity(id);
            return new CityDto
            {
                CityCode = citys.CityCode,
                CityName = citys.CityName,
                Population = citys.Population,
                Id = citys.Id,
                
            };

        }

        public bool UpdateCity(int id, UpdateCityDto city)
        {
            var citys = _cityRepository.GetCity(id);
            citys.Population = city.Population;
            citys.CityName = city.CityName;
            citys.CityCode = city.CityCode;
            _cityRepository.Update(id, citys);
            
            return true;

        }
    }
}
