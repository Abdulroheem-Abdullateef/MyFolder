using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Dtos;

namespace TransportManagementSystem.Interfaces.IServices
{
    public interface ITripServices
    {
        public bool Create(CreateRequestTripModel trip);
        public bool UpdateTrip(UpdateRequestTripModel trip);
        void Delete(string tripreferenceNumber);
        public  List<TripDto> GetTripById(int id);
        public List<TripDto> GetTripByDate(DateTime date);
        public List<TripDto> CancelledaAllTripByDate(DateTime date);
        public List<TripDto> GetTripByRegistrationNumber(string registration);
        public List<TripDto> GetAllTrips();
       
    }
}
