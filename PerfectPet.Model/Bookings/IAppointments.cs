using System;
using System.Collections.Generic;

namespace PerfectPet.Model.Bookings
{
    public interface IAppointments
    {
        Appointments Get();
        IList<Appointments> GetAll();
        Appointments GetById(int id);
        void Save(Appointments appointment);
        void Delete(Appointments appointment);
    }
}