using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Sales
{
    public class InvoicesPets : Business<InvoicesPets>, IInvoicesPets
    {
        private readonly IInvoicesPets _invoicesPets;
        public virtual int InvoicesPetsId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Pet Pet { get; set; }

        public InvoicesPets()
        {
            
        }

        public InvoicesPets(IInvoicesPets invoicesPets)
        {
            _invoicesPets = invoicesPets;
        }

        public InvoicesPets Get()
        {
            return new InvoicesPets();
        }

        public IList<InvoicesPets> GetAll()
        {
            throw new NotImplementedException();
        }

        public InvoicesPets GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoicesPets> GetByPetId(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(InvoicesPets invoicesPets)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(invoicesPets);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(InvoicesPets invoicesPets)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(invoicesPets);
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
