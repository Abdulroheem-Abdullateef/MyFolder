using LearningManagementSystem.DTOs;
using LearningManagementSystem.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IInstructorService _instructorService;
        private readonly IStudentService _studentService;
        private readonly IDepartmentService _departmentService;
        private readonly ICourseService _courseService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public StudentController(IInstructorService instructorService, IStudentService studentService, IDepartmentService departmentService, ICourseService courseService, IWebHostEnvironment webHostEnvironment)
        {
            _instructorService = instructorService;
            _studentService = studentService;
            _departmentService = departmentService;
            _courseService = courseService;
            _webHostEnvironment = webHostEnvironment;
        }

        
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }


        public IActionResult Create()
        {

            var department = _departmentService.GetAllDepartments();
            ViewData["Departments"] = new SelectList(department, "Id", "DepartmentName");

            var courses = _courseService.GetAllCourses();
            ViewData["Courses"] = new SelectList(courses, "Id", "CourseName");

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateStudentRequestModel model, IFormFile studentPhoto)
        {
            string studentPhotoPath = Path.Combine(_webHostEnvironment.WebRootPath, "studentPhotos");
            Directory.CreateDirectory(studentPhotoPath);
            string contentType = studentPhoto.ContentType.Split('/')[1];
            string studentImage = $"STD{Guid.NewGuid()}.{contentType}";
            string fullPath = Path.Combine(studentPhotoPath, studentImage);
            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                studentPhoto.CopyTo(fileStream);
            }
            model.StudentPhoto = studentImage;

            _studentService.CreateStudent(model);
            return RedirectToAction("Home");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            
            var student = _studentService.GetStudent(id);
            return View(student);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var student = _studentService.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateStudentRequestModel model)
        {
            _studentService.UpdateStudent(id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var student = _studentService.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentService.GetStudent(id);
            _studentService.DeleteStudent(id);
            return RedirectToAction("Home");
        }

        public IActionResult Profile()
        {
            int id = int.Parse(HttpContext.Session.GetString("Id"));
            var student = _studentService.GetStudent(id);
            return View(student);
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginRequestModel model)
        {
            var student = _studentService.Login(model);


            if (student != null)
            {
                HttpContext.Session.SetString("Id", student.Id.ToString());
                
              
                var i = 1;
                foreach (var course in student.Courses)
                {
                    HttpContext.Session.SetString($"course{i}", course.CourseName);
                    i++;
                }
                HttpContext.Session.SetString("numberOfCourses", student.Courses.Count.ToString());
                HttpContext.Session.SetString("role", "Student");
                HttpContext.Session.CommitAsync();

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
            return RedirectToAction("Index","Home");
        }


    }




}


