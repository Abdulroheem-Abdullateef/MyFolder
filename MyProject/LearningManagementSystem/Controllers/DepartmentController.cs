using LearningManagementSystem.DTOs;
using LearningManagementSystem.Implementations.Services;
using LearningManagementSystem.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartmentService _departmentService;

        public DepartmentController( IDepartmentService departmentServices)
        {
            _departmentService = departmentServices;
        }

        public IActionResult Index()
        {
            var department = _departmentService.GetAllDepartments();
            return View(department);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateDepartmentRequestModel model)
        {
            _departmentService.CreateDepartment(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var department = _departmentService.GetDepartment(id);
            return View(department);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var department = _departmentService.GetDepartment(id);
            if (department == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateDepartmentRequestModel model)
        {
            _departmentService.UpdateDepartment(id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var department = _departmentService.GetDepartment(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _departmentService.DeleteDepartment(id);
            return RedirectToAction("Index");
        }
    }
}
