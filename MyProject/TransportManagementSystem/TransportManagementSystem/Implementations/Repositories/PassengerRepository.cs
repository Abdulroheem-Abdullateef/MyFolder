using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Context;
using TransportManagementSystem.Entities;
using TransportManagementSystem.Interfaces.IRepositories;

namespace TransportManagementSystem.Implementations.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly TransportManagementContext _context;

        public PassengerRepository()
        {
            _context = new TransportManagementContext();
        }


        public Passenger CreatePassenger(Passenger passenger)
        {
            _context.Passengers.Add(passenger);
            _context.SaveChanges();
            return passenger;
        }

        public void DeletePassenger(Passenger id)
        {
            _context.Passengers.Remove(id);
            _context.SaveChanges();

        }

        public IList<Passenger> GetAllPassenger()
        {
            return _context.Passengers.ToList();

        }

        public Passenger GetPassengerById(int id)
        {
            return _context.Passengers.Find(id);
        }

        public Passenger UpdatePassenger(int id, Passenger passenger)
        {
            _context.Passengers.Find(id);
            _context.Passengers.UpdateRange(passenger);
            _context.SaveChanges();
            return passenger;
        }
    }
}
