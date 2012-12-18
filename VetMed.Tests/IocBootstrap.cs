using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using VetMed.Model.Pets;

namespace VetMed.Tests
{
    public static class IocBootstrap
    {
        public static void SetupForIoc()
        {
            ObjectFactory.Initialize(x =>
                                         {
                                             x.Scan(                                                 
                                                 scanner =>
                                                     {
                                                         scanner.TheCallingAssembly();
                                                         scanner.AssemblyContainingType<IPet>();
                                                         scanner.WithDefaultConventions();
                                                     }                                            
                                                        );
                                         });
        }
    }
}
