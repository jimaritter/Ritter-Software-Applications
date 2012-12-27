using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Transform;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Companies;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Phones;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Sales
{
    public class Invoice : Business<Invoice>, IInvoice
    {
        private readonly IInvoice _invoice;
        protected ISession _session = null;
        
        public virtual int InvoiceId { get; set; }
        public virtual string Number { get; set; }
        public virtual string Description { get; set; }
        public virtual Company Company { get; set; }
        public virtual Address InvoiceAddress { get; set; }
        public virtual Phone Phone { get; set; }
        public virtual DateTime InvoiceDate { get; set; }
        public virtual DateTime DeliveryDate { get; set; }
        public virtual Person Person { get; set; }
        public virtual bool Voided { get; set; }
        public virtual string VoidReason { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual double Discount { get; set; }
        public virtual double Tax { get; set; }
        public virtual double PriorBalance { get; set; }
        public virtual double TaxRate { get; set; }
        public virtual double DiscountRate { get; set; }

        public Invoice()
        {
        }

        public Invoice(IInvoice invoice)
        {
            _invoice = invoice;
        }

        public Invoice Get()
        {
            return new Invoice();
        }

        public IList<Invoice> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var invoice = _session.CreateCriteria(typeof(Invoice))
               .SetFetchMode("Pets", FetchMode.Eager)
               .SetResultTransformer(new DistinctRootEntityResultTransformer())
               .List<Invoice>();
                return invoice;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public IEnumerable<Invoice> GetAllByInvoiceId(int invid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var invoice = _session.CreateCriteria(typeof(Invoice))
               .SetFetchMode("Pets", FetchMode.Eager)
               .SetResultTransformer(new DistinctRootEntityResultTransformer())
               .List<Invoice>();

                var query = from inv in invoice
                            where inv.InvoiceId == invid
                            select inv;

                return query;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public Invoice GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var invoice = repository.GetById(typeof(Invoice), id);
                    repository.CommitTransaction();
                    return invoice as Invoice;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Save(Invoice invoice)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Transaction.Begin();
                _session.Save(invoice);
                _session.Transaction.Commit();
                _session.Flush();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Delete(Invoice invoice)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(invoice);
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