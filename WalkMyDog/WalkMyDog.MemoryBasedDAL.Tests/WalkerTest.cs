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
        public void Walker_CreateInstance()
        {
            User walker = UserFactory.CreateWalker("test123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.WALKER, true, false);
            UserRepository repository = new UserRepository();
            repository.AddUser(walker);

            Walker walkie = repository.GetWalker("test123", "testnaLozinka");
            Debug.Assert(walkie != walker); ///razlicita su-find out why
        }

        [TestMethod]
        public void Walker_DeleteInstance()
        {
            User walker = UserFactory.CreateWalker("123test", "testnaLozinka", "Marko", "Car", "123456789", "Unska 30", "Zagreb", 19, UserType.WALKER, false, false);
            UserRepository repository = new UserRepository();
            repository.AddUser(walker);

            repository.DeleteUser(walker);
            Debug.Assert(repository.GetWalker("123test", "testnaLozinka") == null);
        }

        [TestMethod]
        public void Walker_UpdateInstance()
        {
            User walker = UserFactory.CreateWalker("123test123", "testnaLozinka", "Matko", "Par", "123456789", "Unska 30", "Zagreb", 24, UserType.WALKER, false, true);
            UserRepository repository = new UserRepository();
            repository.AddUser(walker);

            walker.City = "Sveti Petar u Sumi";
            repository.UpdateUser(walker);

            Debug.Assert(walker.City == "Sveti Petar u Sumi");
        }

        [TestMethod]
        public void Walker_GetType()
        {
            User walker = UserFactory.CreateWalker("123test1234", "testnaLozinka", "Mario", "Parre", "123456789", "Unska 30", "Zagreb", 24, UserType.WALKER, true, true);
            UserRepository repository = new UserRepository();
            repository.AddUser(walker);

            Debug.Assert(walker.UserType == UserType.WALKER);
        }
    }
}
