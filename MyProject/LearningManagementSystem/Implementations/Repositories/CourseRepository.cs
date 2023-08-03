using LearningManagementSystem.Context;
using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Implementations.Repositories
{
    public class CourseRepository : ICourseRepository
    {

        private readonly LearningApplicationContext _context;

        public CourseRepository(LearningApplicationContext context)
        {
            _context = context;
        }

        public bool CourseExists(string courseName)
        {
            _context.Courses.Find(courseName);
            return true;
        }

        public Course CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        public void Delete(Course course)
        {
            _context.Courses.Remove(course);
            _context.SaveChanges();

        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public Course GetByCourseName(string courseName)
        {
            return _context.Courses.Find(courseName);
            
        }

        public Course GetCourse(int id)
        {
            return _context.Courses.Find(id);
        }

        public IEnumerable<Course> GetSelectedCourses(IList<int> ids)
        {
            return _context.Courses.Where(a => ids.Contains(a.Id)).ToList();
        }

        public Course UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
            return course;
        }
    }
}
