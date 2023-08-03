using System;
using System.Security.Claims;
using ApiProject.Dtos;
using ApiProject.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ApiProject.Controllers
{
    public class MedicalRecordController : Controller
    {
        private readonly IMedicalRecordService _medicalservice;
        private readonly IDoctorService _doctorservice;
        private readonly IHospitalService _hospitalservice;

        public MedicalRecordController(IMedicalRecordService medicalservice, IDoctorService doctorservice, IHospitalService hospitalservice)
        {
            _medicalservice = medicalservice;
            _doctorservice = doctorservice;
            _hospitalservice = hospitalservice;
        }
        [Authorize(Roles="Patient")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int patientId, CreateMedicalRecordModel model)
        {
            patientId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            _medicalservice.Register(patientId, model);
            return RedirectToAction("Index", "Patient");
        }
         [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {

            var medical = _medicalservice.ReturnById(id);
            if (medical == null)
            {
                return NotFound();
            }
            return View(medical);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _medicalservice.Delete(id);
            return RedirectToAction("Index");
        }
         [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult GetAllMedicalrecords()
        {
            var medical = _medicalservice.GetAll();
            return View(medical.Data);
        }
        [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            var medical = _medicalservice.ReturnById(id);
            return View(medical.Data);
        }
        [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult RefferedNeededCases()
        {
            var medical = _medicalservice.RefferalNeededCases();
            return View(medical.Data);
        }
        [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult RefferedNotNeededCases()
        {
            var medical = _medicalservice.RefferalNotNeededCases();
            return View(medical.Data);
        }
        [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult AssignPatientToDoctor()
        {
            var doctor = _doctorservice.GetAllAvailableDoctors();
            ViewData["Doctor"] = new SelectList(doctor.Data, "Id", "FirstName");
            return View();
        }
        [HttpPost]
        public IActionResult AssignPatientToDoctor(int id, AssignDoctorRequestModel model)
        {
            var res = _medicalservice.AssignPatientToDoctor(id, model);
            return RedirectToAction("AssignedCases",res.Data);
        }
        [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult AssignPatientToHospital()
        {
            var res = _hospitalservice.GetAll();
            ViewData["Hospital"] = new SelectList(res.Data, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult AssignPatientToHospital(int id, AssignHospitalRequestModel model)
        {
            
            var res = _medicalservice.AssignPatientToHospital(id, model);
            // Console.WriteLine(id);
            // Console.WriteLine(model.HospitalId);
            return View(res.Data);
        }
        [Authorize(Roles="Doctor")]
        [HttpGet]
        public IActionResult TreatedRefferedCases()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TreatedRefferedCases(int id, int DoctorId, TreatedRefferedPatientCasesModel model)
        {
            DoctorId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var res = _medicalservice.TreatedRefferedCases(id, DoctorId, model);
            return View(res.Data);
        }
        [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult InitializedCases()
        {
            var res = _medicalservice.InitializedMedicalCases();
            return View(res.Data);
        }
        [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult TreatedCases()
        {
            var res = _medicalservice.TreatedMedicalCases();
            return View(res.Data);
        }
        [Authorize(Roles="Admin")]
        [HttpGet]
        public IActionResult AssignedCases()
        {
            var res = _medicalservice.AssignedMedicalCases();
            return View(res.Data);
        }
        [Authorize(Roles="Patient")]
        [HttpGet]
        public IActionResult GetByPatientId(int PatientId)
        {
            PatientId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var res = _medicalservice.GetByPatientId(PatientId);
            return View(res.Data);
        }
        [Authorize(Roles="Patient")]
        [HttpGet]
        public IActionResult GetAllByPatientId(int PatientId)
        {
            PatientId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var res = _medicalservice.GetAllByPatientId(PatientId);
            return View(res.Data);
        }
        [Authorize(Roles="Doctor")]
        [HttpGet]
        public IActionResult AssignedMedicalCases(int DoctorId)
        {
            DoctorId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var res = _medicalservice.AssignedMedicalCases(DoctorId);
            return View(res.Data);
        }
        [Authorize(Roles="Doctor")]
        [HttpGet]
        public IActionResult TreatedMedicalCases(int DoctorId)
        {
            DoctorId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var res = _medicalservice.TreatedMedicalCases(DoctorId);
            return View(res.Data);
        }
        [Authorize(Roles="Hospital")]
        [HttpGet]
        public IActionResult AssignedHospital(int HospitalId)
        {
            HospitalId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var res = _medicalservice.AssignedHospital(HospitalId);
            return View(res.Data);
        }
        [Authorize(Roles="Patient")]
        [HttpGet]
        public IActionResult RecentComplainByPatientId(int PatientId)
        {
            PatientId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var res = _medicalservice.GetComplainByPatientId(PatientId);
            return View(res.Data);
        }
    }
}