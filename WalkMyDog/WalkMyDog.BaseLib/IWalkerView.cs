using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.BaseLib
{
    public interface IWalkerView
    {

        int WalkerId { get; set; }
        void AdjustCreateView();
        void AdjustEditView();
        void AdjustOuterView();

        void HideUpdateButton();
        void HideViewReviewsButton();

        string Username { get; set; }
        string Password { get; set; }
        string WalkerName { get; set; }
        string Surname { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string City { get; set; }
        int Age { get; set; }
        bool Experience { get; set; }
        bool Dogs { get; set; }
    }
}
