using LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.DTOs
{
    public class DepartmentDto
    {

        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<StudentDto> Students { get; set; } = new List<StudentDto>();
        public ICollection<CourseDto> Courses { get; set; } = new List<CourseDto>();
        public ICollection<InstructorDto> Instructors { get; set; } = new List<InstructorDto>();

    }

    public class CreateDepartmentRequestModel
    {
        public string DepartmentName { get; set; }
      
    }


    public class UpdateDepartmentRequestModel
    {
        public string DepartmentName { get; set; }

    }

}
