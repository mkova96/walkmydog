using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkMyDog.Model;

namespace WalkMyDog.BaseLib
{
    public interface IStartView
    {
        List<WalkerAd> GetWalkerAds();
        List<OwnerAd> GetOwnerAds();

    }
}
