using LearningManagementSystem.DTOs;
using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces.Repositories;
using LearningManagementSystem.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Implementations.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public bool CreateDepartment(CreateDepartmentRequestModel model)
        {
            var department = new Department
            {
                DepartmentName = model.DepartmentName

            };
            _departmentRepository.CreateDepartment(department);
            return true;
        }

        public void DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetDepartment(id);
            _departmentRepository.Delete(department);
        }

        public DepartmentDto GetDepartment(int id)
        {
            var department = _departmentRepository.GetDepartment(id);
            return new DepartmentDto
            {
                
                DepartmentName = department.DepartmentName,
                Id = department.Id,

            };
        }

        public IList<DepartmentDto> GetAllDepartments()
        {
            return _departmentRepository.GetAllDepartment().Select(c => new DepartmentDto
            {
                Id = c.Id,
                DepartmentName = c.DepartmentName,
                Students = c.Students.Select(a => new StudentDto
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,

                }).ToList(),
                Instructors = c.Instructors.Select(i => new InstructorDto
                {
                    Id = i.Id,
                    FirstName = i.FirstName,
                    LastName = i.LastName,

                }).ToList(),
                Courses = c.Courses.Select(co => new CourseDto
                {
                    Id = co.Id,
                    CourseCode = co.CourseCode,
                    CourseName = co.CourseName,
                }).ToList(),

            }).ToList();
        }

        public bool UpdateDepartment(int id, UpdateDepartmentRequestModel model)
        {
            var department = _departmentRepository.GetDepartment(id);
            department.DepartmentName = model.DepartmentName;

            _departmentRepository.UpdateDepartment(department);
            return true;
        }
    }
}
