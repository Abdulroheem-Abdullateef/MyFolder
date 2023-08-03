using APIProject.Context;
using APIProject.Interfaces.IPersonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Implementations.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationContext _Context;

        public PersonRepository(ApplicationContext context)
        {
            _Context = context;
        }
        public Person CreatePerson(Person person)
        {
            _Context.Persons.Add(person);
            _Context.SaveChanges();
            return person;
        }

        public void DeletePerson(Person person)
        {
            _Context.Persons.Remove(person);
            _Context.SaveChanges();

        }

        public List<Person> GetAllPerson()
        {
           return _Context.Persons.ToList();
        }

        public Person GetPerson(int id)
        {
            return _Context.Persons.Find(id);

        }

        public Person UpdatePerson(Person person)
        {
            _Context.Persons.Update(person);
            _Context.SaveChanges();
            return person;

        }
    }
}
