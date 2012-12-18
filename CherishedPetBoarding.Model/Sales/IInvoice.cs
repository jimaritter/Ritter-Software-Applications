using System.Collections.Generic;

namespace CherishedPetBoarding.Model.Sales
{
    public interface IInvoice
    {
        Invoice Get();
        IList<Invoice> GetAll();
        void Save(Invoice invoice);
        void Delete(Invoice invoice);
    }
}