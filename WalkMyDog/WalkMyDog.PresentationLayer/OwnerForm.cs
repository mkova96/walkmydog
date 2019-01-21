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
    public partial class OwnerForm : Form, IOwnerView
    {
        IMainFormController MainFormController;
        public OwnerForm(IMainFormController MainFormController)
        {
            this.MainFormController = MainFormController;
            InitializeComponent();
        }

        private void CreateOwner(object sender, EventArgs e)
        {
            MainFormController.CreateOwner(this);
        }

        public string Username
        {
            get
            {
                return UsernameTextBox.Text;
            }

            set
            {
                UsernameTextBox.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return PasswordTextBox.Text;
            }

            set
            {
                PasswordTextBox.Text = value;
            }
        }
        public string OwnerName
        {
            get
            {
                return NameTextBox.Text;
            }

            set
            {
                NameTextBox.Text = value;
            }
        }
        public string Surname
        {
            get
            {
                return SurnameTextBox.Text;
            }

            set
            {
                SurnameTextBox.Text = value;
            }
        }
        public string Address
        {
            get
            {
                return AddressTextBox.Text;
            }

            set
            {
                AddressTextBox.Text = value;
            }
        }
        public string PhoneNumber {
            get
            {
                return PhoneTextBox.Text;
            }

            set
            {
                PhoneTextBox.Text = value;
            }
        }
        public string City {
            get
            {
                return CityTextBox.Text;
            }

            set
            {
                CityTextBox.Text = value;
            }
        }
        public int Age {
            get
            {
                return (int)AgeNumericUpDown.Value;
            }

            set
            {
                AgeNumericUpDown.Value =(int) value;
            }
        }

        public void AdjustCreateView()
        {
            UpdateOwnerButton.Hide();
        }

        public void AdjustEditView()
        {
            CreateOwnerButton.Hide();

        }

        public void AdjustOuterView()
        {
            UpdateOwnerButton.Hide();
            CreateOwnerButton.Hide();
            PasswordTextBox.Hide();

        }


        private void UpdateOwner(object sender, EventArgs e)
        {
            MainFormController.UpdateOwner(this);
        }
        private void OwnerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFormController.CloseThatFrom();

        }
    }
}
