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
    public class WalkerController
    {
        public void ShowWalkerForm(IWalkerView WalkerView)
        {
            var form = (Form)WalkerView;
            form.Show();

        }
        public void ShowMyProfile(IWalkerView WalkerView, Walker Walker)
        {
            WalkerView.WalkerId = Walker.Id;
            WalkerView.Username = Walker.Username;
            WalkerView.Password = Walker.Password;
            WalkerView.WalkerName = Walker.Name;
            WalkerView.Surname = Walker.Surname;
            WalkerView.Address = Walker.Address;
            WalkerView.Age = Walker.Age;
            WalkerView.City = Walker.City;
            WalkerView.Dogs = Walker.Dogs;
            WalkerView.Experience = Walker.Experience;
            WalkerView.PhoneNumber = Walker.PhoneNumber;

            var frm = (Form)WalkerView;
            frm.Show();
        }

        public User CreateWalker(IWalkerView WalkerView, IUserRepository UserRepository)
        {
            string Username = WalkerView.Username;
            string Password = WalkerView.Password;
            string Name = WalkerView.WalkerName;
            string Surname = WalkerView.Surname;
            string Address = WalkerView.Address;
            int Age = WalkerView.Age;
            string City = WalkerView.City;
            bool Dogs = WalkerView.Dogs;
            bool Experience = WalkerView.Experience;
            string PhoneNumber = WalkerView.PhoneNumber;


            if (Username.Length == 0 || Password.Length == 0 || Name.Length == 0 || Surname.Length == 0
                || Address.Length == 0 || City.Length == 0 || PhoneNumber.Length == 0)
            {
                MessageBox.Show("Obvezno je ispuniti sva polja");
                return null;
            }

            if (Age < 0)
            {
                MessageBox.Show("Broj godina ne može biti negativan");
                return null;

            }
            Walker Walker = UserRepository.GetWalker(Username, Password);
            if (Walker != null)
            {
                MessageBox.Show("Korisnik s unesenim korisničkim imenom već postoji.");
                return null;
            }

            Walker = (Walker)UserFactory.CreateWalker(Username,Password,Name,Surname, PhoneNumber,Address, City, Age, UserType.WALKER,Experience,Dogs);

            if (UserRepository.AddUser(Walker) == false)
            {
                MessageBox.Show("Greška");
                return null;
            }
            return Walker;

        }

        public void UpdateWalker(IWalkerView WalkerView,
            IUserRepository UserRepository, Walker User)
        {

            User.Name = WalkerView.WalkerName;
            User.Address = WalkerView.Address;
            User.Age = WalkerView.Age;
            User.City = WalkerView.City;
            User.Password = WalkerView.Password;
            User.PhoneNumber = WalkerView.PhoneNumber;
            User.Surname = WalkerView.Surname;
            User.Username = WalkerView.Username;

            User.Dogs = WalkerView.Dogs;
            User.Experience = WalkerView.Experience;

            UserRepository.UpdateWalker(User);


            var frm = (Form)WalkerView;
            frm.Hide();
        }

    }
}
