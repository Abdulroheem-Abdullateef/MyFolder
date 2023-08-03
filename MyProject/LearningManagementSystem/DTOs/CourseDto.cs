using LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.DTOs
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int InstructorName { get; set; }
        public List<StudentDto> Students { get; set; } = new List<StudentDto>();


    }

    public class CreateCourseRequestModel
    {
        public string CourseName { get; set; }
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string CourseCode { get; set; }

    }

    public class UpdateCourseRequestModel
    {
        public string CourseName { get; set; }
    }
}
