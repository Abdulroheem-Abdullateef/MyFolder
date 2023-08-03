using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Entities;

namespace TransportManagementSystem.Interfaces.IRepositories
{
    public interface IBookingRepository
    {
        Booking CreateBooking(Booking booking);
        void DeleteBooking(Booking id);
        Booking UpdateBooking(int id, Booking booking);
        Booking GetBooking(int id);
        IList<Booking> GetAllBooking();

    }
}
