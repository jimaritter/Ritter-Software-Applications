using System;
using System.Collections.Generic;
using NHibernate;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Bookings
{
    public class ArrivalDeparture : Business<ArrivalDeparture>, IArrivalDeparture
    {
        private readonly IArrivalDeparture _arrivalDeparture;
        protected ISession _session = null;

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Notes { get; set; }
        public virtual Pet Pet { get; set; }
        public virtual string ArriveDate { get; set; }
        public virtual string DepartureDate { get; set; }
        public virtual string ArriveTime { get; set; }
        public virtual string DepartureTime { get; set; }
        public virtual bool CheckedIn { get; set; }
        public virtual bool CheckedOut { get; set; }
        public virtual Resources Resources { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public ArrivalDeparture()
        {
            
        }

        //public ArrivalDepartureDeparture(IArrivalDeparture ArrivalDepartureDeparture)
        //{
        //    _arrivalDeparture = ArrivalDepartureDeparture;
        //}

        public ArrivalDeparture Get()
        {
            return new ArrivalDeparture();
        }

        public IList<ArrivalDeparture> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var arrivallist = _session.CreateCriteria(typeof(ArrivalDeparture)).List<ArrivalDeparture>();
                return arrivallist;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        public ArrivalDeparture GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var arrival = repository.GetById(typeof(ArrivalDeparture), id);
                    repository.CommitTransaction();
                    return arrival as ArrivalDeparture;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Save(ArrivalDeparture arrivalDeparture)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(arrivalDeparture);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(ArrivalDeparture arrivalDeparture)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(arrivalDeparture);
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
