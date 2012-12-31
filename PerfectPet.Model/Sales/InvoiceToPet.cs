using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Sales
{
    public class InvoiceToPet : Business<InvoiceToPet>, IInvoiceToPet
    {
        private readonly IInvoiceToPet _invoiceToPet;
        protected ISession _session = null;

        public virtual int Id { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Pet Pet { get; set; }

        public InvoiceToPet()
        {

        }

        public InvoiceToPet(IInvoiceToPet  invoiceToPet)
        {
            _invoiceToPet = invoiceToPet;
        }

        public InvoiceToPet Get()
        {
            return new InvoiceToPet();
        }

        public IList<InvoiceToPet> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var list = _session.CreateCriteria(typeof(InvoiceToPet)).List<InvoiceToPet>();
                return list;
            }
            catch (Exception)
            {

                throw;
            }   
        }

        public InvoiceToPet GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var item = repository.GetById(typeof(InvoiceToPet), id);
                    repository.CommitTransaction();
                    return item as InvoiceToPet;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    return null;
                }
            }
        }

        public IList<InvoiceToPet> GetAllByInvoiceId(int invid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var list = _session.CreateCriteria(typeof(InvoiceToPet)).List<InvoiceToPet>();

                IEnumerable<InvoiceToPet> retlist = from p in list
                                           where p.Invoice.InvoiceId == invid
                                           select p;

                return retlist.ToList();

            }
            catch (Exception)
            {
                return null;
            }               
        }

        public void Save(InvoiceToPet invoiceToPet)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(invoiceToPet);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                }
            }
        }

        public void Delete(InvoiceToPet invoiceToPet)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(invoiceToPet);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                }
            }
        }
    }
}
