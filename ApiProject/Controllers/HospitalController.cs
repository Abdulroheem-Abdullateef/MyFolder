using ApiProject.Dtos;
using ApiProject.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    public class HospitalController : Controller
    {
       
        private readonly IHospitalService _hospitalservice;       

        public HospitalController( IHospitalService hospitalservice)
        {           
            _hospitalservice = hospitalservice;            
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateHospitalModel model)
        {
            _hospitalservice.Register(model);
            // return View(hospital.Data);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var hosp = _hospitalservice.ReturnById(id);
            if (hosp == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateHospitalModel model)
        {
            _hospitalservice.Update(model, id);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        [Authorize(Roles="Admin")]
        public IActionResult Delete(int id)
        {

            var hospital = _hospitalservice.ReturnById(id);
            if (hospital == null)
            {
                return NotFound();
            }
            return View(hospital.Data);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _hospitalservice.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetAllHospitals()
        {
            var hospitals = _hospitalservice.GetAll();
            return View(hospitals.Data);
        }
        [HttpGet]
        [Authorize(Roles="Admin, Hospital")]
        public IActionResult Details(int id)
        {
            var hospital = _hospitalservice.ReturnById(id);
            return View(hospital.Data);
        }
    }
}