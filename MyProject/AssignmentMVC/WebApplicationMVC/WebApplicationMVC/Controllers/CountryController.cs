using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.DTO;
using WebApplicationMVC.Interfaces.Services;

namespace WebApplicationMVC.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryServices _countryService;
       
        public CountryController(ICountryServices countryServices)
        {
            _countryService = countryServices;

        }


        public IActionResult Index()
        {
            var country = _countryService.GetAllCountry();
            return View(country);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCountryDto create)
        {
            _countryService.CreateCountry(create);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var country = _countryService.GetCountry(id);
            return View(country);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var country = _countryService.GetCountry(id);
            if (country == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateCountryDto update)
        {
            _countryService.UpdateCountry(id, update);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var person = _countryService.GetCountry(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _countryService.DeleteCountry(id);
            return RedirectToAction("Index");
        }


    }
}
