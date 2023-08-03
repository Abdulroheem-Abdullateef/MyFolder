using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRevisionMVC.Models;

namespace WebApplicationRevisionMVC.Controllers
{
    public class PersonController : Controller
    {
        public List<Person> students = new List<Person>()
        {
            new Person
            {
                Id = 1,
                RegistrationNumber = Guid.NewGuid().ToString().ToUpper().Replace("-","").Substring(0,10),
                Address = "Abolade Street",
                FirstName = "Taiwo",
                LastName = "Olalekan",
                Age = 20,
                Email = "Taiwo@gmail.com",
                PassWord = "123455",
                PhoneNumber = "07087654323"
            },

            new Person
            {
                Id = 2,
                RegistrationNumber = Guid.NewGuid().ToString().ToUpper().Replace("-","").Substring(0,10),
                Address = "Adewole Street",
                FirstName = "Azeez",
                LastName = "Lekan",
                Age = 22,
                Email = "Lekan@gmail.com",
                PassWord = "12455",
                PhoneNumber = "07023456789"

            },

            new Person
            {
                Id = 3,
                RegistrationNumber = Guid.NewGuid().ToString().ToUpper().Replace("-","").Substring(0,10),
                Address = "Adeshewa Street",
                FirstName = "Taiwo",
                LastName = "Salam",
                Age = 28,
                Email = "Salam@gmail.com",
                PassWord = "123455",
                PhoneNumber = "0706700457665"

            }
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(students);
        }

        public IActionResult Details(int id)
        {
            var student = students.SingleOrDefault(a => a.Id ==id);
            return View(student);
        }



    }
}
