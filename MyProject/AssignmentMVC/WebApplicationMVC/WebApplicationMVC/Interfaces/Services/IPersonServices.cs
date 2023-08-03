using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.DTO;

namespace WebApplicationMVC.Interfaces.Services
{
    public interface IPersonServices
    {
        bool CreatePerson(CreatePersonDto person);
        bool Update(int id, UpdatePersonDto person);
        PersonDto GetPerson(int id);
        IList<PersonDto> GetAllPerson();
        void Delete(int id);
        

    }
}
