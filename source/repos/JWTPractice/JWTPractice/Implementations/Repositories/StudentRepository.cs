using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JWTPractice.Context;
using JWTPractice.Entities;
using JWTPractice.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;

namespace JWTPractice.Implementations.Repository
{
    public class StudentRepository : IStudentRepository
    {
      
        protected ApplicationContext _context;
        public StudentRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Student> Create(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);

        }

        public bool Exists(Expression<Func<Student, bool>> expression)
        {
            return _context.Students.Any(expression);
        }

        public async Task<Student> Get(int id)
        {
            return await _context.Students.FindAsync(id);
            
            
        }

        public async Task<IList<Student>> GetAll()
        {
            return await _context.Students.ToListAsync();
        }


        public async Task<Student> Update(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
            return student;
        }
    }
}
