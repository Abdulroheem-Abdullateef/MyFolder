using MVCConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Interfaces.Repositories
{
    public interface IDepartmentRepository
    {
        Department Create(Department department);
        void Delete(Department department);
        Delegate UpdateDepartment(Department department);
        Department Get(Department department);


        
    }
}
