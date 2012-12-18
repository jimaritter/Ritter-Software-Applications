using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Pets;

namespace PerfectPet.Model.Mappings
{
    public class MedicationMap : ClassMap<Medication>
    {
        public MedicationMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.Directions);
            Map(x => x.Quantity);
            References(x => x.Pet);
            Map(x => x.CreatedDate);
        }
    }
}
