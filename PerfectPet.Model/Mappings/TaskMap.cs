using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Tasks;

namespace PerfectPet.Model.Mappings
{
    public class TaskMap : ClassMap<Task>
    {
        public TaskMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.StartDate);
            Map(x => x.EndDate);
            Map(x => x.Completed);
            Map(x => x.CreatedDate);            
        }
    }
}
