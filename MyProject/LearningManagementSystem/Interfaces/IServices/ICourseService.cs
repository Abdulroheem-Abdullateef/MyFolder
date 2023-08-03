using LearningManagementSystem.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Interfaces.Services
{
    public interface ICourseService
    {
        bool CreateCourse(CreateCourseRequestModel model);
        bool UpdateCourse(int id, UpdateCourseRequestModel model);
        CourseDto GetCourse(int id);

        IList<CourseDto> GetAllCourses();

        void DeleteCourse(int id);



    }
}
