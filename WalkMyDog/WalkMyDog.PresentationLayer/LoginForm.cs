using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WalkMyDog.BaseLib;

namespace WalkMyDog.PresentationLayer
{
    public partial class LoginForm : Form, ILoginView
    {

        private IMainFormController controller;
        public string GetUsername()
        {
            return usernameTextbox.Text;
        }
        public string GetPassword()
        {
            return passwordTextbox.Text;
        }




        public LoginForm(IMainFormController MainFormController)
        {
            this.controller = MainFormController;
            InitializeComponent();
        }

        public void Login(object sender, EventArgs e)
        {

            controller.LoginUser(this);
        }
        public void CreateWalker(object sender, EventArgs e)
        {
            controller.ShowWalkerForm(this);
            this.Hide();
        }
        public void CreateOwner(object sender, EventArgs e)
        {
            controller.ShowOwnerForm(this);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
