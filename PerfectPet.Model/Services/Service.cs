using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Services
{
    public class Service : Business<Service>, IService
    {
        private readonly IService _service;
        protected ISession _session = null;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual bool Active { get; set; }
        public virtual double Cost { get; set; }
        public virtual double Retail { get; set; }
        public virtual bool TaxExempt { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public Service()
        {
            
        }

        public Service(IService service)
        {
            _service = service;
        }


        public Service Get()
        {
            return new Service();
        }

        public IList<Service> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var servicelist = _session.CreateCriteria(typeof(Service)).List<Service>();
                return servicelist;
            }
            catch (Exception)
            {

                throw;
            }   
        }

        public Service GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var service = repository.GetById(typeof(Service), id);
                    repository.CommitTransaction();
                    return service as Service;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            } 
        }

        public void Save(Service service)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(service);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Service service)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(service);
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
