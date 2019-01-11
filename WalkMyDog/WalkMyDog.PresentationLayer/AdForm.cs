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
    public partial class AdForm : Form, IAdView
    {
        IMainFormController MainFormController;
        public AdForm(IMainFormController MainFormController)
        {
            this.MainFormController = MainFormController;
            InitializeComponent();
        }

        public AdForm()
        {
            InitializeComponent();
        }
        private void ShowOwner(object sender, EventArgs e)
        {
            MainFormController.ShowOwner(this);
        }
        private void CreateAd(object sender, EventArgs e)
        {
            MainFormController.CreateAd(this);
        }
        private void UpdateAd(object sender, EventArgs e)
        {
            MainFormController.UpdateAd(this);
        }


        private void DeleteAd(object sender, EventArgs e)
        {
            MainFormController.DeleteAd(this);
        }

        public AdStatus AdStatus
        {
            get
            {
                if (checkBox1.Checked)
                {
                    return AdStatus.ACTIVE;
                }
                return AdStatus.ACCEPTED;
            }

            set
            {
                if (value.ToString() == AdStatus.ACTIVE.ToString())
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
        }
        public double Price
        {
            get
            {
                return (double)priceNumeric.Value;
            }

            set
            {
                priceNumeric.Value = (decimal)value;
            }
        }
        public string Title
        {
            get
            {
                return TitleTextBox.Text;
            }

            set
            {
                TitleTextBox.Text = value;
            }
        }
        public string Description
        {
            get
            {
                return DescriptionTextBox.Text;
            }

            set
            {
                DescriptionTextBox.Text = value;
            }
        }
        public int Hours
        {
            get
            {
                return (int)HoursNumeric.Value;
            }

            set
            {
                HoursNumeric.Value = (decimal)value;
            }
        }
        public int DogsNumber
        {
            get
            {
                return (int)DogsNumberNumeric.Value;
            }

            set
            {
                DogsNumberNumeric.Value = (decimal)value;
            }
        }

        public int AdId
        {
            get
            {
                return (int)Int32.Parse(adId.Text);
            }

            set
            {
                adId.Text = value.ToString();
            }
        }

        public void AdjustCreateView()
        {
            ViewOwnerDetailsButton.Hide();
            DeleteAdButton.Hide();
            UpdateAdButton.Hide();
            checkBox1.Hide();
            label13.Hide();
        }

        public void NotUsersAd()
        {
            UpdateAdButton.Hide();
            DeleteAdButton.Hide();
            
        }

        public void HideCreate()
        {
            CreateAdButton.Hide();
        }

        private void CloseForm2(object sender, FormClosedEventArgs e)
        {
            MainFormController.ShowMainForm();
        }


    }
}
