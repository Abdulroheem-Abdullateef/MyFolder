using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JWTPractice.Context;
using JWTPractice.Entities;
using JWTPractice.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace JWTPractice.Implementations.Repository
{
    public class TeacherRepository : ITeacherRepository
    {

        protected ApplicationContext _context;

        public TeacherRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Teacher> Create(Teacher teacher)
        {
            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
            return teacher;
        }

        public void Delete(Teacher teacher)
        {
            _context.Teachers.Remove(teacher);

        }

        public bool Exists(Expression<Func<Teacher, bool>> expression)
        {
            return _context.Teachers.Any(expression);
        }

        public async Task<Teacher> Get(int id)
        {
          return await _context.Teachers.FindAsync(id);
           
        }

        public async Task<IList<Teacher>> GetAll()
        {
            return await _context.Teachers.Include(s => s.FirstName).ToListAsync();
        }

        public async Task<Teacher> Update(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
           await _context.SaveChangesAsync();
           return teacher;
        }
    }
}
