using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.DTO;
using WebApplicationMVC.Interfaces.Services;

namespace WebApplicationMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonServices _personServices;
        private readonly ICityServices _cityServices;
        private readonly ICountryServices _countryServices;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public PersonController(IPersonServices personServices, ICityServices cityServices, ICountryServices countryServices, IWebHostEnvironment webHostEnvironment )
        {
            _personServices = personServices;
            _cityServices = cityServices;
            _countryServices = countryServices;
            _webHostEnvironment = webHostEnvironment;
        } 

        public IActionResult Index()
        {
            var person = _personServices.GetAllPerson();
            return View(person);
        }

        public IActionResult Create()
        {
            var country = _countryServices.GetAllCountry();
            ViewData["Country"] = new SelectList(country, "Id", "CountryName");
            
            var city = _cityServices.GetAllCity();
            ViewData["City"] = new SelectList(city, "Id", "CityName");
            
            return View();
        }

        [HttpPost]

        public IActionResult Create(CreatePersonDto create, IFormFile personPhoto)
        {
            string personPhotopath = Path.Combine(_webHostEnvironment.WebRootPath, "PersonPhoto");
            Directory.CreateDirectory(personPhotopath);
            string contentType = personPhoto.FileName.Split('.')[1];
            string personImage = $"PSN{Guid.NewGuid()}.{contentType}";
            string fullpath = Path.Combine(personPhotopath, personImage);
            using ( var filestream = new FileStream(fullpath,FileMode.Create))
            {
                personPhoto.CopyTo(filestream);
            }
            create.PersonPhoto = personImage;

            _personServices.CreatePerson(create);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var person = _personServices.GetPerson(id);
            return View(person);
        }

        public IActionResult Update(int id)
        {
            var person = _personServices.GetPerson(id);
            if (person== null)
            {
                return NotFound();
            }

            return View(person);
        }

        [HttpPost]
        public IActionResult Update(int id ,UpdatePersonDto update)
        {
            _personServices.Update(id, update);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var person = _personServices.GetPerson(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _personServices.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
