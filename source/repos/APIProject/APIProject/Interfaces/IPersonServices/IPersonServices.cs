using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Interfaces.IPersonServices
{
    public interface IPersonServices
    {
        bool CreatePerson(CreatePersonRequestModel model);
        bool UpdatePerson(int id, UpdatePersonRequestModel model);
        PersonDto GetPerson(int id);
        IList<PersonDto> GetAllPerson();
        void DeletePerson(int id);
    }
}
