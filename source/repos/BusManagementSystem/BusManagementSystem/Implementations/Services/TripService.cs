using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Services
{
    public class TripService : ITripService
    {
        private readonly TripService _application; 

        public TripService()
        {
            _application = new TripService();
        }
        
        public bool RegisterTrip(CreateTripRequest model)
        {
            var register = new Trip
            {

                LandingPoint = model.LandingPoint,
                LandingTime = model.LandingTime,
                TakeOffPoint = model.TakeOfpoint,
                TakeOffTime = model.TakeOfTime,
                Price = model.Price,

            };
            return true;
        }

        public bool Updatetrip(string regNumber, UpdateTripRequest model)
        {
            var trip = _application.GetByRegNumber(regNumber);
            if (trip == null)
            {
                throw new KeyNotFoundException($"The registrationnumber {regNumber} does not exist");
            }

            _application.Updatetrip(regNumber,model);
            return true;

        }

        public bool ChangeTripStatus(string regNumber, bool tripStatus)
        {  
            throw new NotImplementedException();
        }

        public bool ChangeAvailabilityStatus(string regNumber, bool availabilityStatus)
        {
            var trip = _application.ChangeTripStatus(regNumber)
        }

        public bool DeleteTrip(string regNumber)
        {
            throw new NotImplementedException();
        }

        public IList<TripDto> List()
        {
            throw new NotImplementedException();
        }

        public TripDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TripDto GetByRegNumber(string RegNumber)
        {
            throw new NotImplementedException();
        }

    }


}   
