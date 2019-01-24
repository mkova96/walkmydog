using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WalkMyDog.BaseLib;
using WalkMyDog.Model;
using WalkMyDog.Model.Repositories;

namespace WalkMyDog.Controllers
{
    public class AccountController
    {
        IMainView MainView;

        public User Login(IUserRepository UserRepository, ILoginView LoginView, IMainFormController MainController)
        {
            string Username = LoginView.GetUsername();
            string Password = LoginView.GetPassword();

            if (Username.Length == 0 || Password.Length == 0)
            {

                MessageBox.Show("Niste unijeli korisničko ime/lozinku");
                return null;
            }
            var frm = (Form)LoginView;

            Walker Walker = UserRepository.GetWalker(Username);
            if (Walker != null)
            {
                frm.Hide();
                frm.ShowInTaskbar = false;
                return Walker;
            }

            Owner Owner = UserRepository.GetOwner(Username);

            if (Owner != null)
            {
                frm.Hide();
                frm.ShowInTaskbar = false;
                return Owner;
            }

            MessageBox.Show("Netočno korisničko ime ili lozinka");
            return null;


        }

        public void ShowLoginForm(ILoginView LoginView)
        {
            var form = (Form)LoginView;
            form.Show();
        }

    }
}
