using APIProject.Dtos;
using APIProject.Interfaces.IPersonServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentServices;

        public StudentController(IStudentService studentService)
        {
            _studentServices = studentService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateStudentRequestModel model)
        {
            var student = _studentServices.AddStudent(model);
            return Ok(student);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            var student = _studentServices.GetStudent(id);
            _studentServices.DeleteStudent(id);
            return Ok(student);
        }


        [HttpPut("{id}")]
        public IActionResult Update([FromRoute]int id,[FromBody] UpdateStudentRequestModel model)
        {
            var student = _studentServices.UpdateStudent(id, model);
            return Ok(student);

        }

        [HttpGet("{id}")]
        public IActionResult Details([FromRoute] int id)
        {
            var student = _studentServices.GetStudent(id);
            return Ok(student);

        }
    }
}
