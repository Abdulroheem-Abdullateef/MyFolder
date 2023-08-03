using APIProject.Dtos;
using APIProject.Entities;
using APIProject.Interfaces.IPersonRepository;
using APIProject.Interfaces.IPersonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Implementations.Services
{
    public class StudentService : IStudentService
    {

        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public bool AddStudent(CreateStudentRequestModel model)
        {
            var student = new Student
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                DateOfBirth = model.DateOfBirth,


            };
            _studentRepository.Create(student);
            return true;

        }

        public void DeleteStudent(int id)
        {
            var student = _studentRepository.GetStudent(id);
            _studentRepository.Delete(student);


        }

        public IList<StudentDto> GetAllStudent()
        {
            return _studentRepository.GetAllStudents().Select(s => new StudentDto
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Address = s.Address,
                DateOfBirth = s.DateOfBirth,
                PhoneNumber = s.PhoneNumber,
            }).ToList();
        }

        public StudentDto GetStudent(int id)
        {
            var student = _studentRepository.GetStudent(id);
            return new StudentDto
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Address = student.Address,
                DateOfBirth = student.DateOfBirth,
                PhoneNumber = student.PhoneNumber
            };
            
        }

        public bool UpdateStudent(int id, UpdateStudentRequestModel model)
        {
            var student = _studentRepository.GetStudent(id);
            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            student.Address = model.Address;
            student.DateOfBirth = model.DateOfBirth;
            student.PhoneNumber = model.PhoneNumber;
            _studentRepository.Update(student);
            return true;
        }
    }
}
