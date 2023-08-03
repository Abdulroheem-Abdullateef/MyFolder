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
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IDepartmentRepository _departmentRepository;
       
        public StudentService(IStudentRepository studentRepository , ICourseRepository courseRepository, IDepartmentRepository departmentRepository)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
            _departmentRepository = departmentRepository;
            
        }
        public bool CreateStudent(CreateStudentRequestModel model)
        {

            var student = new Student
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PassWord = model.PassWord,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                DateOfBirth = model.DateOfBirth,
                Gender = model.Gender,
                DepartmentId = model.DepartmentId,
                StudentPhoto = model.StudentPhoto,

             
            };

            var courses = _courseRepository.GetSelectedCourses(model.CourseIds);
            foreach (var course in courses)
            {
                var studentcourse = new StudentCourse
                {
                    Course = course,
                    CourseId = course.Id,
                    Student = student,
                    StudentId = student.Id
                };
                student.StudentCourses.Add(studentcourse);

            }
            _studentRepository.CreateStudent(student);
            return true;

        }

        public void DeleteStudent(int id)
        {
            var student = _studentRepository.GetStudent(id);
            _studentRepository.DeleteStudent(student);
        }

        public IList<StudentDto> GetAllStudents()
        {
            return _studentRepository.GetAllStudent().Select(d => new StudentDto
            {
                Id = d.Id,
                FirstName = d.FirstName,
                LastName = d.LastName,
                Email = d.Email,
                DateOfBirth = d.DateOfBirth,
                Address = d.Address,
                Gender = d.Gender,
                PhoneNumber = d.PhoneNumber,
                StudentPhoto = d.StudentPhoto,


            }).ToList();
            
        }

        public StudentDto GetStudent(int id)
        {
            var student = _studentRepository.GetStudent(id);
            if (student == null)
            {
                throw new Exception($"Dear {student} your id is invalid ");
            }
            else
            {
                return new StudentDto
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Email = student.Email,
                    DepartmentName = student.Department.DepartmentName,
                    PhoneNumber = student.PhoneNumber,

                    Courses = student.StudentCourses.Select(c => new CourseDto
                    {
                        Id = c.CourseId,
                        CourseName = c.Course.CourseName,
                        CourseCode = c.Course.CourseCode,

                    }).ToList()

                };
            }
            
        }

        
        public StudentDto Login(LoginRequestModel model)
        {
            var student = _studentRepository.GetStudentByEmail(model.Email);
            if (student == null || student.PassWord != model.Password)
            {
                throw new Exception($"Dear {student} incorrect password or email is invalid ");
            }
            else
            {
                return new StudentDto
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Email = student.Email,
                    Address = student.Address,
                    DateOfBirth = student.DateOfBirth,
                    PhoneNumber = student.PhoneNumber,
                    Gender = student.Gender,

                    Courses = student.StudentCourses.Select(c => new CourseDto
                    {
                        Id = c.CourseId,
                        CourseName = c.Course.CourseName,
                        CourseCode = c.Course.CourseCode
                    }).ToList()

                };
            }
        }

        public bool UpdateStudent(int id, UpdateStudentRequestModel model)
        {
            var student = _studentRepository.GetStudent(id);
            student.Email = model.Email;
            student.PhoneNumber = model.PhoneNumber;
            _studentRepository.UpdateStudent(student);
            return true;

        }

        
         
    }
}
