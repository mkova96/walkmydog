namespace WalkMyDog.PresentationLayer
{
    partial class AdForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AcceptAdButton = new System.Windows.Forms.Button();
            this.adId = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.HoursNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DogsNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.UpdateAdButton = new System.Windows.Forms.Button();
            this.CreateAdButton = new System.Windows.Forms.Button();
            this.ViewOwnerDetailsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogsNumberNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.AcceptAdButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.adId, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.priceNumeric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TitleTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.HoursNumeric, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.DogsNumberNumeric, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.UpdateAdButton, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.CreateAdButton, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.ViewOwnerDetailsButton, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 325);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // AcceptAdButton
            // 
            this.AcceptAdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptAdButton.Location = new System.Drawing.Point(199, 288);
            this.AcceptAdButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AcceptAdButton.Name = "AcceptAdButton";
            this.AcceptAdButton.Size = new System.Drawing.Size(187, 28);
            this.AcceptAdButton.TabIndex = 35;
            this.AcceptAdButton.Text = "Apply to Ad";
            this.AcceptAdButton.UseVisualStyleBackColor = true;
            this.AcceptAdButton.Click += new System.EventHandler(this.AcceptAd);
            // 
            // adId
            // 
            this.adId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adId.Location = new System.Drawing.Point(4, 288);
            this.adId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adId.Name = "adId";
            this.adId.Size = new System.Drawing.Size(187, 28);
            this.adId.TabIndex = 34;
            this.adId.UseVisualStyleBackColor = true;
            this.adId.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price in € per hour:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceNumeric
            // 
            this.priceNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceNumeric.Location = new System.Drawing.Point(199, 9);
            this.priceNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(187, 22);
            this.priceNumeric.TabIndex = 13;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(199, 49);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(187, 22);
            this.TitleTextBox.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(199, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 32);
            this.panel1.TabIndex = 15;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(199, 129);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(187, 22);
            this.DescriptionTextBox.TabIndex = 16;
            // 
            // HoursNumeric
            // 
            this.HoursNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HoursNumeric.Location = new System.Drawing.Point(589, 89);
            this.HoursNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HoursNumeric.Name = "HoursNumeric";
            this.HoursNumeric.Size = new System.Drawing.Size(190, 22);
            this.HoursNumeric.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hours:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(394, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Number of dogs:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DogsNumberNumeric
            // 
            this.DogsNumberNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DogsNumberNumeric.Location = new System.Drawing.Point(589, 169);
            this.DogsNumberNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DogsNumberNumeric.Name = "DogsNumberNumeric";
            this.DogsNumberNumeric.Size = new System.Drawing.Size(190, 22);
            this.DogsNumberNumeric.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 251);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Ad status:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateAdButton
            // 
            this.UpdateAdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateAdButton.Location = new System.Drawing.Point(589, 288);
            this.UpdateAdButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateAdButton.Name = "UpdateAdButton";
            this.UpdateAdButton.Size = new System.Drawing.Size(190, 28);
            this.UpdateAdButton.TabIndex = 25;
            this.UpdateAdButton.Text = "Update Ad info";
            this.UpdateAdButton.UseVisualStyleBackColor = true;
            // 
            // CreateAdButton
            // 
            this.CreateAdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateAdButton.Location = new System.Drawing.Point(589, 246);
            this.CreateAdButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateAdButton.Name = "CreateAdButton";
            this.CreateAdButton.Size = new System.Drawing.Size(190, 28);
            this.CreateAdButton.TabIndex = 33;
            this.CreateAdButton.Text = "Create Ad";
            this.CreateAdButton.UseVisualStyleBackColor = true;
            this.CreateAdButton.Click += new System.EventHandler(this.CreateAd);
            // 
            // ViewOwnerDetailsButton
            // 
            this.ViewOwnerDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewOwnerDetailsButton.Location = new System.Drawing.Point(394, 288);
            this.ViewOwnerDetailsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewOwnerDetailsButton.Name = "ViewOwnerDetailsButton";
            this.ViewOwnerDetailsButton.Size = new System.Drawing.Size(187, 28);
            this.ViewOwnerDetailsButton.TabIndex = 31;
            this.ViewOwnerDetailsButton.Text = "View Ad owner details";
            this.ViewOwnerDetailsButton.UseVisualStyleBackColor = true;
            this.ViewOwnerDetailsButton.Click += new System.EventHandler(this.ShowOwner);
            // 
            // AdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 325);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdForm";
            this.Text = "Ad details";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogsNumberNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.NumericUpDown HoursNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown DogsNumberNumeric;
        private System.Windows.Forms.Button UpdateAdButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ViewOwnerDetailsButton;
        private System.Windows.Forms.Button CreateAdButton;
        private System.Windows.Forms.Button adId;
        private System.Windows.Forms.Button AcceptAdButton;
    }
}