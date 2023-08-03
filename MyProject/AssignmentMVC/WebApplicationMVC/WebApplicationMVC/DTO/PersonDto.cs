using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.Entities;

namespace WebApplicationMVC.DTO
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonAddress { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public int CityId { get; set; }
        public string PhoneNumber { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
        public List<CityDto> Cities { get; set; } = new List<CityDto>();
        public string PersonPhoto { get; set; }
    }

    public class CreatePersonDto
    {
        [Required ]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string PersonAddress { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        public int CityId { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Invalid Password")]
        public string PassWord { get; set; }
        public IList<int> Cities { get; set; }
        public string PersonPhoto { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phonenumber")]
        public string PhoneNumber { get; set; }
        public IList<int> Country { get; set; }
    }

    public class UpdatePersonDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonAddress { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string PhoneNumber { get; set; }
        public string PersonPhoto { get; set; }
    }
}
