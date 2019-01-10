using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WalkMyDog.BaseLib;
using WalkMyDog.Model;

namespace WalkMyDog.PresentationLayer
{
    public partial class MainForm : Form, IMainView
    {
        private IMainFormController MainController;

        public MainForm(IMainFormController MainController)
        {
            this.MainController = MainController;
            InitializeComponent();
            this.menu.Enabled = false;
            MainController.InitializeLists(this);
            WalkerAdsList.FullRowSelect = true;
            OwnerAdsList.FullRowSelect = true;
        }

        public void ShowLoginButton()
        {
            loginButton.Show();
        }

        private void ShowMyProfile(object sender, EventArgs e)
        {
            MainController.ShowMyProfile();
        }
        private void Logout(object sender, EventArgs e)
        {
            MainController.Logout(this);
        }


        private void ShowWalkerAd(object sender, EventArgs e)
        {
            ListViewItem firstSelectedItem = WalkerAdsList.SelectedItems[0];
            int Id = Int32.Parse(firstSelectedItem.SubItems[4].Text.ToString());
            MainController.ShowAdForm(Id, this);
        }
        private void ShowOwnerAd(object sender, EventArgs e)
        {
            ListViewItem firstSelectedItem = OwnerAdsList.SelectedItems[0];
            int Id = Int32.Parse(firstSelectedItem.SubItems[4].Text.ToString());
            MainController.ShowAdForm(Id, this);
        }

        public void ShowLoginForm(object sender, EventArgs e)
        {
            MainController.ShowLoginForm(this);
        }

        public void ShowAdForm(object sender, EventArgs e)
        {
            MainController.ShowAdForm(this);
        }
        public void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void HideLoginButton()
        {
            this.loginButton.Hide();
        }



        public void SetWelcomeLabel(string text)
        {
            welcomeLabel.Text = text;
        }


        public void EnableMenu()
        {
            menu.Enabled = true;
        }

        public void DisableMenu()
        {
            menu.Enabled = false;
        }

        public List<WalkerAd> WalkerAds
        {
            get
            {
                return null;
            }
            set
            {
                foreach (var o in value)
                {
                    WalkerAdsList.Items.Add(new ListViewItem(new[] { o.Date.ToShortDateString(), o.Walker.Username, o.Price.ToString(), o.DogsNumber.ToString(),o.Id.ToString()})); ///// PAZI 

                }


            }
        }

        public List<OwnerAd> OwnerAds
        {
            get
            {
                return null;
            }
            set
            {
                foreach (var o in value)
                {
                    OwnerAdsList.Items.Add(new ListViewItem(new[] { o.Date.ToShortDateString(), o.Owner.Username, o.Price.ToString(), o.DogsNumber.ToString(), o.Id.ToString() }));  ///// PAZI

                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void WalkerAdsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
