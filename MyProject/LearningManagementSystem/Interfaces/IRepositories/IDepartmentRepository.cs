using LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Interfaces.Repositories
{
    public interface IDepartmentRepository
    {
        Department CreateDepartment(Department department);
        Department UpdateDepartment(Department department);
        Department GetDepartment(int id);
        IList<Department> GetAllDepartment();

        void Delete(Department department);
    }
}

