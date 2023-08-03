using Google.Protobuf.Reflection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Context;
using TransportManagementSystem.Dtos;
using TransportManagementSystem.Entities;
using TransportManagementSystem.Enums;
using TransportManagementSystem.Interfaces.IRepositories;

namespace TransportManagementSystem.Implementations.Repositories
{
    public class TripRepository : ITripRepository
    {
        private readonly TransportManagementContext _context;

        public TripRepository()
        {
            _context = new TransportManagementContext(); 
        }

        public List<Trip> CancelledTripByDate(DateTime date)
        {
            return _context.Trips.Where(a => a.TakeOfTime == date).ToList();
            
        }

        public Trip CreateTrip(Trip trip)
        {
            _context.Trips.Add(trip);
            _context.SaveChanges();
            return trip;
        }

        public void DeleteTrip(Trip trip)
        {
            _context.Trips.Remove(trip);
            _context.SaveChanges();
            
        }

        public bool ExistByTripId(int id)
        {
            _context.Trips.Any(a => a.Id == id);
            return true;
        }

        public List<Trip> GetAllTrip()
        {
            return _context.Trips.ToList();
        }

        public Trip GetAllTripByReference(string tripreferencenumber)
        {
            return _context.Trips.SingleOrDefault(a => a.TripReference == tripreferencenumber);
        }

        public List<Trip> GetAvailableTrips(Location from, Location to, DateTime time)
        {
            return _context.Trips.Include(bus => bus.Bus).Include(driver => driver.Driver).Where(s => s.TakeOfPoint == from && s.Distination == to && s.TakeOfTime == time).ToList();
            
        }

        public List<TripDto> GetInitailisedTrip()
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetTripByDriverId(int driverid)
        {
            var trip = _context.Trips.Include(t => t.Bus).Include(t => t.Driver).Where(q => q.Driver.Id == driverid).Select(rent => new TripDto
            {
                TripReference = rent.TripReference,
                BusModel = rent.Bus.Model,
                BusId = rent.Bus.Id,
                FullName = $"{rent.Driver.FirstName}  {rent.Driver.LastName}",
                TakeOfPoint = rent.TakeOfPoint,
                TakeOfTime = rent.TakeOfTime,
                DriverId = rent.Driver.Id,
                Distination = rent.Distination,
                Price = rent.Price
            }).ToList();
            return trip;
        }

        public Trip GetTripById(int Id)
        {
            var trip = _context.Trips.Find(Id);
            return trip;
        }

        public List<TripDto> GetTripDate(DateTime date)
        {
            var trip = _context.Trips.Include(t => t.Bus).Include(t => t.Driver).Where(v => v.TakeOfTime == date).Select(rent => new TripDto
            {
                TripReference = rent.TripReference,
                BusModel = rent.Bus.Model,
                BusId = rent.Bus.Id,
                FullName = $"{rent.Driver.FirstName}  {rent.Driver.LastName}",
                TakeOfPoint = rent.TakeOfPoint,
                TakeOfTime = rent.TakeOfTime,
                DriverId = rent.Driver.Id,
                Distination = rent.Distination,
                Price = rent.Price
            }).ToList();
            return trip;
        }

        public List<TripDto> TripTakeOffLocationAndLandingPointAndTime(Location from, Location to, DateTime time)
        {
            throw new NotImplementedException();
        }

        public Trip UpdateTrip(Trip trip)
        {
            _context.Trips.Update(trip);
            _context.SaveChanges();
            return trip;
        }
    }
}
