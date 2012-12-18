using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Addresses;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Sales;
using NUnit.Framework;

namespace CherishedPetBoarding.Test
{
    [TestFixture]
    public class InvoiceTest
    {
        private IInvoice _invoice;

        [SetUp]
        public void Init()
        { 
            _invoice = new Invoice();
        }

        [Test]
        public void can_add_new_invoice()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                     repository.BeginTransaction();
                     var invoice = _invoice.Get();
                     invoice.Number = "75619";
                     invoice.Description = "Boarding Abby for 12 days.";
                     invoice.InvoiceDate = DateTime.Now;
                     invoice.DeliveryDate = DateTime.Now.AddDays(3);
                     invoice.CreatedDate = DateTime.Now;
                     invoice.OriginAddress = repository.GetById(typeof(Address), 3006) as Address;
                     invoice.DestinationAddress = repository.GetById(typeof(Address), 3006) as Address;
                     invoice.Person = repository.GetById(typeof(Person), 1002) as Person;

                     repository.Save(invoice);
                    repository.CommitTransaction();
                        
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        [TearDown]
        public void Cleanup()
        {
            
        }
    }
}
