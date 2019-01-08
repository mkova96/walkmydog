using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model.Factories
{
    public class AdFactory
    {
        public static Ad CreateWalkerAd(double Price, string Title, AdStatus AdStatus, string Description,
        DateTime Date, int DogsNumber, int Hours, Walker Walker)
        {
            return new WalkerAd(Price, Title, AdStatus, Description, Date, DogsNumber, Hours, Walker);
        }

        public static Ad CreateOwnerAd(double Price, string Title, AdStatus AdStatus, string Description,
        DateTime Date, int DogsNumber, int Hours, Owner Owner)
        {
            return new OwnerAd(Price, Title, AdStatus, Description, Date, DogsNumber, Hours,Owner);
        }
    }
}
