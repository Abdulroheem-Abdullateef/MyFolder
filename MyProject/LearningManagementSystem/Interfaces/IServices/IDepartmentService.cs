using LearningManagementSystem.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Interfaces.Services
{
    public interface IDepartmentService
    {
        bool CreateDepartment(CreateDepartmentRequestModel model);
        bool UpdateDepartment(int id, UpdateDepartmentRequestModel model);
        DepartmentDto GetDepartment(int id);
        IList<DepartmentDto> GetAllDepartments();
        void DeleteDepartment(int id);
        
    }
}
