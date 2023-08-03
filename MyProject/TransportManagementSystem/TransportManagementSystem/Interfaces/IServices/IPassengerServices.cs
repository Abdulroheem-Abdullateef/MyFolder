using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Dtos;

namespace TransportManagementSystem.Interfaces.IServices
{
    public interface IPassengerServices
    {
        bool CreatePerson(CreateRequestPassengerModel passenger);
        bool Update(int id, UpdateRequestPassengerModel passenger);
        PassengerDto GetPassenger(int id);
        IList<PassengerDto> GetAllPassenger();
        void Delete(int id);

    }
}
