using ApiProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProject
{
    public class MyContext : DbContext
    {
        
          public MyContext(DbContextOptions<MyContext> options)
          : base(options)
        {
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Patient> Patients { get; set; }       
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<DoctorMedicalRecord> DoctorMedicalRecords {get; set;}
    }
}