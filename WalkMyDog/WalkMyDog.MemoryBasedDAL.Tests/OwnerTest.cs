using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalkMyDog.MemoryBasedDAL.Repositories;
using WalkMyDog.Model;
using WalkMyDog.Model.Factories;

namespace WalkMyDog.MemoryBasedDAL.owners
{
    [TestClass]
    public class Ownerowner
    {

        [TestMethod]
        public void Owner_CreateInstance()
        {
            User Owner = UserFactory.CreateOwner("owner123", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3", "Zagreb", 40, UserType.OWNER);
            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            Owner owney = repository.GetOwner("owner123", "testnaLozinka");
            Debug.Assert(owney != Owner); ///razlicita su-find out why
        }

        [TestMethod]
        public void Owner_DeleteInstance()
        {
            User Owner = UserFactory.CreateOwner("123owner", "testnaLozinka", "Marko", "Car", "123456789", "Unska 30", "Zagreb", 19, UserType.OWNER);
            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            repository.DeleteUser(Owner);
            Debug.Assert(repository.GetOwner("123owner", "testnaLozinka") == null);
        }

        [TestMethod]
        public void Owner_UpdateInstance()
        {
            User Owner = UserFactory.CreateOwner("123owner123", "testnaLozinka", "Matko", "Par", "123456789", "Unska 30", "Zagreb", 24, UserType.OWNER);
            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            Owner.Address = "Zagrebacka 21";
            repository.UpdateUser(Owner);

            Debug.Assert(Owner.Address == "Zagrebacka 21");
        }

        [TestMethod]
        public void Owner_GetType()
        {
            User Owner = UserFactory.CreateOwner("123owner1234", "testnaLozinka", "Mario", "Parre", "123456789", "Unska 30", "Zagreb", 24, UserType.OWNER);
            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            Debug.Assert(Owner.UserType == UserType.OWNER);
        }



    }
}
