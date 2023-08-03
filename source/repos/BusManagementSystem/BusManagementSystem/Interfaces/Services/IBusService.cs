using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using System.Collections.Generic;

namespace BusManagementSystem.Services
{
    interface IBusService
    {
        public bool Register(CreateBusRequestModel model);

        public bool Update(string regNumber, UpdateBusRequestModel model);

        public bool ChangeTripStatus(string regNumber, bool tripStatus);

        public bool ChangeAvailabilityStatus(string regNumber, bool availabilityStatus);

        public bool Delete(string regNumber);

        public IList<BusDto> List();

        public BusDto GetById(int id);

        public BusDto GetByRegNumber(string RegNumber);
    }
}