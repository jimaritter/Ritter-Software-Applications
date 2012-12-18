using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using StructureMap.Configuration.DSL;

namespace VetMed.Tests
{
    interface IInitializationExpression
    {
        // Directives on how to treat the StructureMap.config file
        bool UseDefaultStructureMapConfigFile { set; }
        bool IgnoreStructureMapConfig { set; }

        // Xml configuration from the App.Config file
        bool PullConfigurationFromAppConfig { set; }

        // Ancillary sources of Xml configuration
        void AddConfigurationFromXmlFile(string fileName);
        void AddConfigurationFromNode(XmlNode node);

        // Specifying Registry's
        void AddRegistry<T>() where T : Registry, new();
        void AddRegistry(Registry registry);

        // Designate the Default Profile.  This will be applied as soon as the
        // Container is initialized.
        string DefaultProfileName { get; set; }

        // ... and the Registry DSL as well
    }
}
