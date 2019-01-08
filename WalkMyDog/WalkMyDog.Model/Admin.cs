using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model
{
    public class Admin : User
    {

        public Admin()
             : base()
        {


        }
        public Admin(string Username, string Password,
            string Name, string Surname, string PhoneNumber, string Address, string City, int Age, UserType UserType)
            : base(Username, Password, Name, Surname, PhoneNumber, Address, City, Age, UserType)
        {

        }

    }
}
