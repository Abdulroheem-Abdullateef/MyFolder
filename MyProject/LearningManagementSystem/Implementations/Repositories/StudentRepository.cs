using LearningManagementSystem.Context;
using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Implementations.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly LearningApplicationContext _context;

        public StudentRepository(LearningApplicationContext context)
        {
            _context = context;
        }
        public Student CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public void DeleteStudent(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
            
        }

        public List<Student> GetAllStudent()
        {
            return _context.Students
                .Include(d => d.Department)
                .Include(s => s.StudentCourses)
                .ThenInclude(c => c.Course).ToList();
        }

        public Student GetStudent(int id)
        {
            return _context.Students
                .Include(d => d.Department)
                .Include(s => s.StudentCourses)
                .ThenInclude(c => c.Course)
                .SingleOrDefault(i => i.Id == id);
        }

        public Student GetStudentByEmail(string email)
        {
          return  _context.Students.Include(d => d.Department)
                .Include(s => s.StudentCourses).
                ThenInclude(c => c.Course).
                SingleOrDefault(e => e.Email == email);
        }

       
        public Student UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return student;
        }
    }
}
