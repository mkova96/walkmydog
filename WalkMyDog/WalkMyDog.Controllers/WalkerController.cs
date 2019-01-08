﻿using System;
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
                MessageBox.Show("Please fill all the fields.");
                return null;
            }

            if (Age < 15)
            {
                MessageBox.Show("Morate biti stariji od 15 godina");
                return null;

            }
            Walker Walker = UserRepository.GetWalker(Username, Password);
            if (Walker != null)
            {
                MessageBox.Show("User with inserted username and password already exists. Please choose another one.");
                return null;
            }

            Walker = (Walker)UserFactory.CreateWalker(Username,Password,Name,Surname, PhoneNumber,Address, City, Age, UserType.WALKER,Experience,Dogs);

            if (UserRepository.AddUser(Walker) == false)
            {
                MessageBox.Show("Error creating account, please try again");
                return null;
            }
            return Walker;

        }

    }
}
