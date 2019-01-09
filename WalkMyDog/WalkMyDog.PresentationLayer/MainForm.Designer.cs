namespace WalkMyDog.PresentationLayer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WalkerAdsList = new System.Windows.Forms.ListView();

            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));           ///PAZI
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dogs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.OwnerAdsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loginButton = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giving services";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(576, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Looking for services";
            // 
            // WalkerAdsList
            // 
            this.WalkerAdsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.username,
            this.dogs,
            this.Price,
            this.date});
            this.WalkerAdsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WalkerAdsList.HoverSelection = true;
            this.WalkerAdsList.Location = new System.Drawing.Point(36, 96);
            this.WalkerAdsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WalkerAdsList.Name = "WalkerAdsList";
            this.WalkerAdsList.Size = new System.Drawing.Size(501, 249);
            this.WalkerAdsList.TabIndex = 3;
            this.WalkerAdsList.UseCompatibleStateImageBehavior = false;
            this.WalkerAdsList.View = System.Windows.Forms.View.Details;
            this.WalkerAdsList.SelectedIndexChanged += new System.EventHandler(this.WalkerAdsList_SelectedIndexChanged);
            this.WalkerAdsList.Click += new System.EventHandler(this.ShowWalkerAd);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // username
            // 
            this.username.Text = "Korisnicko ime";
            this.username.Width = 75;
            // 
            // dogs
            // 
            this.dogs.Text = "Broj pasa";
            this.dogs.Width = 71;
            // 
            // Price
            // 
            this.Price.Text = "Cijena/sat (HRK)";
            this.Price.Width = 95;
            // 
            // date
            // 
            this.date.Text = "Datum izdavanja";
            // 
            // OwnerAdsList
            // 
            this.OwnerAdsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.OwnerAdsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OwnerAdsList.Location = new System.Drawing.Point(580, 96);
            this.OwnerAdsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OwnerAdsList.Name = "OwnerAdsList";
            this.OwnerAdsList.Size = new System.Drawing.Size(496, 249);
            this.OwnerAdsList.TabIndex = 4;
            this.OwnerAdsList.UseCompatibleStateImageBehavior = false;
            this.OwnerAdsList.View = System.Windows.Forms.View.Details;
            this.OwnerAdsList.Click += new System.EventHandler(this.ShowOwnerAd);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Korisnicko ime";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Broj pasa";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Cijena/sat (HRK)";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 4;
            this.columnHeader4.Text = "Datum izdavanja";
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 0;
            this.columnHeader5.Text = "Id";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.Location = new System.Drawing.Point(36, 380);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(1041, 71);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login or create account";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.ShowLoginForm);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.AdsToolStripMenuItem });
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1129, 28);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.loginToolStripMenuItem.Text = "My profile";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.ShowMyProfile);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.Logout);
            // 
            // AdsToolStripMenuItem
            // 
            this.AdsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdToolStripMenuItem});
            this.AdsToolStripMenuItem.Name = "AdsToolStripMenuItem";
            this.AdsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.AdsToolStripMenuItem.Text = "Ads";
            // 
            // addAdToolStripMenuItem
            // 
            this.addAdToolStripMenuItem.Name = "addAdToolStripMenuItem";
            this.addAdToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.addAdToolStripMenuItem.Text = "Add Ad";
            this.addAdToolStripMenuItem.Click += new System.EventHandler(this.ShowAdForm);


            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLabel.Location = new System.Drawing.Point(32, 30);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 20);
            this.welcomeLabel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 475);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.OwnerAdsList);
            this.Controls.Add(this.WalkerAdsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "StartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView WalkerAdsList;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader dogs;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ListView OwnerAdsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdToolStripMenuItem;

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}