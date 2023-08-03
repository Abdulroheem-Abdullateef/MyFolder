
using APIProject.Interfaces.IPersonServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonServices _personServices;


        public PersonController(IPersonServices personServices)
        {
            _personServices = personServices;
        }


        [HttpPost]
        public IActionResult Create([FromBody] CreatePersonRequestModel model)
        {
            var person = _personServices.CreatePerson(model);

            return Ok(person);

        }

        [HttpDelete ("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            var person = _personServices.GetPerson(id);
            _personServices.DeletePerson(id);
            
            return Ok(person);
        }

        [HttpGet("{id}")]
        public IActionResult Details([FromRoute]int id)
        {
            var person = _personServices.GetPerson(id);
   
            return Ok(person);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute]int id, [FromBody] UpdatePersonRequestModel model )
        {
            var person = _personServices.UpdatePerson(id, model);
            
            return Ok(person);
        }
    }
}
