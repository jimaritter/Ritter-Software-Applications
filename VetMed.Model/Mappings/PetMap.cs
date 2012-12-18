using System;
using System.Linq;
using FluentNHibernate.Mapping;
using VetMed.Model.Pets;

namespace VetMed.Model.Mappings
{
    public class PetMap : ClassMap<Pet>
    {
        public PetMap()
        {
            Id(x => x.Id);
            Map(x => x.Name)
                .Length(50)
                .Not.Nullable();
            Map(x => x.Sex)
                .Length(1)
                .Not.Nullable();
            Map(x => x.DateOfBirth)
                .Length(10)
                .Not.Nullable();
            Map(x => x.DateOfDeath)
                .Length(10);
            References(x => x.Breed)
                .Not.Nullable();
            References(x => x.Person)
            .Not.Nullable();
            References(x => x.MedicalRecord)
            .Not.Nullable();
            Map(x => x.Active)
                .Length(1)
                .Not.Nullable();
            Map(x => x.AddedBy)
                .Length(15);
            Map(x => x.AddedDate)
                .Length(20);
            Map(x => x.ModifiedBy)
                .Length(15);
            Map(x => x.ModifiedDate)
                .Length(20);    
        }
    }
}
