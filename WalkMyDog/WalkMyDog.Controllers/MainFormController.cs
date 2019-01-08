using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkMyDog.BaseLib;
using WalkMyDog.Model;
using WalkMyDog.Model.Repositories;

namespace WalkMyDog.Controllers
{
    public class MainFormController : IMainFormController
    {
        private bool DefaultModelLoaded = false;

        private User CurrentUser;

        private readonly IWindowFormsFactory WindowFormsFactory = null;
        private readonly IUserRepository UserRepository = null;
        private readonly IAdRepository AdRepository = null;

        public MainFormController(IWindowFormsFactory WindowsFormsFactory, IUserRepository UserRepository, IAdRepository AdRepository)
        {
            this.WindowFormsFactory = WindowsFormsFactory;
            this.UserRepository = UserRepository;
            this.AdRepository = AdRepository;
        }

        public void ShowMainForm()
        {
            if (CurrentUser == null)
            {
                return;
            }

            var mainForm = WindowFormsFactory.CreateMainView(this);
            mainForm.HideLoginButton();
            mainForm.SetWelcomeLabel("Welcome " + CurrentUser.Name);
            mainForm.EnableMenu();
            mainForm.WalkerAds = getWalkerAds();
            mainForm.WalkerAds = getWalkerAds();

            var form = (Form)mainForm;
            form.Show();
        }
        public void ShowOwner(IAdView AdView)
        {

            ShowProfile(GetOwner(AdView.AdId, AdRepository));

        }

        private User GetOwner(int Id, IAdRepository AdRepository)
        {
            Ad Ad = AdRepository.GetWalkerAd(Id);
            if (Ad != null)
            {
                WalkerAd o = (WalkerAd)Ad;
                return o.Walker;
            }
            OwnerAd po = (OwnerAd)AdRepository.GetOwnerAd(Id);
            return po.Owner;


        }
        public void ShowMyProfile()
        {
            ShowProfile(CurrentUser);
        }


        public void ShowProfile(User User)
        {
            if (User.UserType == UserType.WALKER)
            {
                WalkerController WalkerController = new WalkerController();
                IWalkerView WalkerView = WindowFormsFactory.CreateWalkerView(this);
                if (User.Id == CurrentUser.Id)
                {
                    WalkerView.AdjustEditView();
                }
                else
                {
                    WalkerView.AdjustOuterView();

                }
                WalkerController.ShowMyProfile(WalkerView, (Walker)User);

            }
            else if (User.UserType == UserType.OWNER)
            {
                OwnerController OwnerController = new OwnerController();
                IOwnerView OwnerView = new OwnerForm(this);
                if (User.Id == CurrentUser.Id)
                {
                    OwnerView.AdjustEditView();
                }
                else
                {
                    OwnerView.AdjustOuterView();

                }
                OwnerController.ShowMyProfile(OwnerView, (Owner)User);
            }
            else
            {
                MessageBox.Show("Error");
                return;
            }
        }

        public void InitializeLists(IMainView mainForm)
        {
            mainForm.WalkerAds = getWalkerAds();
            mainForm.OwnerAds = getOwnerAds();
        }

        private List<OwnerAd> getOwnerAds()
        {

            List<OwnerAd> Ads = (List<OwnerAd>)AdRepository.GetAllOwnerAds();
            if (Ads == null || Ads.Count == 0)
            {
                return new List<OwnerAd>();
            }
            int end = Ads.Count < 5 ? Ads.Count : 5;
            return Ads.GetRange(0, end);
        }
        private List<WalkerAd> getWalkerAds()
        {
            List<WalkerAd> Ads = (List<WalkerAd>)AdRepository.GetAllWalkerAds();
            if (Ads == null || Ads.Count == 0)
            {
                return new List<WalkerAd>();
            }
            int end = Ads.Count < 5 ? Ads.Count : 5;
            return Ads.GetRange(0, end);
        }

        public void ApplyToAd(int AdId)
        {
            AdController AdController = new AdController();
            AdController.ApplyToAd(CurrentUser, AdId, AdRepository, UserRepository, CooperationRepository);
        }

