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

        public User Login(IUserRepository UserRepository, ILoginView LoginView, IMainFormController MainController
            )
        {
            string Username = LoginView.GetUsername();
            string Password = LoginView.GetPassword();

            if (Username.Length == 0 || Password.Length == 0)
            {

                MessageBox.Show("Please fill all the fields");
                return null;
            }
            var frm = (Form)LoginView;
            Admin Admin = UserRepository.GetAdmin(Username, Password);
            if (Admin != null)
            {
                return Admin;
                //  MainController.ShowAdminView()
            }
            Walker Walker = UserRepository.GetWalker(Username, Password);
            if (Walker != null)
            {
                frm.Hide();
                frm.ShowInTaskbar = false;
                return Walker;
            }

            Owner Owner = UserRepository.GetOwner(Username, Password);

            if (Owner != null)
            {
                frm.Hide();
                frm.ShowInTaskbar = false;
                return Owner;
            }

            MessageBox.Show("Invalid username or password, please try again.");
            return null;


        }

        public void ShowLoginForm(ILoginView LoginView)
        {
            var form = (Form)LoginView;
            form.Show();
        }

    }
}
