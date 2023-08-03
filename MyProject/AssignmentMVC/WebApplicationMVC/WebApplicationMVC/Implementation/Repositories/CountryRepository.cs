using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.Context;
using WebApplicationMVC.Entities;
using WebApplicationMVC.Interfaces.Repositories;

namespace WebApplicationMVC.Implementation.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Country CreateCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
            return country;


        }

        public void Delete(Country id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public IList<Country> GetAllCountry()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountry(int id)
        {
            return _context.Countries.SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<Country> GetSelectedCountry(IList<int> ids)
        {
            return _context.Countries.Where(a => ids.Contains(a.Id)).ToList();
        }

        public Country Update(int id, Country country)
        {
            _context.Countries.Find(id);
             _context.Countries.Update(country);
            _context.SaveChanges();
            return country;


        }
    } 
}
