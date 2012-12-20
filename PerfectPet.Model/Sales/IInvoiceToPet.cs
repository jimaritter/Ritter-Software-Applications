using System.Collections.Generic;

namespace PerfectPet.Model.Sales
{
    public interface IInvoiceToPet
    {
        InvoiceToPet Get();
        IList<InvoiceToPet> GetAll();
        IEnumerable<InvoiceToPet> GetAllByInvoiceId(int invid);
        InvoiceToPet GetById(int id);
        void Save(InvoiceToPet invoiceTopet);
        void Delete(InvoiceToPet invoiceTopet);
    }
}