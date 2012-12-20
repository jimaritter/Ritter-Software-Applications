using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Bookings;
using PerfectPet.Model.Companies;
using PerfectPet.Model.Kennels;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Phones;
using PerfectPet.Model.Products;
using PerfectPet.Model.Sales;
using PerfectPet.Model.Services;
using PerfectPet.Model.Workorders;
using StructureMap;

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
                x.For<IProduct>().Singleton().Use(() => new Product());
                x.For<IWorkorder>().Singleton().Use(() => new Workorder());
                x.For<IInvoice>().Singleton().Use(() => new Invoice());
                x.For<IInvoiceNumber>().Singleton().Use(() => new InvoiceNumber());
                x.For<IInvoice>().Singleton().Use(() => new Invoice());
                x.For<ILineItem>().Singleton().Use(() => new LineItem());
            });

        }
    }
}
