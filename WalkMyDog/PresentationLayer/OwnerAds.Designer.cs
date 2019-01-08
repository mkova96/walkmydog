namespace PresentationLayer
{
    partial class OwnerAds
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
            this.OwnerAdsList = new System.Windows.Forms.ListView();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mojProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oglasiVlasnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oglasiSetacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OwnerAdsList
            // 
            this.OwnerAdsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.username,
            this.city,
            this.Price,
            this.date});
            this.OwnerAdsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OwnerAdsList.HoverSelection = true;
            this.OwnerAdsList.Location = new System.Drawing.Point(89, 158);
            this.OwnerAdsList.Margin = new System.Windows.Forms.Padding(4);
            this.OwnerAdsList.Name = "OwnerAdsList";
            this.OwnerAdsList.Size = new System.Drawing.Size(636, 241);
            this.OwnerAdsList.TabIndex = 4;
            this.OwnerAdsList.UseCompatibleStateImageBehavior = false;
            this.OwnerAdsList.View = System.Windows.Forms.View.Details;
            this.OwnerAdsList.SelectedIndexChanged += new System.EventHandler(this.OwnerAdsList_SelectedIndexChanged);
            // 
            // username
            // 
            this.username.Text = "Korisnicko ime";
            this.username.Width = 110;
            // 
            // city
            // 
            this.city.Text = "Grad";
            this.city.Width = 71;
            // 
            // Price
            // 
            this.Price.Text = "Cijena/sat";
            this.Price.Width = 86;
            // 
            // date
            // 
            this.date.Text = "Datum izdavanja";
            this.date.Width = 132;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojProfilToolStripMenuItem,
            this.oglasiVlasnikaToolStripMenuItem,
            this.oglasiSetacaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mojProfilToolStripMenuItem
            // 
            this.mojProfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urediToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.mojProfilToolStripMenuItem.Name = "mojProfilToolStripMenuItem";
            this.mojProfilToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.mojProfilToolStripMenuItem.Text = "Moj profil";
            // 
            // urediToolStripMenuItem
            // 
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.urediToolStripMenuItem.Text = "Uredi";
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            // 
            // oglasiVlasnikaToolStripMenuItem
            // 
            this.oglasiVlasnikaToolStripMenuItem.Name = "oglasiVlasnikaToolStripMenuItem";
            this.oglasiVlasnikaToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.oglasiVlasnikaToolStripMenuItem.Text = "Oglasi vlasnika";
            // 
            // oglasiSetacaToolStripMenuItem
            // 
            this.oglasiSetacaToolStripMenuItem.Name = "oglasiSetacaToolStripMenuItem";
            this.oglasiSetacaToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.oglasiSetacaToolStripMenuItem.Text = "Oglasi setaca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(166, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(495, 88);
            this.label9.TabIndex = 49;
            this.label9.Text = "Oglasi vlasnika";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 54;
            this.button1.Text = "Novi oglas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OwnerAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OwnerAdsList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OwnerAds";
            this.Text = "OwnerAds";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView OwnerAdsList;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mojProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oglasiVlasnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oglasiSetacaToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}