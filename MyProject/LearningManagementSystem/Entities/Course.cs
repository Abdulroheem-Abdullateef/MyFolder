using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set;}
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    }
}
