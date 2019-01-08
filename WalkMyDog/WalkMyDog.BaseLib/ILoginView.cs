using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.BaseLib
{
    public interface ILoginView
    {
        string GetUsername();
        string GetPassword();

    }
}
