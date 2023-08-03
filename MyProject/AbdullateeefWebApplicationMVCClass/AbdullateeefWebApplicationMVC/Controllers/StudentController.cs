using AbdullateeefWebApplicationMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbdullateeefWebApplicationMVC.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> students = new List<Student>()
        {
            new Student
            {
                Id =1,
                Class = "100 LEVEL",
                Name = "Adeolu",
                Age = 20
            },

            new Student
            {
                Id = 2,
                Class = "200 LEVEl",
                Name = "Olamide",
                Age = 30
            },

            new Student
            {
                Id = 3,
                Class = "300 LEVEL",
                Name = "Olawale",
                Age = 40
            },
        };
        public List<StudentDto> GetStudents()
        {
            return students.Select(s => new StudentDto
            {
                Id = s.Id,
                Class = s.Class,
                Name = s.Name,
                Age = s.Age
            }).ToList();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
           // var studentList = GetStudents();
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("List");
        }

        [Route("{name}")]
        public IActionResult Details([FromRoute]string name)
        {
            var student = students.Where(a => a.Name == name).FirstOrDefault();
            return View(student);

        }


    }
}
