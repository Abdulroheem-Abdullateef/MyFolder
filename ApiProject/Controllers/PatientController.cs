using System;
using System.IO;
using ApiProject.Dtos;
using ApiProject.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    public class PatientController :  Controller
    {
        private readonly IPatientService _patientservice;       
        private readonly IWebHostEnvironment _webroot;

        public PatientController(IPatientService patientservice, IWebHostEnvironment webroot)
        {           
            _patientservice = patientservice;           
            _webroot = webroot;
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
        public IActionResult Create(CreatePatientModel model, IFormFile PatientPhoto)
        {
            if (PatientPhoto != null)
            {
                string PatientImagePath = Path.Combine(_webroot.WebRootPath, "PatientImages");
                Directory.CreateDirectory(PatientImagePath);
                string contentType = PatientPhoto.ContentType.Split('/')[1];
                string PatientImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(PatientImagePath, PatientImage);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    PatientPhoto.CopyTo(fileStream);

                }
                model.PatientPhoto = PatientImage;
            }
            _patientservice.Register(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var admin = _patientservice.ReturnById(id);
            if (admin == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdatetePatientModel model,IFormFile PatientPhoto)
        {
            if (PatientPhoto != null)
            {
                string PatientImagePath = Path.Combine(_webroot.WebRootPath, "PatientImages");
                Directory.CreateDirectory(PatientImagePath);
                string contentType = PatientPhoto.ContentType.Split('/')[1];
                string PatientImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(PatientImagePath, PatientImage);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    PatientPhoto.CopyTo(fileStream);

                }
                model.PatientPhoto = PatientImage;
            }
           
            _patientservice.Update(model, id);
            return RedirectToAction("Index");
        }
        
        [HttpGet]        
        public IActionResult Delete(int id)
        {

            var patient = _patientservice.ReturnById(id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient.Data);
        }
        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _patientservice.Delete(id);
            return RedirectToAction("Index");
        }
        [Authorize(Roles= "Admin, Patient")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            var patient = _patientservice.ReturnById(id);
            return View(patient.Data);
        }
        
        [HttpGet]
        public IActionResult EmailDetail(string Email)
        {
            var patient = _patientservice.GetByEmail(Email);
            return View(patient.Data);
        }
        [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var patients = _patientservice.GetAll();
            return View(patients.Data);
        }
    }
}