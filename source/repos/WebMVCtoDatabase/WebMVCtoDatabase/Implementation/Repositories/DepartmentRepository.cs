using StudentMVC.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Implementation.Repositories
{
    public class DepartmentRepository
    {
        private readonly ApplicationContext _context;

        public DepartmentRepository(ApplicationContext context  )
        {
            _context = context;
        }




    }
}
