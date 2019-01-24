using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalkMyDog.MemoryBasedDAL.Repositories;
using WalkMyDog.Model;
using WalkMyDog.Model.Factories;

namespace WalkMyDog.MemoryBasedDAL.Tests
{
    [TestClass]
    public class WalkerTest
    {

        [TestMethod]
        public void Walker_CreateWalker()
        {
            Walker Walker = (Walker)UserFactory.CreateWalker("Walker123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.WALKER, true, false);
            UserRepository repository = new UserRepository();
            repository.AddUser(Walker);

            Walker walkie = repository.GetWalker("Walker123");
            Debug.Assert(walkie.Equals(Walker));

            repository.DeleteUser(Walker);
        }


        [TestMethod]
        public void Walker_DeleteWalker()
        {
            Walker Walker = (Walker)UserFactory.CreateWalker("Walker123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.WALKER, true, false);
            UserRepository repository = new UserRepository();
            repository.AddUser(Walker);

            repository.DeleteUser(Walker);
            Debug.Assert(repository.GetWalker("Walker123") == null);
        }

        [TestMethod]
        public void Walker_UpdateWalker()
        {
            Walker Walker = (Walker)UserFactory.CreateWalker("Walker123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.WALKER, true, false);
            UserRepository repository = new UserRepository();
            repository.AddUser(Walker);

            Walker.City = "Sveti Petar u Sumi";
            repository.UpdateWalker(Walker);
           
            Debug.Assert(repository.GetWalker("Walker123").City.Equals("Sveti Petar u Sumi"));

            repository.DeleteUser(Walker);
        }

        [TestMethod]
        public void Walker_GetType()
        {
            Walker Walker = (Walker)UserFactory.CreateWalker("Walker123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.WALKER, true, false);
            UserRepository repository = new UserRepository();
            repository.AddUser(Walker);

            Debug.Assert(Walker.UserType == UserType.WALKER);

            repository.DeleteUser(Walker);
        }

        [TestMethod]
        public void Walker_CreateWalkerAd()
        {
            Walker Walker = (Walker)UserFactory.CreateWalker("Walker123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.WALKER, true, false);
            WalkerAd WalkerAd = (WalkerAd)AdFactory.CreateWalkerAd(40.0, "Setam pse POVOLJNO", AdStatus.ACTIVE,
                "Obozavam pse", new DateTime(2019, 8, 28, 12, 5, 0), 3, 4, Walker);

            Walker.AddAd((WalkerAd)WalkerAd);

            UserRepository repository = new UserRepository();
            repository.AddUser(Walker);

            Debug.Assert(WalkerAd.Equals(Walker.Ads[0]));

            repository.DeleteUser(Walker);

        }

        [TestMethod]
        public void Walker_UpdateWalkerAd()
        {
            Walker Walker = (Walker)UserFactory.CreateWalker("Walker123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.WALKER, true, false);
            WalkerAd WalkerAd = (WalkerAd)AdFactory.CreateWalkerAd(40.0, "Setam pse POVOLJNO", AdStatus.ACTIVE,
                "Obozavam pse", new DateTime(2019, 8, 28, 12, 5, 0), 3, 4, Walker);
            Walker.AddAd((WalkerAd)WalkerAd);

            AdRepository AdRepository = new AdRepository();

            UserRepository repository = new UserRepository();
            repository.AddUser(Walker);

            WalkerAd.Title = "Setam pse POVOLJNO";
            AdRepository.UpdateAd(WalkerAd);
            repository.UpdateUser(Walker);

            Debug.Assert(Walker.Ads[0].Title.Equals("Setam pse POVOLJNO"));

            repository.DeleteUser(Walker);
        }

        [TestMethod]
        public void Walker_DeleteWalkerAd()
        {
            Walker Walker = (Walker)UserFactory.CreateWalker("WalkerDel", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.WALKER, true, false);
            WalkerAd WalkerAd = (WalkerAd)AdFactory.CreateWalkerAd(40.0, "Setam pse POVOLJNO", AdStatus.ACTIVE,
                       "Obozavam pse", new DateTime(2019, 8, 28, 12, 5, 0), 3, 4, Walker);

            Walker.AddAd((WalkerAd)WalkerAd);

            UserRepository repository = new UserRepository();
            repository.AddUser(Walker);

            Walker.DeleteAd((WalkerAd)WalkerAd);

            Debug.Assert(Walker.Ads.Count == 0);

            repository.DeleteUser(Walker);
        }
    }
}
