using APIProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Interfaces.IPersonRepository
{
    public interface IStudentRepository
    {
        Student Create(Student student);
        Student Update(Student student);
        void Delete(Student student);
        Student GetStudent(int id);
        IList<Student> GetAllStudents();

    }
}
