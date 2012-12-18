using System.Collections.Generic;

namespace PerfectPet.Model.Bookings
{
    public interface IDeparture
    {
        Departure Get();
        IList<Departure> GetAll();
        Departure GetById(int id);
        void Save(Departure departure);
        void Delete(Departure departure);
    }
}