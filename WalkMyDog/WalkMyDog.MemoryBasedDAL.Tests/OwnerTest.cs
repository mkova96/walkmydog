using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalkMyDog.MemoryBasedDAL.Repositories;
using WalkMyDog.Model;
using WalkMyDog.Model.Factories;

namespace WalkMyDog.MemoryBasedDAL.owners
{
    [TestClass]
    public class OwnerTest
    {

        [TestMethod]
        public void Owner_CreateOwner()
        {
            Owner Owner = (Owner)UserFactory.CreateOwner("Owner1234", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.OWNER);
            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            Owner walkie = repository.GetOwner("Owner1234");
            Debug.Assert(walkie.Equals(Owner));

            repository.DeleteUser(Owner);
        }


        [TestMethod]
        public void Owner_DeleteOwner()
        {
            Owner Owner = (Owner)UserFactory.CreateOwner("Owner123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.OWNER);
            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            repository.DeleteUser(Owner);
            Debug.Assert(repository.GetOwner("Owner123") == null);
        }

        [TestMethod]
        public void Owner_UpdateOwner()
        {
            Owner Owner = (Owner)UserFactory.CreateOwner("Owner1235", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.OWNER);
            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            Owner.City = "Sveti Petar u Sumi";
            repository.UpdateUser(Owner);

            Debug.Assert(repository.GetOwner("Owner1235").City.Equals("Sveti Petar u Sumi"));

            repository.DeleteUser(Owner);
        }

        [TestMethod]
        public void Owner_GetType()
        {
            Owner Owner = (Owner)UserFactory.CreateOwner("Owner123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.OWNER);
            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            Debug.Assert(Owner.UserType == UserType.OWNER);

            repository.DeleteUser(Owner);
        }

        [TestMethod]
        public void Owner_CreateOwnerAd()
        {
            Owner Owner = (Owner)UserFactory.CreateOwner("Owner123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.OWNER);
            OwnerAd OwnerAd = (OwnerAd)AdFactory.CreateOwnerAd(40.0, "Setam pse POVOLJNO", AdStatus.ACTIVE,
                "Obozavam pse", new DateTime(2019, 8, 28, 12, 5, 0), 3, 4, Owner);

            Owner.AddAd((OwnerAd)OwnerAd);

            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            Debug.Assert(OwnerAd.Equals(Owner.Ads[0]));
            repository.DeleteUser(Owner);

        }

        [TestMethod]
        public void Owner_UpdateOwnerAd()
        {
            Owner Owner = (Owner)UserFactory.CreateOwner("Owner123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.OWNER);
            OwnerAd OwnerAd = (OwnerAd)AdFactory.CreateOwnerAd(40.0, "Setam pse POVOLJNO", AdStatus.ACTIVE,
                "Obozavam pse", new DateTime(2019, 8, 28, 12, 5, 0), 3, 4, Owner);
            Owner.AddAd((OwnerAd)OwnerAd);

            AdRepository AdRepository = new AdRepository();

            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            OwnerAd.Title = "Setam pse POVOLJNO";
            AdRepository.UpdateAd(OwnerAd);
            repository.UpdateUser(Owner);

            Debug.Assert(Owner.Ads[0].Title.Equals("Setam pse POVOLJNO"));

            repository.DeleteUser(Owner);
        }

        [TestMethod]
        public void Owner_DeleteOwnerAd()
        {
            Owner Owner = (Owner)UserFactory.CreateOwner("OwnerDel", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.OWNER);
            OwnerAd OwnerAd = (OwnerAd)AdFactory.CreateOwnerAd(40.0, "Setam pse POVOLJNO", AdStatus.ACTIVE,
                       "Obozavam pse", new DateTime(2019, 8, 28, 12, 5, 0), 3, 4, Owner);

            Owner.AddAd((OwnerAd)OwnerAd);

            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            Owner.DeleteAd((OwnerAd)OwnerAd);

            Debug.Assert(Owner.Ads.Count == 0);

            repository.DeleteUser(Owner);
            System.Diagnostics.Debug.WriteLine("fdd");
        }
    }
}
