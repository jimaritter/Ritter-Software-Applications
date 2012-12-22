using System.Collections.Generic;

namespace PerfectPet.Model.Sales
{
    public interface ILineItem
    {
        LineItem Get();
        IList<LineItem> GetAll();
        IList<LineItem> GetAllByInvoiceId(int invoiceId);
        LineItem GetById(int id);
        void Save(LineItem lineitem);
        void Delete(LineItem lineitem);
    }
}