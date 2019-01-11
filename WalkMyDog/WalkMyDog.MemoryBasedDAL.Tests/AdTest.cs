using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalkMyDog.MemoryBasedDAL.Repositories;
using WalkMyDog.Model;

namespace WalkMyDog.MemoryBasedDAL.Tests
{
    [TestClass]
    public class AdTest
    {
        [TestMethod]
        public void Ad_CreateInstance()
        {
            Owner Owner = new Owner("AdTest1", "testnaLozinka", "Ivan", "Horvat", "123456789", "Unska 3","Zagreb",40, UserType.OWNER,new List<OwnerAd>());
            Ad OwnerAd = new OwnerAd(40.0, "Trazim setaca pasa HITNO", AdStatus.ACTIVE, 
                "Psi su vrlo umiljati i dragi", new DateTime(2019, 8, 28, 12, 5, 0), 3,4, Owner);
            Owner.AddAd((OwnerAd)OwnerAd);

            UserRepository repository = new UserRepository();
            repository.AddUser(Owner);

            AdRepository AdRepository = new AdRepository();
            OwnerAd ad = AdRepository.GetAllOwnerAds()[0];

            Debug.Assert(OwnerAd != ad); /// razliciti fins out why
        }

        [TestMethod]
        public void Ad_DeleteInstance()
        {
            Walker Walker = new Walker("AdTest2", "testnaLozinka", "Ivan", "Horvatko", "123456789", "Unska 30", "Zagreb", 40,
                UserType.OWNER,true,true, new List<WalkerAd>());
            Ad WalkerAd = new WalkerAd(55.0, "Setam sve vrste pasa POVOLJNO", AdStatus.ACTIVE,
                "Po mogucnosti zvati izmedju 14 i 19h", new DateTime(2019, 7, 28, 9, 15, 0), 3, 4, Walker);
            Walker.AddAd((WalkerAd)WalkerAd);

            UserRepository repository = new UserRepository();
            repository.AddUser(Walker);

            Walker.DeleteAd((WalkerAd)WalkerAd);
            repository.UpdateUser(Walker);

            AdRepository AdRepository = new AdRepository();
            List<WalkerAd> ads = (List<WalkerAd>)AdRepository.GetAllWalkerAds();
            Debug.Assert(ads == null); //isto ne radi
        }
    }
}
