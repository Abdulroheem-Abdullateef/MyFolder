using System;
using System.IO;
using ApiProject.Dtos;
using ApiProject.Interfaces.IServices;
using ApiProject.SendingMessages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    public class DoctorController : Controller
    {

        private readonly IDoctorService _doctorservice;
        private readonly IWebHostEnvironment _webroot;
        private readonly IMailMessage _message;

        public DoctorController(IDoctorService doctorservice, IWebHostEnvironment webroot, IMailMessage message)
        {
            _doctorservice = doctorservice;
            _webroot = webroot;
            _message = message;
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
        public IActionResult Create(CreateDoctorModel model, IFormFile DoctorPhoto, IFormFile DoctorCertificate)
        {
            if (DoctorPhoto != null)
            {
                string DoctorImagePath = Path.Combine(_webroot.WebRootPath, "DoctorImage");
                Directory.CreateDirectory(DoctorImagePath);
                string contentType = DoctorPhoto.ContentType.Split('/')[1];
                string DoctorImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(DoctorImagePath, DoctorImage);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    DoctorPhoto.CopyTo(fileStream);

                }
                model.DoctorPhoto = DoctorImage;

            }
            if (DoctorCertificate != null)
            {
                string DoctorCertificatePath = Path.Combine(_webroot.WebRootPath, "DoctorCertificateImage");
                Directory.CreateDirectory(DoctorCertificatePath);
                string contentType = DoctorCertificate.ContentType.Split('/')[1];
                string DocCertImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(DoctorCertificatePath, DocCertImage);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    DoctorCertificate.CopyTo(fileStream);

                }
                model.DoctorCertificate = DocCertImage;

            }
            _doctorservice.Register(model);
            // var reply = $" Dear {model.FirstName} {model.LastName}, your request to  join our our medical teams as a {model.AreaOfSpec} has beeen received, We kindly  Urge you to  bear with us for a moment while we are reviewing your Uploads for veirfication. You will receive an email message shortly, Thanks for bearing with us";
            // _message.SendingMail(model.Email, reply, "Welcome Message");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var doctor = _doctorservice.ReturnById(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateDoctorModel model, IFormFile DoctorPhoto, IFormFile DoctorCertificate)
        {
            if (DoctorPhoto != null)
            {
                string DoctorImagePath = Path.Combine(_webroot.WebRootPath, "UpdateDoctorImage");
                Directory.CreateDirectory(DoctorImagePath);
                string contentType = DoctorPhoto.ContentType.Split('/')[1];
                string DoctorImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(DoctorImagePath, DoctorImage);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    DoctorPhoto.CopyTo(fileStream);

                }
                model.DoctorPhoto = DoctorImage;

            }
            if (DoctorCertificate != null)
            {
                string DoctorCertificatePath = Path.Combine(_webroot.WebRootPath, "UpdateDoctorCertificateImage");
                Directory.CreateDirectory(DoctorCertificatePath);
                string contentType = DoctorCertificate.ContentType.Split('/')[1];
                string DocCertImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(DoctorCertificatePath, DocCertImage);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    DoctorCertificate.CopyTo(fileStream);

                }
                model.DoctorCertificate = DocCertImage;

            }

            _doctorservice.Update(model, id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var doctor = _doctorservice.ReturnById(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _doctorservice.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var doctor = _doctorservice.ReturnById(id);
            return View(doctor.Data);
        }
        [HttpGet]
        public IActionResult EmailDetail(string Email)
        {
            var doctor = _doctorservice.GetByEmail(Email);
            return View(doctor.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllApprovedDoctors()
        {
            var doctor = _doctorservice.GetAllApprovedDoctors();
            return View(doctor.Data);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllPharmacologist()
        {
            var doctor = _doctorservice.GetAllPharmacologist();
            return View(doctor.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllDentisit()
        {
            var doctor = _doctorservice.GetAllDentists();
            return View(doctor.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllOpticians()
        {
            var doctor = _doctorservice.GetAllOpticians();
            return View(doctor.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllPadaestrics()
        {
            var doctor = _doctorservice.GetAllPadaestrics();
            return View(doctor.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllHaematologists()
        {
            var doctor = _doctorservice.GetAllHaemotologistics();
            return View(doctor.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllOrthopaedics()
        {
            var doctor = _doctorservice.GetAllOrthopaedics();
            return View(doctor.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllGynaeocologist()
        {
            var doctor = _doctorservice.GetAllGynaeocologists();
            return View(doctor.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllAvailableDoctors()
        {
            var doctor = _doctorservice.GetAllAvailableDoctors();
            return View(doctor.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllInitialized()
        {
            var doctor = _doctorservice.GetAllInitializedDoctors();
            return View(doctor.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult ApprovedDoctors(int DoctorId)
        {
            var doctor = _doctorservice.ApproveDoctor(DoctorId);
            // var reply = $" Dear {doctor.Data.FirstName} {doctor.Data.LastName}, few moment ago, your application was received and a promised was made to send an email message for approval notification.We hereby inform you that having verified and satisfied your documents, your request to join our medical team as a {doctor.Data.AreaOfSpec} has been approved";
            // _message.SendingMail(doctor.Data.Email, reply, "Approval Message");
            return Redirect("GetAllInitialized");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult DissaprovedDoctors(int DoctorId)
        {
            var doctor = _doctorservice.DissaprovedDoctors(DoctorId);
            return Redirect("GetAllInitialized");
        }
    }
}