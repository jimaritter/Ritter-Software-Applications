using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Transform;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Sales
{
    public class InvoiceNumber : Business<InvoiceNumber>, IInvoiceNumber
    {
        protected ISession _session = null;
        public int Id { get; set; }
        public int Number { get; set; }

        public InvoiceNumber()
        {
            Id = 1;
        }

        public InvoiceNumber Get()
        {
            return new InvoiceNumber();
        }

        public IList<InvoiceNumber> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var invoiceNumber = _session.CreateCriteria(typeof(InvoiceNumber));
                return invoiceNumber.List<InvoiceNumber>();
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public InvoiceNumber GetById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }

                var invoiceNumber = _session.CreateCriteria(typeof(InvoiceNumber)).List<InvoiceNumber>();

                var query = from o in invoiceNumber
                            where o.Id == id
                            select o;
                return query.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(InvoiceNumber invoiceNumber)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Save(invoiceNumber);
                _session.Flush();
                _session.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Delete(InvoiceNumber invoiceNumber)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                _session.Delete(invoiceNumber);
                _session.Flush();
                _session.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public interface IInvoiceNumber
    {
        InvoiceNumber Get();
        IList<InvoiceNumber> GetAll();
        InvoiceNumber GetById(int id);
        void Save(InvoiceNumber invoiceNumber);
        void Delete(InvoiceNumber invoiceNumber);
    }
}
