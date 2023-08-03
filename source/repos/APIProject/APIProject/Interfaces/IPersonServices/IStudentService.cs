using APIProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Interfaces.IPersonServices
{
    public interface IStudentService
    {
        bool AddStudent(CreateStudentRequestModel model);
        bool UpdateStudent(int id, UpdateStudentRequestModel model);

        void DeleteStudent(int id);
        StudentDto GetStudent(int id);
        IList<StudentDto> GetAllStudent();


    }
}
