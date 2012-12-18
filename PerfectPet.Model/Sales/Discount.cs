using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Sales
{
    public class Discount : Business<Discount>, IDiscount
    {
        private readonly IDiscount _discount;
        protected ISession _session = null;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }

        public Discount()
        {
            
        }

        public Discount(IDiscount discount)
        {
            _discount = discount;
        }

        public Discount Get()
        {
            return new Discount();
        }

        public IList<Discount> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var discountlist = _session.CreateCriteria(typeof(Discount)).List<Discount>();
                return discountlist;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public Discount GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var discount = repository.GetById(typeof(Discount), id);
                    repository.CommitTransaction();
                    return discount as Discount;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Save(Discount discount)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(discount);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Discount discount)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(discount);
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
