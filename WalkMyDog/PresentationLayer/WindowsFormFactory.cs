using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkMyDog.BaseLib;

namespace WalkMyDog.PresentationLayer
{
    public class WindowsFormFactory : IWindowFormsFactory
    {
        public ILoginView CreateLoginView(IMainFormController MainFormController)
        {
            var newFrm = new LoginForm(MainFormController);

            return newFrm;
        }
    }
}
