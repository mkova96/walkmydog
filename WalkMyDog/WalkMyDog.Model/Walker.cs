using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model
{
    public class Walker : User
    {
        public virtual IList<WalkerAd> Ads { get; set; }
        public virtual bool Experience { get; set; }
        public virtual bool Dogs { get; set; }

        public Walker(string Username, string Password,
             string Name, string Surname, string PhoneNumber, string Address, string City, int Age, UserType UserType, bool Experience,
            bool Dogs, IList<WalkerAd> Ads)
            : base(Username, Password, Name, Surname, PhoneNumber, Address, City, Age, UserType)
        {
            this.Experience = Experience;
            this.Dogs = Dogs;
            this.Ads = Ads;

        }
        public Walker()
            : base()
        {


        }

        public virtual void AddAd(WalkerAd Ad)
        {
            Ads.Add(Ad);
        }
        public virtual void DeleteAd(WalkerAd Ad)
        {
            Ads.Remove(Ad);
        }

    }
}
