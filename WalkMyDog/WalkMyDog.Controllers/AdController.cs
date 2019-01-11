using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WalkMyDog.BaseLib;
using WalkMyDog.Model;
using WalkMyDog.Model.Factories;
using WalkMyDog.Model.Repositories;

namespace WalkMyDog.Controllers
{
    public class AdController
    {
        public void ShowAdForm(IAdView AdView)
        {
            var form = (Form)AdView;
            form.Show();
        }
        public void ShowAdForm(IAdView AdView, int Id, IUserRepository UserRepository, IAdRepository AdRepository, User User)
        {

            Ad Ad = GetAd(Id, AdRepository);
            AdView.Price = Ad.Price;
            AdView.Title = Ad.Title;
            AdView.Hours = Ad.Hours;
            AdView.DogsNumber  = Ad.DogsNumber;
            //AdView.Date = Ad.Date;
            AdView.Description = Ad.Description;
            AdView.AdId = Ad.Id;
            AdView.AdStatus = Ad.AdStatus;

            var form = (Form)AdView;
            form.Show();
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

        public void CreateAd(IAdView AdView, IUserRepository UserRepository, User CurrentUser)
        {
            AdView.AdjustCreateView();
            double Price = AdView.Price;
            DateTime Date = DateTime.Now.Date; //PAZIIIIIIII
            string Description = AdView.Description;
            string Title = AdView.Title;
            AdStatus AdStatus = AdStatus.ACTIVE; //PAZIIIIII
            int DogsNumber = AdView.DogsNumber;
            int Hours = AdView.Hours;


            if (Price == 0 || Description == "" || Title == "" || Hours == 0 || DogsNumber == 0)
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }


            if (CurrentUser.UserType == UserType.WALKER)
            {
                Ad Ad = AdFactory.CreateWalkerAd(Price,Title,AdStatus, Description, Date, DogsNumber, Hours, (Walker)CurrentUser);
                Walker Walker = (Walker)CurrentUser;
                Walker.AddAd((WalkerAd)Ad);
                UserRepository.UpdateUser(Walker);
            }
            else if (CurrentUser.UserType == UserType.OWNER)
            {
                Ad Ad = AdFactory.CreateOwnerAd(Price, Title, AdStatus, Description, Date, DogsNumber, Hours, (Owner)CurrentUser);
                Owner Owner = (Owner)CurrentUser;
                Owner.AddAd((OwnerAd)Ad);
                UserRepository.UpdateUser(Owner);
            }
            else
            {
                //
            }
            var form = (Form)AdView;
            form.Hide();
        }

        public void UpdateAd(IAdView AdView,
           IAdRepository AdRepository, Ad Ad)
        {

            Ad.Title = AdView.Title;
            Ad.Description = AdView.Description;
            Ad.DogsNumber = AdView.DogsNumber;
            Ad.Hours = AdView.Hours;
            Ad.Price = AdView.Price;

            Ad.AdStatus = AdView.AdStatus;


            AdRepository.UpdateAd(Ad);


            var frm = (Form)AdView;
            frm.Hide();
        }

        public void DeleteAd(IAdView AdView,
           IAdRepository AdRepository, Ad Ad)
        {
            AdRepository.DeleteAd(Ad);


            var frm = (Form)AdView;
            frm.Hide();
        }

    }
}
