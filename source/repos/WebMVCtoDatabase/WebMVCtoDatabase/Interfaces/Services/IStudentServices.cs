using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Interfaces.Services
{
    public interface IStudentServices
    {
        bool AddStudent(CreateStudentDto createStudent);
        bool UpdateStudent();
        bool CreateStudent();
    }
}
