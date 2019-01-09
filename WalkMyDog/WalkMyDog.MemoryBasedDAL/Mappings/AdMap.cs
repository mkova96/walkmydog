using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkMyDog.Model;

namespace WalkMyDog.MemoryBasedDAL.Mappings
{
    class AdMap : ClassMap<Ad>
    {
        public AdMap()
        {
            Table("Ad");
            UseUnionSubclassForInheritanceMapping();

            Id(b => b.Id).Column("Id").CustomType("Int32").GeneratedBy.HiLo("1000");
            Map(b => b.Price).Column("Price").CustomType("Double").Not.Nullable().Length(50);
            Map(b => b.AdStatus).Column("AdStatus").CustomType<AdStatus>().Not.Nullable().Length(50);
            Map(b => b.Title).Column("Title").CustomType("String").Not.Nullable().Length(50);
            Map(b => b.Description).Column("Description").CustomType("String").Not.Nullable().Length(500);
            Map(b => b.Date).Column("Date").CustomType("datetime").Not.Nullable();
            Map(b => b.Hours).Column("Hours").CustomType("Int32").Not.Nullable();
            Map(b => b.DogsNumber).Column("DogsNumber").CustomType("Int32").Not.Nullable();

        }
    }

    class WalkerAdMap : SubclassMap<WalkerAd>
    {
        public WalkerAdMap()
        {
            Table("WalkerAd");
            Abstract();
            References(b => b.Walker, "WalkerId").Not.LazyLoad().Cascade.None();

        }
    }

    class OwnerAdMap : SubclassMap<OwnerAd>
    {
        public OwnerAdMap()
        {
            Table("OwnerAd");
            Abstract();

            References(b => b.Owner, "OwnerId").Not.LazyLoad().Cascade.None();
        }
    }
}
