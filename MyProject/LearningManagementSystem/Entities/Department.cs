using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public ICollection <Student> Students { get; set; } = new List<Student>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Instructor> Instructors{ get; set; } = new List<Instructor>();


    }
}
