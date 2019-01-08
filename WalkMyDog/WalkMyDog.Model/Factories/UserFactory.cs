using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model.Factories
{
    public class UserFactory
    {
        public static User CreateAdmin(string Username, string Password,
            string Name, string Surname, string PhoneNumber, string Address, string City, int Age, UserType UserType)
        {
            return new Admin(Username, Password, Name, Surname, PhoneNumber, Address, City, Age, UserType);
        }

        public static User CreateWalker(string Username, string Password,
             string Name, string Surname, string PhoneNumber, string Address, string City, int Age, UserType UserType, bool Experience,
            bool Dogs)
        {
            return new Walker(Username, Password, Name, Surname, PhoneNumber, Address, City, Age, UserType,Experience,Dogs,
                new List<WalkerAd>());
        }

        public static User CreateOwner(string Username, string Password,
              string Name, string Surname, string PhoneNumber, string Address, string City, int Age, UserType UserType)
        {
            return new Owner(Username, Password, Name, Surname, PhoneNumber, Address, City, Age, UserType,
                new List<OwnerAd>());
        }
    }
}
