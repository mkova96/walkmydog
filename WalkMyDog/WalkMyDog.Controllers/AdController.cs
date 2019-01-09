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
            AdView.Date = Ad.Date;
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

        /*public void ApplyToAd(User CurrentUser, int AdId, IAdRepository AdRepository,
            IUserRepository UserRepository, ICooperationRepository CoorporationRepository)
        {
            Ad Ad = GetAd(AdId, AdRepository);
            User Aceptee = null;
            Type o = Ad.GetType();
            if (Ad.GetType() == typeof(WalkerAd))
            {
                WalkerAd no = (WalkerAd)Ad;
                Aceptee = no.Walker;
            }
            else if (Ad.GetType() == typeof(OwnerAd))
            {
                OwnerAd po = (OwnerAd)Ad;
                Aceptee = po.Owner;
            }
            else
            {
                MessageBox.Show("Error");
                return;
            }

            Cooperation Cooperation = CooperationFactory.CreateCooperation(CurrentUser, Aceptee, Ad);
            // CoorporationRepository.AddCooperation(Cooperation);

            if (Aceptee.UserType == UserType.Walker)
            {
                Walker n = (Walker)Aceptee;
                n.AddCooperation(Cooperation);
                UserRepository.UpdateUser(n);
                MessageBox.Show("You applied successfully");

            }
            else if (Aceptee.UserType == UserType.Owner)
            {
                Owner p = (Owner)Aceptee;
                p.AddCooperation(Cooperation);
                UserRepository.UpdateUser(p);
                MessageBox.Show("You applied successfully");

            }

        }*/
    }
}
