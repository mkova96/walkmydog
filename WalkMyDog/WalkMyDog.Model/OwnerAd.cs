using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model
{
    public class OwnerAd : Ad
    {
        public virtual Owner Owner { get; set; }
        public OwnerAd(double Price, string Title, AdStatus AdStatus, string Description,
        DateTime Date, int DogsNumber, int Hours)
            : base(Price, Title, AdStatus, Description, Date, DogsNumber, Hours)
        {
            this.Owner = Owner;
        }
        public OwnerAd()
        : base()
        {

        }


    }
}
