using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApplicationMVC.Entities;

namespace WebApplicationMVC.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Person> Persons { get; set; } 
        public DbSet<City>  Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CityPerson> CityPersons { get; set; }
    }
}
