using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Bookings;
using PerfectPet.Model.Companies;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Products;
using PerfectPet.Model.Sales;
using PerfectPet.Model.Services;
using StructureMap;
using StructureMap.Pipeline;

namespace PerfectPet.Tests
{
    public static class ContainerBootstrapper
    {
        public static void BootstrapStructuremap()
        {
            //ObjectFactory.Configure(x => x.Scan(scan =>
            //                                        {
            //                                            scan.AssemblyContainingType<IAppointments>();
            //                                            scan.RegisterConcreteTypesAgainstTheFirstInterface();
            //                                        }));
            ObjectFactory.Initialize(x =>
                                         {
                                             x.For<IPet>().Singleton().Use<Pet>();
                                             x.For<IArrivalDeparture>().Singleton().Use<ArrivalDeparture>();
                                             x.For<IDogBreed>().Singleton().Use<DogBreed>();
                                             x.For<ICatBreed>().Singleton().Use<CatBreed>();
                                             x.For<IAppointments>().Singleton().Use(() => new Appointments());
                                             x.For<IResources>().Singleton().Use(() => new Resources());
                                             x.For<IProduct>().Singleton().Use(() => new Product());
                                             x.For<IService>().Singleton().Use(() => new Service());
                                             x.For<ICompany>().Singleton().Use(() => new Company());
                                             x.For<IInvoicesPets>().Singleton().Use(() => new InvoicesPets());
                                             x.For<IPerson>().Singleton().Use(() => new Person());
                                             x.For<IInvoice>().Singleton().Use(() => new Invoice());
                                             x.For<IAddress>().Singleton().Use(() => new Address());
                                             x.For<IInvoiceNumber>().Singleton().Use(() => new InvoiceNumber());
                                             x.For<IStatus>().Singleton().Use(() => new Status());
                                             x.For<IPetStatus>().Singleton().Use(() => new PetStatus());
                                            // x.For(typeof(IAppointments)).LifecycleIs(new HybridLifecycle()).Use(typeof(Appointments));

                                         });

        }
    }
}
