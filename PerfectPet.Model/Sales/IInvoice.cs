using System.Collections.Generic;

namespace PerfectPet.Model.Sales
{
    public interface IInvoice
    {
        Invoice Get();
        IList<Invoice> GetAll();
        IEnumerable<Invoice> GetAllByInvoiceId(int invid);
        Invoice GetById(int id);
        void Save(Invoice invoice);
        void Delete(Invoice invoice);
    }
}