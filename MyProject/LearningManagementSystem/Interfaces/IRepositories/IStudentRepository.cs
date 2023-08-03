using LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        Student CreateStudent(Student student);
        Student UpdateStudent(Student student);
        Student GetStudent(int id);
        List<Student> GetAllStudent();
        void DeleteStudent(Student student);
        Student GetStudentByEmail(string email);

   
    }
}
