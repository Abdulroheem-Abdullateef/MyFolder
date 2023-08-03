using APIProject.Interfaces.IPersonRepository;
using APIProject.Interfaces.IPersonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Implementations.Services
{
    public class PersonService : IPersonServices
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public bool CreatePerson(CreatePersonRequestModel model)
        {
            var person = new Person
            {

                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                Email = model.Email,
            };
            _personRepository.CreatePerson(person);
            return true;
        }

        public void DeletePerson(int id)
        {
            var person = _personRepository.GetPerson(id);
            _personRepository.DeletePerson(person);
        }

        public IList<PersonDto> GetAllPerson()
        {
            return _personRepository.GetAllPerson().Select(p => new PersonDto
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Email = p.Email,
                Address = p.Email,
            }).ToList();
        }

        public PersonDto GetPerson(int id)
        {
            var person = _personRepository.GetPerson(id);
            return new PersonDto
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Email = person.Email,
                Address = person.Address

            };
        }

        public bool UpdatePerson(int id, UpdatePersonRequestModel model)
        {
            var person = _personRepository.GetPerson(id);
            person.Address = model.Address;
            person.FirstName = model.FirstName;
            person.LastName = model.LastName;
            _personRepository.UpdatePerson(person);
            return true;
        }
    }
}
