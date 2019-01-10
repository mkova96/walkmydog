using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.BaseLib
{
    public interface IOwnerView
    {
        string Username { get; set; }
        string Password { get; set; }
        string OwnerName { get; set; }
        string Surname { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string City { get; set; }
        int Age { get; set; }
        void AdjustCreateView();
        void AdjustEditView();
        void AdjustOuterView();
    }
}
