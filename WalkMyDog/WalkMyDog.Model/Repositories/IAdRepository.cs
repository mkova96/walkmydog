using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model.Repositories
{
    public interface IAdRepository
    {
        IList<WalkerAd> GetAllWalkerAds();

        IList<OwnerAd> GetAllOwnerAds();

        WalkerAd GetWalkerAd(int Id);
        OwnerAd GetOwnerAd(int Id);
    }
}
