using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkMyDog.BaseLib;

namespace WalkMyDog.PresentationLayer
{
    public class WindowFormsFactory : IWindowFormsFactory
    {
        public ILoginView CreateLoginView(IMainFormController MainFormController)
        {
            var newFrm = new LoginForm(MainFormController);

            return newFrm;
        }
        public IMainView CreateMainView(IMainFormController MainFormController)
        {
            var newFrm = new MainForm(MainFormController);

            return newFrm;
        }
        

        public IWalkerView CreateWalkerView(IMainFormController MainFormController)
        {
            return new WalkerForm(MainFormController);
        }

        public IOwnerView CreateOwnerView(IMainFormController MainFormController)
        {
            return null;
            //return new OwnerForm(MainFormController);
        }

        public IAdView CreateAdView(IMainFormController MainFormController)
        {
            return null;

            //return new AdForm(MainFormController);
        }

    }
}
