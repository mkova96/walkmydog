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
    public class OwnerController
    {
        public void ShowOwnerForm(IOwnerView OwnerView)
        {
            var form = (Form)OwnerView;
            form.Show();
        }

        public void ShowMyProfile(IOwnerView OwnerView, Owner Owner)
        {
            OwnerView.Username = Owner.Username;
            OwnerView.Password = Owner.Password;
            OwnerView.OwnerName = Owner.Name;
            OwnerView.Surname = Owner.Surname;
            OwnerView.PhoneNumber = Owner.PhoneNumber;
            OwnerView.Age = Owner.Age;
            OwnerView.City = Owner.City;
            OwnerView.Address = Owner.Address;

            var frm = (Form)OwnerView;
            frm.Show();
        }

        public User CreateOwner(IOwnerView OwnerView, IUserRepository UserRepository)
        {
            string Username = OwnerView.Username;
            string Password = OwnerView.Password;
            string Name = OwnerView.OwnerName;
            string Surname = OwnerView.Surname;
            string PhoneNumber = OwnerView.PhoneNumber;
            int Age = OwnerView.Age;
            string City = OwnerView.City;
            string Address = OwnerView.Address;

            if (Username.Length == 0 || Password.Length == 0 || Name.Length == 0 || Surname.Length == 0
                || Address.Length == 0 || City.Length == 0 || PhoneNumber.Length == 0)
            {
                MessageBox.Show("Please fill all the fields.");
                return null;
            }

            Owner Owner = UserRepository.GetOwner(Username, Password);
            if (Owner != null)
            {
                MessageBox.Show("User with inserted username and password already exists. Please choose another one.");
                return null;
            }

            Owner = (Owner)UserFactory.CreateOwner(Username, Password,Name, Surname, PhoneNumber, Address, City, Age, UserType.OWNER);
            if (UserRepository.AddUser(Owner) == false)
            {
                MessageBox.Show("Error creating account, please try again");
                return null;
            }
            return Owner;
        }

        public void UpdateOwner(IOwnerView OwnerView,
            IUserRepository UserRepository, User User)
        {

            User.Name = OwnerView.OwnerName;
            User.Address = OwnerView.Address;
            User.Age = OwnerView.Age;
            User.City = OwnerView.City;
            User.Password = OwnerView.Password;
            User.PhoneNumber = OwnerView.PhoneNumber;
            User.Surname = OwnerView.Surname;
            User.Username = OwnerView.Username;

            UserRepository.UpdateUser(User);


            var frm = (Form)OwnerView;
            frm.Close();
        }
    }
}
