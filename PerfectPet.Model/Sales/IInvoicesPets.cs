using System.Collections.Generic;

namespace PerfectPet.Model.Sales
{
    public interface IInvoicesPets
    {
        InvoicesPets Get();
        IList<InvoicesPets> GetAll();
        InvoicesPets GetById(int id);
        IEnumerable<InvoicesPets> GetByPetId(int id);
        void Save(InvoicesPets invoicesPets);
        void Delete(InvoicesPets invoicesPets);
    }
}