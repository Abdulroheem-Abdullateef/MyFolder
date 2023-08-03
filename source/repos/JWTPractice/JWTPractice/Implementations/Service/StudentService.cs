using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTPractice.DTOS;
using JWTPractice.Entities;
using JWTPractice.Interfaces.IRepository;
using JWTPractice.Interfaces.Service;

namespace JWTPractice.Implementations.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _StudentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _StudentRepository = studentRepository;
        }

        public async Task<BaseResponse<StudentDto>> CreateStudent(CreateStudentRequestModel model)
        {
            var isStudentExist = _StudentRepository.Exists(d => d.Email == model.Email);
            if (isStudentExist)
            {
                throw new Exception("The Student Is Already Exist");
            }

            Student student = new Student
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                Password = model.Password,
                Email = model.Email,

            };
            await _StudentRepository.Create(student);
            return new BaseResponse<StudentDto>
            {
                Success = true,
                Message = "Student Create Successfully",
                Data = new StudentDto
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Password = student.Password,
                    Email = student.Email,

                }


            };

        }

        public async Task<BaseResponse<StudentDto>> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<List<StudentDto>>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<StudentDto>> GetStudentById(int id)
        {
            var student = await _StudentRepository.Get(id);      
            return new BaseResponse<StudentDto>
            {
                Success = true,
                Data = new StudentDto
                {
                   Id = student.Id,
                   FirstName = student.FirstName,
                   LastName = student.LastName,
                   Email = student.Email,
                   Password = student.Password,
                },
                Message = "Student Retrieved"
            };



        }

        //public async Task<BaseResponse<StudentDto>> LoginStudent(LoginStudentDto model)
        //{
        //    //return var student = await _StudentRepository
        //}

        public Task<BaseResponse<StudentDto>> UpdateStudent(int id, UpdateStudentRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
