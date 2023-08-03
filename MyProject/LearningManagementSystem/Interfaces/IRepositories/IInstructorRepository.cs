
using LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Interfaces.Repositories
{
    public interface IInstructorRepository
    {
        Instructor CreateInstructor(Instructor instructor);
        Instructor UpdateInstructor(Instructor instructor);
        Instructor GetInstructor(int id);
        List<Instructor> GetAllInstructor();
        void Delete(Instructor instructor);
        Instructor GetByName(string name); 
        Instructor GetInstructorByEmail(string email);
        bool InstructorExists(string instructorName);
        
    }
}
