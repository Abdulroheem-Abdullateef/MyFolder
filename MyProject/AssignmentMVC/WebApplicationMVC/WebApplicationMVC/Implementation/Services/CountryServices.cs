using System.Collections.Generic;
using System.Linq;
using WebApplicationMVC.DTO;
using WebApplicationMVC.Entities;
using WebApplicationMVC.Interfaces.Repositories;
using WebApplicationMVC.Interfaces.Services;

namespace WebApplicationMVC.Implementation.Services
{
    public class CountryServices : ICountryServices
    {

        private readonly ICountryRepository _countryRepository;
        
        public CountryServices(ICountryRepository countryRepository , ICityRepository cityRepository, IPersonRepository personRepository)
        {
            _countryRepository = countryRepository;
            
        }

        public bool CreateCountry(CreateCountryDto country)
        {
            var countrys = new Country
            {
                SurfaceArea = country.SurfaceArea,
                CountryName = country.CountryName,
                Independent = country.Independent,
                Population = country.Population,
                Region = country.Region,
                Citie = (List<City>)country.Cities
                
            };
            _countryRepository.CreateCountry(countrys);
            return true;


        }
        
        public void DeleteCountry(int id)
        {
            var person = _countryRepository.GetCountry(id);
            _countryRepository.Delete(person);
        }

        public IList<CountryDto> GetAllCountry()
        {
            var countries = _countryRepository.GetAllCountry().Select(country => new CountryDto
            {
                CountryName = country.CountryName,
                Independent = country.Independent,
                Population = country.Population,
                Region = country.Region,
                SurfaceArea = country.SurfaceArea,
                Id = country.Id,

                Cities = country.Citie.Select(city => new CityDto
                {
                    
                    CityName = city.CityName,
                    
                    Population = city.Population,
                    Country = city.Country,

                }).ToList(),

            }).ToList();

            foreach(var country in countries)
            {
                var i = 0;
                var cityArray = new string[country.Cities.Count];
                foreach(var city in country.Cities)
                {
                    cityArray[i] = city.CityName;
                    i++;
                }
                country.AllCityNames = string.Join(",", cityArray);
            }

            return countries;
        }

        public CountryDto GetCountry(int id)
        {
            var country = _countryRepository.GetCountry(id);
            return new CountryDto
            {
                CountryName = country.CountryName,
                SurfaceArea = country.SurfaceArea,
                Independent = country.Independent,
                Population = country.Population,
                Region = country.Region,
                Id = country.Id,
                Cities = country.Citie.Select(city => new CityDto
                {

                    CityName = city.CityName,

                    Population = city.Population,
                    Country = city.Country,

                }).ToList(),

            };               

        }

        public IList<CountryDto> GetSelectedCities(List<int> ids)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateCountry(int id, UpdateCountryDto country)
        {
            var countrys = _countryRepository.GetCountry(id);
            countrys.Population = country.Population;
            countrys.Region = country.Region;
            countrys.SurfaceArea = country.SurfaceArea;
            countrys.Independent = country.Independent;
            _countryRepository.Update(id, countrys);
            return true;

        }


    }
}