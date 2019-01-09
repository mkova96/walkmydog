using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkMyDog.Model;
using WalkMyDog.Model.Repositories;

namespace WalkMyDog.MemoryBasedDAL.Repositories
{
    public class AdRepository : IAdRepository
    {
        private IList<T> getAllAds<T>() where T : Ad
        {
            IList<T> Ads = null;
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        Ads = session.QueryOver<T>().List();
                        transaction.Commit();
                    }
                    session.Clear();
                    // session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return null;
                }
            }
            // return Ads.OrderBy(o => o.Id).ToList();

            return Ads;

        }
        public IList<WalkerAd> GetAllWalkerAds()
        {
            return getAllAds<WalkerAd>();
        }

        public IList<OwnerAd> GetAllOwnerAds()
        {
            return getAllAds<OwnerAd>();

        }


        public WalkerAd GetWalkerAd(int Id)
        {
            return GetAd<WalkerAd>(Id);
        }
        public OwnerAd GetOwnerAd(int Id)
        {
            return GetAd<OwnerAd>(Id);
        }
        private T GetAd<T>(int Id) where T : Ad
        {
            T Ad = default(T);
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        // User = session.QueryOver<User>().Where(c => c.Id == Id)
                        //    .And(c => c is T).SingleOrDefault();
                        Ad = (T)session.Get(typeof(T), Id);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return Ad;
                }
            }
            return Ad;
        }
    }
}
