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
            //ReviewsButton.Hide();
        }
        public void AdjustEditView()
        {
            CreateAccountButton.Hide();
        }
        public void AdjustOuterView()
        {
            UpdateAccountButton.Hide();
            //ReviewsButton.Hide();
            CreateAccountButton.Hide();

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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
                var checkedButton = experiencePanel.Controls.OfType<RadioButton>()
                                                     .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name.Equals("Yes"))
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value == true)
                {
                    experienceYes.Checked = true;
                    experienceNo.Checked = false;
                }
                else
                {
                    experienceYes.Checked = false;
                    experienceNo.Checked = true;

                }
            }
        }

        public bool Dogs
        {
            get
            {
                var checkedButton = dogsPanel.Controls.OfType<RadioButton>()
                                                     .FirstOrDefault(r => r.Checked);
                if (checkedButton.Name.Equals("Yes"))
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value == true)
                {
                    dogsYes.Checked = true;
                    dogsNo.Checked = false;
                }
                else
                {
                    dogsYes.Checked = false;
                    dogsNo.Checked = true;

                }
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
    }
}
