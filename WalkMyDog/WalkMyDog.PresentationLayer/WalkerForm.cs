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
    public partial class WalkerForm : Form, IWalkerView
    {
        IMainFormController MainFormController;
        public WalkerForm()
        {
            InitializeComponent();
        }
        public void AdjustCreateView()
        {
            UpdateAccountButton.Hide();
        }
        public void AdjustEditView()
        {
            CreateAccountButton.Hide();
        }
        public void AdjustOuterView()
        {
            UpdateAccountButton.Hide();
            CreateAccountButton.Hide();
            passwordTextbox.Hide();


        }


        public WalkerForm(IMainFormController MainFormController)
        {
            this.MainFormController = MainFormController;
            InitializeComponent();
        }

        private void CreateWalker(object sender, EventArgs e)
        {
            MainFormController.CreateWalker(this);
        }

        public string Username
        {
            get
            {
                return usernameTextbox.Text;
            }
            set
            {
                usernameTextbox.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return passwordTextbox.Text;
            }
            set
            {
                passwordTextbox.Text = value;
            }
        }

        public string Surname
        {
            get
            {
                return surnameTextbox.Text;
            }
            set
            {
                surnameTextbox.Text = value;
            }
        }

        public string Address
        {
            get
            {
                return addressTextbox.Text;
            }
            set
            {
                addressTextbox.Text = value;
            }
        }

        public string City
        {
            get
            {
                return cityTextbox.Text;
            }
            set
            {
                cityTextbox.Text = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneTextbox.Text;
            }
            set
            {
                phoneTextbox.Text = value;
            }
        }

        public int Age
        {
            get
            {
                return (int)ageNumeric.Value;
            }
            set
            {
                ageNumeric.Value = (int)value;
            }
        }

        public bool Experience
        {
            get
            {
                if (checkBox2.Checked)
                {
                    return true;
                }
                return false;
            }

            set
            {               
                checkBox2.Checked = value;
            }
        }

        public bool Dogs
        {
            get
            {
                if (checkBox1.Checked) {
                    return true;
                }
                return false;
            }
            
            set
            {
                checkBox1.Checked = value;

            }
        }

        public string WalkerName
        {
            get
            {
                return nameTextbox.Text;

            }
            set
            {
                nameTextbox.Text = value;
            }
        }

        public int WalkerId
        {
            get
            {
                return (int)Int32.Parse(walkerId.Text);
            }

            set
            {
                walkerId.Text = value.ToString();
            }
        }

        public void HideUpdateButton()
        {
            UpdateAccountButton.Hide();
        }

        public void HideViewReviewsButton()
        {
            ReviewsButton.Hide();
        }

        private void ageNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void UpdateWalker(object sender, EventArgs e)
        {
            MainFormController.UpdateWalker(this);
        }
    }
}
