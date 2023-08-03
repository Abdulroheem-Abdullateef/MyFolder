using LearningManagementSystem.Context.EfConfiguration;
using LearningManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LearningManagementSystem.Context
{
    public class LearningApplicationContext : DbContext
    {
        public LearningApplicationContext(DbContextOptions <LearningApplicationContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses  { get; set; }
        public DbSet<Instructor> Instructors  { get; set; }
        public DbSet<Student> Students { get; set; }


    }
}
