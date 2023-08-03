using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Entities;

namespace TransportManagementSystem.Interfaces.IRepositories
{
    public interface IPassengerRepository
    {
        Passenger CreatePassenger(Passenger passenger);
        void DeletePassenger(Passenger id);
        Passenger UpdatePassenger(int id, Passenger passenger);
        IList<Passenger> GetAllPassenger();
        Passenger GetPassengerById(int id);
    }
}
