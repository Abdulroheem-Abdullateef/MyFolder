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
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IDepartmentRepository _departmentRepository;
        public CourseService(ICourseRepository courseRepository, IDepartmentRepository departmentRepository)
        {
            _courseRepository = courseRepository;
            _departmentRepository = departmentRepository;


        }
        public bool CreateCourse(CreateCourseRequestModel model)
        {
            var department = _departmentRepository.GetDepartment(model.DepartmentId);
            var course = new Course
            {
                
                CourseName = model.CourseName,
                CourseCode = Guid.NewGuid().ToString().Substring(0, 11).Replace("-", "").ToUpper(),
                DepartmentId = model.DepartmentId,
                Department = department

            };
            _courseRepository.CreateCourse(course);
            return true;

        }

        public void DeleteCourse(int id)
        {
            var course = _courseRepository.GetCourse(id);
            _courseRepository.Delete(course);
        }

        public CourseDto GetCourse(int id)
        {
            var course = _courseRepository.GetCourse(id);
            return new CourseDto
            {
                Id = course.Id,
                CourseName = course.CourseName,
                CourseCode = course.CourseCode,
                
            };
        }

        public IList<CourseDto> GetAllCourses()
        {
            return _courseRepository.GetAllCourses().Select(n => new CourseDto
            {
                Id = n.Id,
                CourseCode = n.CourseCode,
                CourseName = n.CourseName,
                
            }).ToList();
        }

        public bool UpdateCourse(int id, UpdateCourseRequestModel model)
        {
            var course = _courseRepository.GetCourse(id);
            course.CourseName = model.CourseName;
            
            

            _courseRepository.UpdateCourse(course);
            return true;
        }
    }
}
