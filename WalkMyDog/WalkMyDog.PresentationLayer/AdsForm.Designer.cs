namespace WalkMyDog.PresentationLayer
{
    partial class AdsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WalkerAdListView = new System.Windows.Forms.ListView();
            this.UsernameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeadlineColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OwnerAdListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackButton = new System.Windows.Forms.Button();
            this.CreateAdButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.OwnerAdListView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WalkerAdListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BackButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CreateAdButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giving services";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Looking for services";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WalkerAdListView
            // 
            this.WalkerAdListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UsernameColumnHeader,
            this.CityColumnHeader,
            this.PriceColumnHeader,
            this.DeadlineColumnHeader});
            this.WalkerAdListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WalkerAdListView.Location = new System.Drawing.Point(3, 29);
            this.WalkerAdListView.Name = "WalkerAdListView";
            this.WalkerAdListView.Size = new System.Drawing.Size(303, 189);
            this.WalkerAdListView.TabIndex = 2;
            this.WalkerAdListView.UseCompatibleStateImageBehavior = false;
            this.WalkerAdListView.View = System.Windows.Forms.View.Details;
            // 
            // UsernameColumnHeader
            // 
            this.UsernameColumnHeader.Text = "Username";
            // 
            // CityColumnHeader
            // 
            this.CityColumnHeader.Text = "City";
            this.CityColumnHeader.Width = 43;
            // 
            // PriceColumnHeader
            // 
            this.PriceColumnHeader.Text = "Price per hour";
            this.PriceColumnHeader.Width = 83;
            // 
            // DeadlineColumnHeader
            // 
            this.DeadlineColumnHeader.Text = "Deadline";
            // 
            // OwnerAdListView
            // 
            this.OwnerAdListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.OwnerAdListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OwnerAdListView.Location = new System.Drawing.Point(312, 29);
            this.OwnerAdListView.Name = "OwnerAdListView";
            this.OwnerAdListView.Size = new System.Drawing.Size(304, 189);
            this.OwnerAdListView.TabIndex = 3;
            this.OwnerAdListView.UseCompatibleStateImageBehavior = false;
            this.OwnerAdListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "City";
            this.columnHeader2.Width = 43;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price per hour";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Deadline";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(3, 229);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(303, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // CreateAdButton
            // 
            this.CreateAdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateAdButton.Location = new System.Drawing.Point(312, 229);
            this.CreateAdButton.Name = "CreateAdButton";
            this.CreateAdButton.Size = new System.Drawing.Size(304, 23);
            this.CreateAdButton.TabIndex = 5;
            this.CreateAdButton.Text = "Create new offer";
            this.CreateAdButton.UseVisualStyleBackColor = true;
            // 
            // AdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdsForm";
            this.Text = "Ads";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView WalkerAdListView;
        private System.Windows.Forms.ColumnHeader UsernameColumnHeader;
        private System.Windows.Forms.ColumnHeader CityColumnHeader;
        private System.Windows.Forms.ColumnHeader DeadlineColumnHeader;
        private System.Windows.Forms.ColumnHeader PriceColumnHeader;
        private System.Windows.Forms.ListView OwnerAdListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CreateAdButton;
    }
}