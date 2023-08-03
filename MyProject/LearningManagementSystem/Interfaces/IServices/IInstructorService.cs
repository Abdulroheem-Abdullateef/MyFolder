using LearningManagementSystem.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Interfaces.Services
{
    public interface IInstructorService
    {
        bool CreateInstructor(CreateInstructorRequestModel model);
        bool UpdateInstructor(int id, UpdateInstructorRequestModel model);
        InstructorDto GetInstructor(int id);

        IList<InstructorDto> GetAllInstructors();
        InstructorDto GetInstructorByName(string name);
        void DeleteInstructor(int id);
        InstructorDto Login(LoginRequestModel model);

    }
}
