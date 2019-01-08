using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkMyDog.Model;

namespace WalkMyDog.BaseLib
{
    public interface IMainView
    {
        List<WalkerAd> WalkerAds { get; set; }
        List<OwnerAd> OwnerAds { get; set; }

        void ShowLoginButton();
        void HideLoginButton();
        void SetWelcomeLabel(string text);

        void EnableMenu();
        void DisableMenu();


    }
}
