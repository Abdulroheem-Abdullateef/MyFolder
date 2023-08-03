using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Interfaces.IPersonRepository
{
    public interface IPersonRepository
    {
        Person CreatePerson(Person person);
        Person UpdatePerson(Person person);
        Person  GetPerson(int id);
        List<Person> GetAllPerson();
        void DeletePerson(Person person);
    }
}
