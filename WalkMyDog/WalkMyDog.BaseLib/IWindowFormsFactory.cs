using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.BaseLib
{
    public interface IWindowFormsFactory
    {
        ILoginView CreateLoginView(IMainFormController MainFormController);
        IWalkerView CreateWalkerView(IMainFormController MainFormController);
        IMainView CreateMainView(IMainFormController MainFormController);
        IOwnerView CreateOwnerView(IMainFormController MainFormController);
        IAdView CreateAdView(IMainFormController MainFormController);

    }
}
