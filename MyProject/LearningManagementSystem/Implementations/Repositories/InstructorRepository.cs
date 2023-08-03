using LearningManagementSystem.Context;
using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Implementations.Repositories
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly LearningApplicationContext _context;

        public InstructorRepository( LearningApplicationContext context)
        {
            _context = context;
        }

        public Instructor CreateInstructor(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
            return instructor;
        }

        public void Delete(Instructor instructor)
        {
            _context.Instructors.Remove(instructor);
            _context.SaveChanges();

        }

        public List<Instructor> GetAllInstructor()
        {
            return _context.Instructors.ToList();   
        }

        public Instructor GetInstructorByEmail(string email)
        {
            return _context.Instructors.SingleOrDefault(a => a.Email == email);
        }

        public Instructor GetInstructor(int id)
        {
            return _context.Instructors.Find(id);
        }

        public bool InstructorExists(string instructorName)
        {
            _context.Instructors.Find(instructorName);
            return true;
        }

       
        public Instructor UpdateInstructor(Instructor instructor)
        {
            _context.Instructors.Update(instructor);
            _context.SaveChanges();
            return instructor;
        }

        public Instructor GetByName(string name)
        {
            return _context.Instructors.SingleOrDefault(a => a.FirstName == name);
        }
    }
}
