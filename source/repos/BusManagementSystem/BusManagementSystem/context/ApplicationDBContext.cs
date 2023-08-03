using BusManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.contest
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;database=BusesManagement;password=07067008860");
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
