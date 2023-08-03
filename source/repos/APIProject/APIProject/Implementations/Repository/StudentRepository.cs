using APIProject.Context;
using APIProject.Entities;
using APIProject.Interfaces.IPersonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Implementations.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationContext _cotext;
        public StudentRepository( ApplicationContext context)
        {
            _cotext = context;
        }
        public Student Create(Student student)
        {
            _cotext.Students.Add(student);
            _cotext.SaveChanges();
            return student;
        }

        public void Delete(Student student)
        {
            _cotext.Students.Remove(student);
            _cotext.SaveChanges();

        }

        public IList<Student> GetAllStudents()
        {
            return  _cotext.Students.ToList();

        }

        public Student GetStudent(int id)
        {
            return _cotext.Students.Find(id);
        }

        public Student Update(Student student)
        {
            _cotext.Students.Update(student);
            _cotext.SaveChanges();
            return student;
        }
    }
}
