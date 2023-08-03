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
    public class CityController : Controller
    {
        private readonly ICityServices _cityService;
        private readonly ICountryServices _countryServices;
        public CityController(ICityServices cityService, ICountryServices countryServices)
        {
            _cityService = cityService;
            _countryServices = countryServices;
        }

        public IActionResult Index()
        {
            var city = _cityService.GetAllCity();
            return View(city);

        }

        public IActionResult Create()
        {
            var country = _countryServices.GetAllCountry();
            ViewData["Country"] = new SelectList(country, "Id", "CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCityDto create)
        {
            _cityService.CreateCity(create);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var person = _cityService.GetCity(id);
            return View(person);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var person = _cityService.GetCity(id);
            if (person == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateCityDto update)
        {
            _cityService.UpdateCity(id, update);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var person = _cityService.GetCity(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _cityService.DeleteCity(id);
            return RedirectToAction("Index");
        }
    }
}
