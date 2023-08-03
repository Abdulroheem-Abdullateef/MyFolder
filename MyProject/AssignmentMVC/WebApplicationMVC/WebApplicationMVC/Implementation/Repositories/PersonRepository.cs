using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplicationMVC.Context;
using WebApplicationMVC.Entities;
using WebApplicationMVC.Interfaces.Repositories;

namespace WebApplicationMVC.Implementation.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonRepository(ApplicationDbContext context )
        {
            _context = context;
        }

        public Person CreatePerson(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return person;
        }

        public void DeletePerson(Person id)
        {
            _context.Persons.Remove(id);
            _context.SaveChanges();
        }

        public Person Get(int id)
        {
            return _context.Persons.Find(id);
        }

        public IList<Person> GetAllPerson()
        {
            return _context.Persons
                .Include(s => s.CityPersons)
                .ThenInclude(p => p.City)
                .ToList();
        }

        public IList<Person> GetSelectedCities(IList<int> ids)
        {
            return _context.Persons.Where(p => ids.Contains(p.Id)).ToList();
        }

        public Person Update(int id, Person person)
        {
            _context.Persons.Find(id);
            _context.Persons.UpdateRange(person);
            _context.SaveChanges();
            return person;

        }
    }
}