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

        public Ad CreateAd(IAdView AdView, IUserRepository UserRepository, User CurrentUser)
        {
            AdView.AdjustCreateView();
            double Price = AdView.Price;
            DateTime Date = DateTime.Now.Date; 
            string Description = AdView.Description;
            string Title = AdView.Title;
            AdStatus AdStatus = AdStatus.ACTIVE; 
            int DogsNumber = AdView.DogsNumber;
            int Hours = AdView.Hours;

            Ad Ad;

            if (Description == "" || Title == "")
            {
                MessageBox.Show("Obvezno je ispuniti sva polja");
                return null;
            }
            if (Price <= 0 || DogsNumber<=0 || Hours<=0)
            {
                MessageBox.Show("Broj godina/Cijena/Broj pasa ne može manji ili jednak 0");
                return null;
            }


            if (CurrentUser.UserType == UserType.WALKER)
            {
                Ad = AdFactory.CreateWalkerAd(Price,Title,AdStatus, Description, Date, DogsNumber, Hours, (Walker)CurrentUser);
                Walker Walker = (Walker)CurrentUser;
                Walker.AddAd((WalkerAd)Ad);
                UserRepository.UpdateUser(Walker);
            }
            else
            {
                Ad = AdFactory.CreateOwnerAd(Price, Title, AdStatus, Description, Date, DogsNumber, Hours, (Owner)CurrentUser);
                Owner Owner = (Owner)CurrentUser;
                Owner.AddAd((OwnerAd)Ad);
                UserRepository.UpdateUser(Owner);
            }
            
            var form = (Form)AdView;
            form.Hide();

            return Ad;
        }

        public bool UpdateAd(IAdView AdView,
           IAdRepository AdRepository, Ad Ad)
        {

            Ad.Title = AdView.Title;
            Ad.Description = AdView.Description;
            Ad.DogsNumber = AdView.DogsNumber;
            Ad.Hours = AdView.Hours;
            Ad.Price = AdView.Price;
            Ad.AdStatus = AdView.AdStatus;

            if (Ad.Description == "" || Ad.Title == "")
            {
                MessageBox.Show("Obvezno je ispuniti sva polja");
                return false;
            }
            if (Ad.Price <= 0 || Ad.DogsNumber <= 0 || Ad.Hours <= 0)
            {
                MessageBox.Show("Broj godina/Cijena/Broj pasa ne može manji ili jednak 0");
                return false;
            }

            AdRepository.UpdateAd(Ad);

            var frm = (Form)AdView;
            frm.Hide();
            return true;
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
