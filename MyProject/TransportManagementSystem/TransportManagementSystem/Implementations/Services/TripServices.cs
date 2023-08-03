using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Dtos;
using TransportManagementSystem.Entities;
using TransportManagementSystem.Implementations.Repositories;
using TransportManagementSystem.Interfaces.IRepositories;
using TransportManagementSystem.Interfaces.IServices;

namespace TransportManagementSystem.Implementations.Services
{
    public class TripServices : ITripServices 
    {
        private readonly TripRepository _tripRepository;
        private readonly BusRepository _busRepository;
        private readonly DriverRepository _driverRepository;

        public TripServices()
        {
            _tripRepository = new TripRepository();
            _busRepository = new BusRepository();
            _driverRepository = new DriverRepository();
        }

        public List<TripDto> CancelledaAllTripByDate(DateTime date)
        {
            var trip = _tripRepository.GetTripDate(date);
            if (trip == null)
            {
                throw new KeyNotFoundException("Not found");

            }
            return trip;
           
        }

        public bool Create(CreateRequestTripModel trip)
        {
            var trips = new CreateRequestTripModel
            {
                Distination = trip.Distination,
                DriverLiceseNumber = trip.DriverLiceseNumber,
                LandingTime = trip.LandingTime,
                TripStatus = trip.TripStatus,
                TakeOfPoint = trip.TakeOfPoint,
                TakeOfTime = trip.TakeOfTime,
                Price = trip.Price,

            };
            return true;
        }

       
        public void Delete(string tripreferencenumber)
        {
             _tripRepository.GetAllTripByReference(tripreferencenumber);
            
        }

        public List<TripDto> GetAllTrips()
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetTripByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetTripById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TripDto> GetTripByRegistrationNumber(string registration)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTrip(UpdateRequestTripModel trip)
        {
            throw new NotImplementedException();
        }

       
    }
}
