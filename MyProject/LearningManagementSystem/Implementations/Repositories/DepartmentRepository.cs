using LearningManagementSystem.Context;
using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Implementations.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly LearningApplicationContext _context;

        public DepartmentRepository( LearningApplicationContext context)
        {
            _context = context;
        }
        public Department CreateDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return department;
        }

        public void Delete(Department department)
        {
            _context.Departments.Remove(department);
            _context.SaveChanges();

        }

        public IList<Department> GetAllDepartment()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartment(int id)
        {
            return _context.Departments.Find(id);
        }

        public Department UpdateDepartment(Department department)
        {
             _context.Departments.Update(department);
            _context.SaveChanges();
            return department;
        }
    }
}
