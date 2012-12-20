using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Transform;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Sales
{
    public class InvoiceToPet : Business<InvoiceToPet>, IInvoiceToPet
    {
        private readonly IInvoiceToPet _invoiceToPet;

        protected ISession _session = null;
        public int Id { get; set; }
        public Invoice Invoice { get; set; }
        public Pet Pet { get; set; }


        public InvoiceToPet()
        {
            
        }

        public InvoiceToPet(IInvoiceToPet invoiceToPet)
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
                var invoicetopetlist = _session.CreateCriteria(typeof(InvoiceToPet)).List<InvoiceToPet>();
                return invoicetopetlist;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public IEnumerable<InvoiceToPet> GetAllByInvoiceId(int invid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var invoicetopetlist = _session.CreateCriteria(typeof(InvoiceToPet)).List<InvoiceToPet>();

                var query = from item in invoicetopetlist
                            where item.Invoice.InvoiceId == invid
                            select item;

                return query;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public InvoiceToPet GetById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var invoicetopetlist = _session.CreateCriteria(typeof(InvoiceToPet)).List<InvoiceToPet>();

                var query = from item in invoicetopetlist
                            where item.Invoice.InvoiceId == id
                            select item;

                return query.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public void Save(InvoiceToPet invoiceTopet)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Transaction.Begin();
                _session.Save(invoiceTopet);
                _session.Transaction.Commit();
                _session.Flush();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(InvoiceToPet invoiceTopet)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Transaction.Begin();
                _session.Delete(invoiceTopet);
                _session.Transaction.Commit();
                _session.Flush();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
