using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model
{
    public class WalkerAd : Ad
    {
        public virtual Walker Walker { get; set; }

        public WalkerAd()
            : base()
        {

        }
        public WalkerAd(double Price, string Title, AdStatus AdStatus, string Description,
        DateTime Date, int DogsNumber, int Hours)
            : base(Price, Title, AdStatus, Description, Date, DogsNumber, Hours)
        {
            this.Walker = Walker;
        }
    }
}
