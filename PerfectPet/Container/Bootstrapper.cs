using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Bookings;
using PerfectPet.Model.Companies;
using PerfectPet.Model.Inventories;
using PerfectPet.Model.Kennels;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Phones;
using PerfectPet.Model.Sales;
using PerfectPet.Model.Services;
using PerfectPet.Model.Tasks;
using StructureMap;
using Task = PerfectPet.Model.Tasks.Task;

namespace PerfectPet.Container
{
    public static class Bootstrapper
    {
        public static void BootstrapStructuremap()
        {
            ObjectFactory.Initialize(x =>
            {
                x.For<IPet>().Use<Pet>();
                x.For<IPerson>().Use<Person>();
                x.For<IAddress>().Use<Address>();
                x.For<IDogBreed>().Use<DogBreed>();
                x.For<ICatBreed>().Use<CatBreed>();
                x.For<IArrivalDeparture>().Use<ArrivalDeparture>();
                x.For<IKennel>().Use<Kennel>();
                x.For<IPhone>().Use<Phone>();
                x.For<IAppointments>().Singleton().Use(() => new Appointments());
                x.For<IResources>().Singleton().Use(() => new Resources());
                x.For<ICompany>().Singleton().Use(() => new Company());
                x.For<IAddress>().Singleton().Use(() => new Address());
                x.For<IService>().Singleton().Use(() => new Service());
                x.For<IInventory>().Singleton().Use(() => new Inventory());
                x.For<IInvoice>().Singleton().Use(() => new Invoice());
                x.For<IInvoiceNumber>().Singleton().Use(() => new InvoiceNumber());
                x.For<IInvoice>().Singleton().Use(() => new Invoice());
                x.For<ILineItem>().Singleton().Use(() => new LineItem());
                x.For<IMedication>().Singleton().Use(() => new Medication());
                x.For<IInvoiceToPet>().Singleton().Use(() => new InvoiceToPet());
                x.For<ITask>().Singleton().Use(() => new Task());
            });

        }
    }
}
