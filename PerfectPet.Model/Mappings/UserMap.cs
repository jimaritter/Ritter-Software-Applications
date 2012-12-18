using FluentNHibernate.Mapping;
using PerfectPet.Model.Users;

namespace PerfectPet.Model.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Not.LazyLoad();
            Id(x => x.Id).GeneratedBy.HiLo("1001");
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
            Map(x => x.Active);
            Map(x => x.RoleId);
            References(x => x.Person);
        }
    }
}
