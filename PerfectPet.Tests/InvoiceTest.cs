using System;
using NUnit.Framework;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Companies;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Repository;
using PerfectPet.Model.Sales;
using StructureMap;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class InvoiceTest
    {
        private IInvoice _invoice;

        [SetUp]
        public void Init()
        {
            ContainerBootstrapper.BootstrapStructuremap();
            _invoice = new Invoice();
        }

        [Test]
        public void can_get_invoices_pets()
        {
            try
            {
                var _invoicestests = ObjectFactory.GetInstance<IInvoicesPets>();
                var invoicestests = _invoicestests.Get();
                Assert.IsNotNull(_invoicestests);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        [Test]
        public void can_get_all_people()
        {
            try
            {
                var _people = ObjectFactory.GetInstance<IPerson>();
                var people = _people.GetAll();
                Assert.IsNotNull(people);
                foreach (var person in people)
                {
                   Console.WriteLine(person.Id + " - " + person.FirstName + " " + person.LastName); 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Test]
        public void can_delete_invoice()
        {
            try
            {
                var _invoice = ObjectFactory.GetInstance<IInvoice>();
                var invoice = _invoice.GetById(14028);
                Assert.IsNotNull(invoice);
                _invoice.Delete(invoice);
            }
            catch (Exception)
            {
                
                throw;
            }    
        }

        [Test]
        public void can_get_invoice_details()
        {
            try
            {
                var _invoice = ObjectFactory.GetInstance<IInvoice>();

                var invoice = _invoice.GetAllByInvoiceId(19038);
                Assert.IsNotNull(invoice);
                foreach (var item in invoice)
                {
                    Console.WriteLine("Invoice Number: " + item.Number);
                    var pets = item.Pets;
                    foreach (var o in pets)
                    {
                        Console.WriteLine("Pet: " + o.Name);
                    }
                }
                //person = invoice.Person;
                //var pets = invoice.Pets;
                //foreach (var item in pets)
                //{
                //    Console.WriteLine(item.Name);
                //}
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        [Test]
        public void can_add_new_invoice()
        {
            var petIds = new[] { 9018, 13026 };
            var _pet = ObjectFactory.GetInstance<Pet>();
            var pet = _pet.GetByMultiplePets(petIds);

            var company = ObjectFactory.GetInstance<ICompany>();
            var address = ObjectFactory.GetInstance<IAddress>();
            var person = ObjectFactory.GetInstance<IPerson>();

            var _invoice = ObjectFactory.GetInstance<IInvoice>();
            var invoice = _invoice.Get();
            invoice.Number = "75619";
            invoice.Description = "Boarding Abby for 12 days.";
            invoice.InvoiceDate = DateTime.Now;
            invoice.DeliveryDate = DateTime.Now.AddDays(3);
            invoice.CreatedDate = DateTime.Now;
            invoice.Company = company.GetById(1002) as Company;
            invoice.InvoiceAddress = address.GetById(8016) as Address;
            invoice.Person = person.GetById(6012) as Person;
            foreach (var item in pet)
            {
                invoice.Pets.Add(item);
            }
            _invoice.Save(invoice);
        }

        [TearDown]
        public void Cleanup()
        {
            
        }
    }
}
