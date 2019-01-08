using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model
{
    public enum UserType { ADMIN, WALKER, OWNER };

    public abstract class User : EntityBase<int>
    {
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual int Age { get; set; }
        public virtual UserType UserType { get; set; }

        public User()
            : base()
        {


        }


        public User(string Username, string Password,
            string Name, string Surname, string PhoneNumber, string Address, string City, int Age, UserType UserType)
            : base()
        {
            this.Username = Username;
            this.Password = Password;
            this.Name = Name;
            this.Surname = Surname;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.City = City;
            this.Age = Age;
            this.UserType = UserType;
        }

    }
}
