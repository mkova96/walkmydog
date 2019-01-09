using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkMyDog.Model;

namespace WalkMyDog.BaseLib
{
    public interface IAdView
    {
        int AdId { get; set; }
        void AdjustCreateView();
        void AdjustEditView();
        void AdjustApplyYesView();
        void AdjustApplyNoView();

        double Price { get; set; }
        string Title { get; set; }
        //AdStatus AdStatus { get; set; }
        string Description { get; set; }
        int DogsNumber { get; set; }
        int Hours { get; set; }

    }
}
