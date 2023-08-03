using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JWTPractice.Entities;

namespace JWTPractice.Interfaces.Repositories
{
   public interface ITeacherRepository
    {
        Task<Teacher> Create(Teacher teacher);
        Task<Teacher> Update(Teacher teacher);
        Task<Teacher> Get(int id);
        Task<IList<Teacher>> GetAll();
        void Delete(Teacher teacher);
        bool Exists(Expression<Func<Teacher, bool>> expression);


    }
}


