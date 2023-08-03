using System;
using System.IO;
using ApiProject.Dtos;
using ApiProject.Interfaces.IServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminservice;       
        private readonly IWebHostEnvironment _webroot;

        public AdminController(IAdminService adminservice, IWebHostEnvironment webroot)
        {
            _adminservice = adminservice;
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
        public IActionResult Create(CreateAdminModel model, IFormFile AdminPhoto)
        {
            if (AdminPhoto != null)
            {
                string AdminImagePath = Path.Combine(_webroot.WebRootPath, "AdminImages");
                Directory.CreateDirectory(AdminImagePath);
                string contentType = AdminPhoto.ContentType.Split('/')[1];
                string AdminImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(AdminImagePath, AdminImage);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    AdminPhoto.CopyTo(fileStream);

                }
                model.AdminPhoto = AdminImage;
                
            }
            _adminservice.Register(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var admin = _adminservice.ReturnById(id);
            if (admin == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateAdminModel model,IFormFile AdminPhoto)
        {
             if (AdminPhoto != null)
            {
                string AdminImagePath = Path.Combine(_webroot.WebRootPath, "UpdateDoctorImages");
                Directory.CreateDirectory(AdminImagePath);
                string contentType = AdminPhoto.ContentType.Split('/')[1];
                string AdminImage = $"FDI{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(AdminImagePath, AdminImage);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    AdminPhoto.CopyTo(fileStream);

                }
                model.AdminPhoto = AdminImage;
            }
            _adminservice.Update(model, id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {

            var admin = _adminservice.ReturnById(id);
            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _adminservice.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var admin = _adminservice.ReturnById(id);
            return View(admin.Data);
        }
        [HttpGet]
        public IActionResult EmailDetail(string Email)
        {
            var admin = _adminservice.GetByEmail(Email);
            return View(admin.Data);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var admin = _adminservice.GetAll();
            return View(admin.Data);
        }
    }
}