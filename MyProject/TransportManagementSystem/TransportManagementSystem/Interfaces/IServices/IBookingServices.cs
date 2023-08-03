using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementSystem.Dtos;

namespace TransportManagementSystem.Interfaces.IServices
{
    public interface IBookingServices
    {
        bool CreateBooking (CreateRequestBookingModel booking);
        bool UpdateBooking(int id, UpdateRequestBookingModel booking);
        BookingDto GetBooking(int id);
        IList<BookingDto> GetAllBooking();
        void Delete(int id);

    }
}
