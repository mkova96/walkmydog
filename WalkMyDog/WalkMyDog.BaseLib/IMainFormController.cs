using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WalkMyDog.BaseLib
{
    public interface IMainFormController
    {
        void ShowWalkerForm(Form LoginView);
        void CreateWalker(IWalkerView WalkerView);
        void ShowLoginForm(IMainView MainView);
        void LoginUser(ILoginView LoginView);
        void ShowMainForm();
        void ShowOwnerForm(Form LoginView);
        void CreateOwner(IOwnerView OwnerView);
        void ShowAdForm(IMainView MainView); //MJENJANO
        void ShowMyProfile();
        void CreateAd(IAdView AdView);
        void ShowAdForm(int Id, IMainView MinView);
        void ShowOwner(IAdView AdView);
        void Logout(IMainView MainView);
        void InitializeLists(IMainView MainView);

        void AcceptAd(int Id);


        void UpdateWalker(IWalkerView WalkerView);
        void UpdateOwner(IOwnerView OwnerView);
        void UpdateAd(IAdView AdView);

        void DeleteAd(IAdView AdView);








    }
}
