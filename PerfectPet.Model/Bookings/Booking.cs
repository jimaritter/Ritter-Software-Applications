using System;
using System.Collections.Generic;
using NHibernate;
using PerfectPet.Model.Kennels;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Bookings
{
    public class Booking : Business<Booking>, IBooking
    {
        private readonly IBooking _booking;
        protected ISession _session = null;

        public virtual int Id { get; set; }
        public virtual string Summary { get; set; }
        public virtual string Location { get; set; }
        public virtual string Description { get; set; }
        public virtual int BackgroundId { get; set; }
        public virtual int StatusId { get; set; }
        public virtual int RecurrenceId { get; set; }
        public virtual int ResourceId { get; set; }
        public virtual int NumberOfDays { get; set; }
        public virtual IList<Kennel> Kennels { get; set; }
        public virtual IList<Pet> Pet { get; set; }
        public virtual Person Person { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual ScheduleType ScheduleType { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public Booking()
        {
            
        }

        //public Booking(IBooking booking)
        //{
        //    _booking = booking;
        //}

        public Booking Get()
        {
            return new Booking();
        }

        public IList<Booking> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var schedulelist = _session.CreateCriteria(typeof(Booking)).List<Booking>();
                return schedulelist;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public Booking GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var schedule = repository.GetById(typeof(Booking), id);
                    repository.CommitTransaction();
                    return schedule as Booking;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            } 
        }

        public void Save(Booking booking)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(booking);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Booking booking)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(booking);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }
    }
}
