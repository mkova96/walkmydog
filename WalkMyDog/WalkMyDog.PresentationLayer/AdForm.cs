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
        private void AcceptAd(object sender, EventArgs e)
        {
            MainFormController.AcceptAd(this.AdId);
            this.Hide();
        }

        private void DeleteAd(object sender, EventArgs e)
        {
            MainFormController.DeleteAd(this);
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
            AcceptAdButton.Hide();
            ViewOwnerDetailsButton.Hide();
            DeleteAdButton.Hide();
            UpdateAdButton.Hide();
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

    }
}