        public void ShowLoginForm(IMainView MainView)
        {
            var frm = (Form)MainView;
            frm.Hide();
            frm.ShowInTaskbar = false;
            AccountController AccountController = new AccountController();
            var LoginView = WindowFormsFactory.CreateLoginView(this);

            AccountController.ShowLoginForm(LoginView);

            // LoginController.Login(UserRepository, LoginView, this);
        }


        public void ShowWalkerForm(Form LoginView)
        {
            WalkerController WalkerController = new WalkerController();
            var CreateWalkerForm = WindowFormsFactory.CreateWalkerView(this);
            CreateWalkerForm.AdjustCreateView();
            WalkerController.ShowWalkerForm(CreateWalkerForm);

            LoginView.Close();
            //nanycon umjesto
        }
        public void CreateWalker(IWalkerView WalkerForm)
        {
            WalkerController WalkerController = new WalkerController();
            User User = WalkerController.CreateWalker(WalkerForm, UserRepository);
            if (User == null)
            {
                return;
            }
            var frm = (Form)WalkerForm;
            frm.Close();
            CurrentUser = User;
            ShowMainForm();
        }

        public void CreateAd(IAdView AdForm)
        {
            AdController AdController = new AdController();
            AdController.CreateAd(AdForm, UserRepository, CurrentUser);
        }
        public void ShowAdForm(int Id, IMainView MainView)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("Logon or create account to view Ad details");
                return;
            }
            AdForm AdForm = (AdForm)WindowFormsFactory.CreateAdView(this);

            WalkerAd no = AdRepository.GetWalkerAd(Id);
            if (no != null)
            {
                if (CurrentUser.UserType == UserType.Walker)
                {
                    AdForm.AdjustApplyNoView();
                }
                else
                {
                    AdForm.AdjustApplyYesView();
                }
            }
            OwnerAd po = AdRepository.GetOwnerAd(Id);
            if (po != null)
            {
                if (CurrentUser.UserType == UserType.Owner)
                {
                    AdForm.AdjustApplyNoView();
                }
                else
                {
                    AdForm.AdjustApplyYesView();
                }
            }
            if (CurrentUser == null)
            {
                MessageBox.Show("Logon or create account to view Ad details");
                return;
            }
            AdController AdController = new AdController();
            //AdForm AdForm = (AdForm)WindowFormsFactory.CreateAdView(this);
            AdController.ShowAdForm(AdForm, Id, UserRepository, AdRepository, CurrentUser);
        }
        public void ShowAdForm()
        {
            AdController AdController = new AdController();
            AdForm AdForm = (AdForm)WindowFormsFactory.CreateAdView(this);
            AdController.ShowAdForm(AdForm);
        }

        public void ShowOwnerForm(Form LoginView)
        {
            OwnerController OwnerController = new OwnerController();
            OwnerForm OwnerForm = (OwnerForm)WindowFormsFactory.CreateOwnerView(this);
            OwnerForm.AdjustCreateView();
            OwnerController.ShowOwnerForm(OwnerForm);
            LoginView.Close();

        }

        public void CreateOwner(IOwnerView OwnerForm)
        {
            OwnerController OwnerController = new OwnerController();
            User User = OwnerController.CreateOwner(OwnerForm, UserRepository);
            if (User == null)
            {
                return;
            }
            var frm = (Form)OwnerForm;
            frm.Close();
            CurrentUser = User;
            ShowMainForm();
        }

        public void LoginUser(ILoginView LoginView)
        {
            AccountController AccountController = new AccountController();

            User User = AccountController.Login(UserRepository, LoginView, this);

            CurrentUser = User;
            ShowMainForm();
        }

        public void Logout(IMainView MainView)
        {
            CurrentUser = null;
            MainView.DisableMenu();
            MainView.SetWelcomeLabel("");
            MainView.ShowLoginButton();
        }

        public void ShowCreateAdForm()
        {
            AdController AdController = new AdController();

        }
    }
}
