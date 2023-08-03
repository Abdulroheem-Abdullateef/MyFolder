using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.Entities;

namespace WebApplicationMVC.Interfaces.Repositories
{
    public interface IPersonRepository
    {
        Person CreatePerson(Person person);
        Person Update(int id, Person person);
        Person Get(int id);
        IList<Person> GetAllPerson();
        void DeletePerson(Person id);
        IList<Person> GetSelectedCities(IList<int> ids);
    }
}