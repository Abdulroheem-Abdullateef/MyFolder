using LearningManagementSystem.DTOs;
using LearningManagementSystem.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorService _instructorService;
        
        public InstructorController(IInstructorService instructorService)
        {
            
            _instructorService = instructorService;
        }

        
        public IActionResult Index()
        {
            var instructor = _instructorService.GetAllInstructors();
            return View(instructor);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateInstructorRequestModel model)
        {
            _instructorService.CreateInstructor(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var instructor = _instructorService.GetInstructor(id);
            return View(instructor);
        }



        [HttpGet]
        public IActionResult Update(int id)
        {
            var instructor = _instructorService.GetInstructor(id);
            if (instructor == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateInstructorRequestModel model)
        {
            _instructorService.UpdateInstructor(id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var instructor = _instructorService.GetInstructor(id);
            if (instructor == null)
            {
                return NotFound();
            }
            return View(instructor);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _instructorService.DeleteInstructor(id);
            return RedirectToAction("Index");
        }


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Profile()
        {
            int id = int.Parse(HttpContext.Session.GetString("Id"));
            var instructor = _instructorService.GetInstructor(id);
            return View(instructor);
        }

        [HttpPost]
        
        public IActionResult Login(LoginRequestModel model)
        {
            var instructor = _instructorService.Login(model);

            if (instructor !=null)
            {
                HttpContext.Session.SetString("Id", instructor.Id.ToString());
                
                return RedirectToAction("Profile");

            }
            else
            {
                    ViewBag.error = "Invalid username or password";
                    return View();
            }

        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Home");
            
        }


    }




}

