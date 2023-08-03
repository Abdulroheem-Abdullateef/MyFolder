using LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Interfaces.Repositories
{
    public interface ICourseRepository
    {
        Course CreateCourse(Course course);
        Course UpdateCourse(Course course);
        Course GetCourse(int id);
        List<Course> GetAllCourses();
        void Delete(Course course);
        Course GetByCourseName(string courseName);
        bool CourseExists(string courseName);
        IEnumerable<Course> GetSelectedCourses(IList<int> ids);
      
    }
}
