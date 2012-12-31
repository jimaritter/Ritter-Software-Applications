using System.Collections.Generic;

namespace PerfectPet.Model.Sales
{
    public interface IInvoiceToPet
    {
        InvoiceToPet Get();
        IList<InvoiceToPet> GetAll();
        InvoiceToPet GetById(int id);
        IList<InvoiceToPet> GetAllByInvoiceId(int invid); 
        void Save(InvoiceToPet invoiceToPet);
        void Delete(InvoiceToPet invoiceToPet);
    }
}