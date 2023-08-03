using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Dtos;
using TransportManagementSystem.Entities;
using TransportManagementSystem.Enums;

namespace TransportManagementSystem.Interfaces.IRepositories
{
    public interface ITripRepository
    { 
        Trip UpdateTrip( Trip trip);
        Trip GetTripById(int Id);
        void DeleteTrip(Trip trip);
        Trip CreateTrip(Trip trip);
        List<Trip> GetAllTrip();
        bool ExistByTripId(int id);
        Trip GetAllTripByReference(string tripreferencenumber);
        public List<TripDto> TripTakeOffLocationAndLandingPointAndTime(Location from, Location to, DateTime time);
        public List<Trip> GetAvailableTrips(Location from, Location to, DateTime time);
        public List<TripDto> GetTripByDriverId(int driverid);
        public List<Trip> CancelledTripByDate(DateTime date);
        public List<TripDto> GetInitailisedTrip();
        public List<TripDto> GetTripDate(DateTime date);
       

    }
}
