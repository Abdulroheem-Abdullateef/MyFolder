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
    public class BookingRepository : IBookingRepository
    {

        private readonly TransportManagementContext _context;

        public  BookingRepository()
        {
            _context = new TransportManagementContext();
        }

        public Booking CreateBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
            return booking;
        }

        public void DeleteBooking(Booking id)
        {
            _context.Bookings.Remove(id);
            _context.SaveChanges();
        }

        public Booking UpdateBooking(int id, Booking booking)
        {
            _context.Bookings.Find(id);
            _context.Bookings.UpdateRange(booking);
            _context.SaveChanges();
            return booking;
        }

        public Booking GetBooking(int id)
        {
            return _context.Bookings.Find(id);
        }

        public IList<Booking> GetAllBooking()
        {
            return _context.Bookings.ToList();
        }

        
    }
}
