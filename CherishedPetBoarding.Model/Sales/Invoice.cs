using System;
using System.Collections.Generic;
using CherishedPetBoarding.Model.Addresses;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Users;

namespace CherishedPetBoarding.Model.Sales
{
    public class Invoice : Business<Invoice>, IInvoice
    {
        private readonly IInvoice _invoice;
        public virtual int Id { get; set; }
        public virtual string Number { get; set; }
        public virtual string Description { get; set; }
        public virtual Address OriginAddress { get; set; }
        public virtual Address DestinationAddress { get; set; }
        public virtual DateTime InvoiceDate { get; set; }
        public virtual DateTime DeliveryDate { get; set; }
        public virtual IList<LineItem> LineItems { get; set; }
        public virtual Person Person { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
  

        public Invoice()
        {
        }

        public Invoice(IInvoice invoice)
        {
            _invoice = invoice;
        }

        public Invoice Get()
        {
            return this;
        }

        public IList<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public void Delete(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}