using LearningManagementSystem.DTOs;
using LearningManagementSystem.Interfaces.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IInstructorService _instructorService;
        private readonly IDepartmentService _departmentService;
        public CourseController(ICourseService courseService, IInstructorService instructorService, IDepartmentService departmentService)
        {
            _departmentService = departmentService;
            _instructorService = instructorService;
            _courseService = courseService;
        }

        
        public IActionResult Index()
        {
            var courses = _courseService.GetAllCourses();
            return View(courses);
        }

        public IActionResult Create()
        {
            var Instructor = _instructorService.GetAllInstructors();
            ViewData["Instructor"] = new SelectList(Instructor, "Id", "FirstName");
            var dept = _departmentService.GetAllDepartments();
            ViewData["Department"] = new SelectList(dept, "Id", "DepartmentName");
            

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCourseRequestModel model)
        {
            _courseService.CreateCourse(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var course = _courseService.GetCourse(id);
            return View(course);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var course = _courseService.GetCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateCourseRequestModel model)
        {
            _courseService.UpdateCourse(id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var course = _courseService.GetCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _courseService.DeleteCourse(id);
            return RedirectToAction("Index");
        }
    }
}
