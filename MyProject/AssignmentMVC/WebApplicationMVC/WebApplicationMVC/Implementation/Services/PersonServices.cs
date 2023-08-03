using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.DTO;
using WebApplicationMVC.Entities;
using WebApplicationMVC.Interfaces.Repositories;
using WebApplicationMVC.Interfaces.Services;

namespace WebApplicationMVC.Implementation.Services
{
    public class PersonServices : IPersonServices
    {
        private readonly IPersonRepository _personRepository;
        private readonly ICityRepository _cityRepository;



        public PersonServices(IPersonRepository personServices, ICityRepository cityServices) 
        { 
            _personRepository = personServices;
            _cityRepository = cityServices;
            
        }
        public bool CreatePerson(CreatePersonDto person)
        {
            var persons = new Person
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Email = person.Email,
                PassWord = person.PassWord,
                PersonAddress = person.PersonAddress,
                PhoneNumber = person.PhoneNumber,
                CityId = person.CityId,
                PersonPhoto = person.PersonPhoto,
            };

            var cities = _cityRepository.GetSelectedCities(person.Cities);

            foreach (var city in cities)
            {
                var cityPerson = new CityPerson
                {
                   CityId = city.Id,
                   City = city,
                   Person = persons,
                   PersonId = persons.Id
                   

                };
                persons.CityPersons.Add(cityPerson);
            }

            _personRepository.CreatePerson(persons);
            
            return true;
        }

        public void Delete(int id)
        {
            var person = _personRepository.Get(id);
            _personRepository.DeletePerson(person);
        }

        public IList<PersonDto> GetAllPerson()
        {
            return _personRepository.GetAllPerson().Select(person=> new PersonDto
            {
                Id = person.Id,
                Email = person.Email,
                FirstName = person.FirstName,
                LastName = person.LastName,
                PersonAddress = person.PersonAddress,
                PhoneNumber = person.PhoneNumber,
                PassWord = person.PassWord,
               PersonPhoto = person.PersonPhoto
            }).ToList();
        }

        public PersonDto GetPerson(int id)
        {
            var person = _personRepository.Get(id);
            return new PersonDto
            {
                Id = person.Id,
                Email = person.Email,
                FirstName = person.FirstName,
                LastName = person.LastName,
                PersonAddress = person.PersonAddress,
                PassWord = person.PassWord,
                PhoneNumber = person.PhoneNumber,
                PersonPhoto = person.PersonPhoto
                
            };
        }

        
        public bool Update(int id, UpdatePersonDto person)
        {
            var persons = _personRepository.Get(id);
            persons.FirstName = person.FirstName;
            persons.LastName = person.LastName;
            persons.PersonAddress = person.PersonAddress;
            persons.PassWord = person.PassWord;
            persons.Email = person.Email;
            persons.PhoneNumber = person.PhoneNumber;
            persons.PersonPhoto = person.PersonPhoto;  
           _personRepository.Update(id, persons);
            return true;
            
        }
    }
}
