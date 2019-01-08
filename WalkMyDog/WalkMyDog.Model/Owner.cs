using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model
{
    public class Owner : User
    {
        public virtual IList<OwnerAd> Ads { get; set; }

        public Owner()
            : base()
        {


        }
        public Owner(string Username, string Password,
              string Name, string Surname, string PhoneNumber, string Address, string City, int Age, UserType UserType, IList<OwnerAd> Ads)
             : base(Username, Password, Name, Surname, PhoneNumber, Address, City, Age, UserType)
        {
            this.Ads = Ads;
        }

        public virtual void AddAd(OwnerAd Ad)
        {
            Ads.Add(Ad);
        }
        public virtual void DeleteAd(OwnerAd Ad)
        {
            Ads.Remove(Ad);
        }
    }
}
