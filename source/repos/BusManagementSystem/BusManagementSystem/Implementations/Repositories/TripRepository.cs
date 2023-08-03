using BusManagementSystem.contest;
using BusManagementSystem.Entities;
using BusManagementSystem.Interfaces;
using BusManagementSystem.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Repositorys
{
    class TripRepository : ITripRepository
    {
        private readonly ApplicationDBContext _application;

        public TripRepository()
        {
            _application = new ApplicationDBContext();
        }

        
        public Trip GetTrip(int id)
        {
            var trip = _application.Trips.Find(id);
            if (trip == null)
            {
                throw new KeyNotFoundException($"Bus with id:{id} does not exit");
            }
            return trip;
        }

        public void DeleteTrip(int id)
        {
            var bus = _application.Trips.Find(id);
            if (bus == null)
            {
                throw new KeyNotFoundException($"{bus.Id} does not exit");
            }

            else
            {
                _application.Trips.Remove(bus);
                _application.SaveChanges();
            }
        }


        public Trip Create(Trip bus)
        {
            _application.Add(bus);
            _application.SaveChanges();
            return bus;
        }

        public Trip Get(int id)
        {
            var trip = _application.Trips.Find(id);
            if (trip == null)
            {
                throw new KeyNotFoundException($"Bus with id:{id} does not exit");
            }
            return trip;
        }

        public List<Trip> GetAll()
        {
            return _application.Trips.ToList();
        }

        public Trip Update(Trip bus,int Id)
        {
            var b = _application.Trips.Find(Id);
            if (b == null)
            {

                throw new KeyNotFoundException($"{Id} does not exit");
            }

            else
            {
                b.Id = bus.Id;
                b.Bus = bus.Bus;
                b.BusId = bus.BusId;
                b.Driver = bus.Driver;
                b.DriverId = bus.DriverId;

            }

            _application.Update(b);
            _application.SaveChanges();
            return b;

        }

        public void Delete(Trip trip)
        {
               var bus = _application.Trips.Find(trip);
                if (bus == null)
                {
                    throw new KeyNotFoundException($"{bus.Id} does not exit");
                }

                else
                {
                    _application.Trips.Remove(trip);
                    _application.SaveChanges();
                }
            

        }

        public bool ExistById(int id)
        {
            return _application.Trips.Any(a => a.Id == id);
        }

        
    }
}           
