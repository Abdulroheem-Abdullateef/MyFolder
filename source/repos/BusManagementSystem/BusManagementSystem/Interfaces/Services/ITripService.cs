using BusManagementSystem.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Services
{
    interface ITripService
    {
        public bool RegisterTrip(CreateTripRequest model);

        public bool Updatetrip(string regNumber, UpdateTripRequest model);

        public bool ChangeTripStatus(string regNumber, bool tripStatus);

        public bool ChangeAvailabilityStatus(string regNumber, bool availabilityStatus);

        public bool DeleteTrip(string regNumber);

        public IList<TripDto> List();

        public TripDto GetById(int id);

        public TripDto GetByRegNumber(string RegNumber);
    }
}
