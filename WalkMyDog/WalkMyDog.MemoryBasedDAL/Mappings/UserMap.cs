using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkMyDog.Model;

namespace WalkMyDog.MemoryBasedDAL.Mappings
{
    class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("User");
            UseUnionSubclassForInheritanceMapping();
            Id(b => b.Id).Column("Id").CustomType("Int32").GeneratedBy.HiLo("1000");

            Map(b => b.Username).Column("Username").Not.Nullable().Length(50);
            Map(b => b.Password).Column("Password").Not.Nullable().Length(50);

            Map(b => b.Name).Column("Name").CustomType("String").Not.Nullable().Length(50);
            Map(b => b.Surname).Column("Surname").CustomType("String").Not.Nullable().Length(50);
            Map(b => b.UserType).Column("UserType").CustomType<UserType>().Not.Nullable().Length(10);

            Map(b => b.Address).Column("Address").CustomType("String").Not.Nullable().Length(50);
            Map(b => b.City).Column("City").CustomType("String").Not.Nullable().Length(50);
            Map(b => b.PhoneNumber).Column("PhoneNumber").CustomType("String").Not.Nullable().Length(50);
            Map(b => b.Age).Column("Age").CustomType("Int32").Not.Nullable();


        }
    }

    class OwnerMap : SubclassMap<Owner>
    {
        public OwnerMap()
        {
            Table("Owner");
            Abstract();

            HasMany(b => b.Ads).KeyColumn("AdId").Not.LazyLoad().Cascade.All();
        }
    }

    class WalkerMap : SubclassMap<Walker>
    {
        public WalkerMap()
        {
            Table("Walker");
            Abstract();

            HasMany(b => b.Ads).KeyColumn("AdId").Not.LazyLoad().Cascade.All();

            Map(b => b.Experience).Column("Experience").Not.Nullable();
            Map(b => b.Dogs).Column("Dogs").Not.Nullable();
        }
    }
}
