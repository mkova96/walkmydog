using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkMyDog.Model;

namespace WalkMyDog.MemoryBasedDAL
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            //CreateReviewAndSaveToDatabase();
            CreateAndFetchOwner();
            Console.ReadLine();
        }

        private static void CreateAndFetchOwner()
        {

            OwnerAd Ad = new OwnerAd(100, "Trazim setaca", AdStatus.ACTIVE, "Svi psi su buldozi", new DateTime(), 4,2,null);
            Owner Owner = new Owner("admin", "admin", "Ivan", "Adminović","12346789", "Pantovcak 21", "Zagreb", 50,UserType.ADMIN, new List<OwnerAd>());
            Ad.Owner = (Owner)Owner;
            Owner.AddAd(Ad);
            object id = 0;
            using (var session = NHibernateService.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    id = session.Save(Owner);
                    transaction.Commit();
                }
                session.Clear();
                // session.c;
            }
            /*
            UserRepository UserRepository = new UserRepository();
            AdRepository AdRepository = new AdRepository();
            Owner p = UserRepository.GetOwner((int)id);
            Console.WriteLine(p.Name);

            Owner p2 = UserRepository.GetOwner("ZZZ", "1234");
            Console.WriteLine(p2.Name);

            IList<Owner> Owners = UserRepository.GetAllOwners();
            Console.WriteLine(Owners.ElementAt(0).Name);

            IList<OwnerAd> OwnerAds = AdRepository.GetAllOwnerAds();
            Console.WriteLine(OwnerAds.ElementAt(0).Experience);
            Exception e = new Exception();
            
            Logger.Log("marko beba mrzljak");


            Console.ReadLine();
            */

        }

        /*private static void CreateReviewAndSaveToDatabase()
        {
            var review = new Review();

            review.Grade = 7;
            review.ReviewText = "marko mrzljak";

            using (var session = NHibernateService.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(review);
                    transaction.Commit();
                }
                Console.WriteLine("Saved review to the database");
            }
        }*/

        

        
    }
}
