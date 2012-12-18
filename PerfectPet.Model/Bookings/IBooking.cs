using System.Collections.Generic;

namespace PerfectPet.Model.Bookings
{
    public interface IBooking
    {
        Booking Get();
        IList<Booking> GetAll();
        Booking GetById(int id);
        void Save(Booking booking);
        void Delete(Booking booking);
    }
}