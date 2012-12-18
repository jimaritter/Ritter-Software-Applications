using System;
using System.Collections.Generic;
using NHibernate;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Bookings
{
    public class Departure : Business<Departure>, IDeparture
    {
        private readonly IDeparture _departure;
        protected ISession _session = null;

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Pet Pet { get; set; }
        public virtual DateTime ArriveDate { get; set; }
        public virtual DateTime CreatedDate { get; set; }



        public Departure()
        {
            
        }

        //public Departure(IDeparture departure)
        //{
        //    _departure = departure;
        //}

        public Departure Get()
        {
            return new Departure();
        }

        public IList<Departure> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var departurelist = _session.CreateCriteria(typeof(Departure)).List<Departure>();
                return departurelist;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public Departure GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var departure = repository.GetById(typeof(Departure), id);
                    repository.CommitTransaction();
                    return departure as Departure;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Save(Departure departure)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(departure);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Departure departure)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(departure);
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
