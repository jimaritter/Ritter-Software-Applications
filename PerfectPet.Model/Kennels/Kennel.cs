using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Kennels
{
    public class Kennel : Business<Kennel>, IKennel
    {
        private readonly IKennel _kennel;
        protected ISession _session = null;

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Size { get; set; }
        public virtual bool Available { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public Kennel()
        {
            
        }

        //public Kennel(IKennel kennel)
        //{
        //    _kennel = kennel;
        //}

        public Kennel Get()
        {
            return this;
        }

        public IList<Kennel> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var kennellist = _session.CreateCriteria(typeof(Kennel)).List<Kennel>();
                return kennellist;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public Kennel GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var kennel = repository.GetById(typeof(Kennel), id);
                    repository.CommitTransaction();
                    return kennel as Kennel;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Save(Kennel kennel)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(kennel);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Kennel kennel)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(kennel);
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
