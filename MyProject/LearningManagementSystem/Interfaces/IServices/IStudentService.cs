using LearningManagementSystem.DTOs;
using LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Interfaces.Services
{
    public interface IStudentService
    {
        bool CreateStudent(CreateStudentRequestModel model);
        bool UpdateStudent(int id, UpdateStudentRequestModel model);
        StudentDto GetStudent(int id);

        IList<StudentDto> GetAllStudents();
       
        void DeleteStudent(int id);

        StudentDto Login(LoginRequestModel model);

    }
}
