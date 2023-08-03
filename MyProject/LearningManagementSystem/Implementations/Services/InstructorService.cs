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
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IDepartmentRepository _departmentRepository;
        public InstructorService( IInstructorRepository instructorRepository,ICourseRepository courseRepository,IDepartmentRepository departmentRepository
)
        {
            _instructorRepository = instructorRepository;
            _courseRepository = courseRepository;
            _departmentRepository = departmentRepository;

        }
        public bool CreateInstructor(CreateInstructorRequestModel model)
        {
            var course = _courseRepository.GetCourse(model.CourseId);
            var department = _departmentRepository.GetDepartment(model.DepartmentId); 
            var instructor = new Instructor
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PassWord = model.PassWord,
                PhoneNumber = model.PhoneNumber,
                DateOfBirth = model.DateOfBirth,
                Address = model.Address,
                Gender = model.Gender,
                DepartmentId = model.DepartmentId,
                CourseId = model.CourseId,
                Course = course,
                Department = department,
                
            };
            _instructorRepository.CreateInstructor(instructor);
            return true;
        }

        public void DeleteInstructor(int id)
        {
            var instructor = _instructorRepository.GetInstructor(id);
            _instructorRepository.Delete(instructor);
        }

        public InstructorDto GetInstructor(int id)
        {
            var instructor = _instructorRepository.GetInstructor(id);
            return new InstructorDto
            {
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                Email = instructor.Email,
                PassWord = instructor.PassWord,
                PhoneNumber = instructor.PhoneNumber,
                DateOfBirth = instructor.DateOfBirth,
                Address = instructor.Address,
                Gender = instructor.Gender,
                Id = instructor.Id,
                 
               
            };
        }

        public IList<InstructorDto> GetAllInstructors()
        {
            return _instructorRepository.GetAllInstructor().Select(n => new InstructorDto
            {
                Id = n.Id,
                FirstName = n.FirstName,
                LastName = n.LastName,
                Email = n.Email,
                PassWord = n.PassWord,
                PhoneNumber = n.PhoneNumber,
                DateOfBirth = n.DateOfBirth,
                Address = n.Address,
                Gender = n.Gender,
                CourseId = n.CourseId,
                DepartmentId = n.DepartmentId,
                

            }).ToList();
        }

        public InstructorDto GetInstructorByName(string name)
        {
            var instructor = _instructorRepository.GetByName(name);

            return new InstructorDto
            {
                Id = instructor.Id,
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                Address = instructor.Address,
                PhoneNumber = instructor.PhoneNumber,
                Email = instructor.Email,
                DateOfBirth = instructor.DateOfBirth,
                DepartmentName = instructor.Department.DepartmentName,
                CourseName = instructor.Course.CourseName,


            };
        }

        public InstructorDto Login(LoginRequestModel model)
        {
            var instructor = _instructorRepository.GetInstructorByEmail(model.Email);
            if (instructor == null || instructor.PassWord != model.Password)
            {
                return null;
            }
            else
            {
                return new InstructorDto
                {
                    Id = instructor.Id,
                    FirstName = instructor.FirstName,
                    LastName = instructor.LastName,
                    Email = instructor.Email,
                    Address = instructor.Address,
                    DateOfBirth = instructor.DateOfBirth,
                    PhoneNumber = instructor.PhoneNumber,
                    Gender = instructor.Gender,
                    
                };
        }   }

        public bool UpdateInstructor(int id, UpdateInstructorRequestModel model)
        {
            var instructor = _instructorRepository.GetInstructor(id);
            instructor.Address = model.Address;
            instructor.Email = model.Email;
            instructor.PassWord = model.PassWord;
            instructor.PhoneNumber = model.PhoneNumber;

            _instructorRepository.UpdateInstructor(instructor);
            return true;
        }
    }
}
