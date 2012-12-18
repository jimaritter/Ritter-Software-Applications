using StaticConsulting.Model.Products;
using StaticConsulting.Model.Services;
using StaticConsulting.Web.Infrastructure;
using StructureMap;
namespace StaticConsulting.Web {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IProduct>().HttpContextScoped().Use<MasterDb>();
                            x.For<IService>().HttpContextScoped().Use<MasterDb>();
                        });
            return ObjectFactory.Container;
        }
    }
}