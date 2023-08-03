using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.Context;
using WebApplicationMVC.Entities;
using WebApplicationMVC.Interfaces.Repositories;

namespace WebApplicationMVC.Implementation.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _context;

        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public City CreateCity(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
            return city;
        }

        public void Delete(City id)
        {
            _context.Cities.Remove(id);
            _context.SaveChanges();

        }

        public IList<City> GetAllCity()
        {
            return _context.Cities.ToList();
        }

        public City GetCity(int id)
        {
            return _context.Cities.Find(id);

        }

        public IEnumerable<City> GetSelectedCities(IList<int> ids)
        {
            return _context.Cities.Where(a => ids.Contains(a.Id)).ToList();
        }

        public City Update(int id, City city)
        {
            _context.Cities.Find(id);
            _context.Cities.Update(city);
            _context.SaveChanges();
            return city;
        }
    }
}
