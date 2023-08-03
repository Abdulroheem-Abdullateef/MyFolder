using JWTPractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JWTPractice.Interfaces.IRepository
{
    public interface IStudentRepository
    {
        Task<Student> Create(Student student);
        Task<Student> Update(Student student);
        Task<Student> Get(int id);
        Task<IList<Student>> GetAll();
        bool Exists(Expression<Func<Student, bool>> expression);
        void Delete(Student student);
    }
}
