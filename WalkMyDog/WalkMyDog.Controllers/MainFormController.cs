﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WalkMyDog.BaseLib;
using WalkMyDog.Model;
using WalkMyDog.Model.Repositories;
using WalkMyDog.PresentationLayer;

namespace WalkMyDog.Controllers
{
    public class MainFormController : IMainFormController
    {

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
            mainForm.EnableMenu();

            //mainForm.WalkerAds = getWalkerAds();
            //mainForm.WalkerAds = getWalkerAds();

            //InitializeLists(mainForm);

            var form = (Form)mainForm;
            form.Show();

        }
        public void ShowOwner(IAdView AdView)
        {
            var frm = (Form)AdView;
            frm.Hide();
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
        public void ShowMyProfile(IMainView MainView)
        {
            var frm = (Form)MainView;
            frm.Hide();
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
                MessageBox.Show("Greška");
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
            return Ads.GetRange(0, Ads.Count);
        }
        private List<WalkerAd> getWalkerAds()
        {
            List<WalkerAd> Ads = (List<WalkerAd>)AdRepository.GetAllWalkerAds();
            if (Ads == null || Ads.Count == 0)
            {
                return new List<WalkerAd>();
            }
            return Ads.GetRange(0,Ads.Count);
        }

        public void ShowLoginForm(IMainView MainView)
        {
            var frm = (Form)MainView;
            frm.Hide();
            frm.ShowInTaskbar = false;
            AccountController AccountController = new AccountController();
            var LoginView = WindowFormsFactory.CreateLoginView(this);

            AccountController.ShowLoginForm(LoginView);

        }

        public void ShowWalkerForm(Form LoginView)
        {
            WalkerController WalkerController = new WalkerController();
            var CreateWalkerForm = WindowFormsFactory.CreateWalkerView(this);
            CreateWalkerForm.AdjustCreateView();
            WalkerController.ShowWalkerForm(CreateWalkerForm);

            LoginView.Hide();
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
            frm.Hide();
            CurrentUser = User;
            ShowMainForm();
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
            frm.Hide();
            CurrentUser = User;
            ShowMainForm();
        }

        public void CreateAd(IAdView AdForm)
        {
            AdController AdController = new AdController();
            if (AdController.CreateAd(AdForm, UserRepository, CurrentUser) == null)
            {
                return;
            }

            ShowMainForm();
        }
        public void ShowAdForm(int Id, IMainView MainView)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("Morate biti prijavljeni da biste vidjeli cijeli oglas");
                return;
            }

            var frm = (Form)MainView;
            frm.Hide();

            AdForm AdForm = (AdForm)WindowFormsFactory.CreateAdView(this);

            WalkerAd no = AdRepository.GetWalkerAd(Id);

            if (no != null)
            {
                AdForm.HideCreate();
            }

            OwnerAd po = AdRepository.GetOwnerAd(Id);

            if (po != null)
            {
                AdForm.HideCreate();
            }

            if (no==null && po == null)
            {
                AdForm.AdjustCreateView();
            }

            if (CurrentUser == null)
            {
                MessageBox.Show("Morate biti prijavljeni da biste vidjeli cijeli oglas");
                return;
            }


             if (GetOwner(Id, AdRepository).Username!= CurrentUser.Username)
              {
                AdForm.NotUsersAd();
              }
              


             AdController AdController = new AdController();
            AdController.ShowAdForm(AdForm, Id, UserRepository, AdRepository, CurrentUser);


            
        }
        public void ShowAdForm(IMainView MainView) 
        {
            var frm = (Form)MainView;
            frm.Hide();

            AdController AdController = new AdController();
            AdForm AdForm = (AdForm)WindowFormsFactory.CreateAdView(this);
            AdForm.AdjustCreateView();

            AdController.ShowAdForm(AdForm);
        }

        public void ShowOwnerForm(Form LoginView)
        {
            OwnerController OwnerController = new OwnerController();
            OwnerForm OwnerForm = (OwnerForm)WindowFormsFactory.CreateOwnerView(this);
            OwnerForm.AdjustCreateView();
            OwnerController.ShowOwnerForm(OwnerForm);
            LoginView.Hide();

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
            MainView.ShowLoginButton();
        }

        public void ShowCreateAdForm()
        {
            AdController AdController = new AdController();
        }

        public void UpdateWalker(IWalkerView WalkerView)
        {
            WalkerController WalkerController = new WalkerController();
            if(WalkerController.UpdateWalker(WalkerView, UserRepository, (Walker)CurrentUser) == false)
            {
                return;
            }
            ShowMainForm();
        }
        public void UpdateOwner(IOwnerView OwnerView)
        {
            OwnerController OwnerController = new OwnerController();
            if (OwnerController.UpdateOwner(OwnerView, UserRepository, CurrentUser)==false)
            {
                return;
            }
            ShowMainForm();
        }
        public void UpdateAd(IAdView AdView)
        {
            AdController AdController = new AdController();
            if(AdController.UpdateAd(AdView, AdRepository, GetAd(AdView.AdId, AdRepository)) == false)
            {
                return;
            }
            ShowMainForm();
        }
        public void DeleteAd(IAdView AdView)
        {
            AdController AdController = new AdController();
            AdController.DeleteAd(AdView, AdRepository, GetAd(AdView.AdId, AdRepository));
            ShowMainForm();
        }

        private Ad GetAd(int Id, IAdRepository AdRepository)
        {
            Ad Ad = AdRepository.GetWalkerAd(Id);
            if (Ad != null)
            {
                return Ad;
            }
            return AdRepository.GetOwnerAd(Id);
        }

        public void CloseThatFrom()
        {
            if (CurrentUser == null)
            {
                var mainForm = WindowFormsFactory.CreateMainView(this);
                var form = (Form)mainForm;
                form.Show();
            }
            else
            {
                var mainForm = WindowFormsFactory.CreateMainView(this);
                mainForm.HideLoginButton();
                mainForm.EnableMenu();

                var form = (Form)mainForm;
                form.Show();
            }            
        }        
    }
}
