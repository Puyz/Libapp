
namespace Libapp.Pages
{
    partial class MainMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMember));
            this.menuPanel = new DevExpress.XtraEditors.SidePanel();
            this.booksButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bilgilerimLabel = new System.Windows.Forms.Label();
            this.menuUserPanel = new System.Windows.Forms.Panel();
            this.menuUserName = new System.Windows.Forms.Label();
            this.menuImage = new System.Windows.Forms.PictureBox();
            this.myBooks = new Libapp.UserControls.MainMember.MyBooks();
            this.profileButton = new Libapp.UI.SmoothButton();
            this.signOutButton = new Libapp.UI.SmoothButton();
            this.menuPanel.SuspendLayout();
            this.menuUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AllowResize = false;
            this.menuPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.menuPanel.Appearance.Options.UseBackColor = true;
            this.menuPanel.Controls.Add(this.booksButton);
            this.menuPanel.Controls.Add(this.splitter1);
            this.menuPanel.Controls.Add(this.bilgilerimLabel);
            this.menuPanel.Controls.Add(this.menuUserPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 633);
            this.menuPanel.TabIndex = 2;
            this.menuPanel.Text = "sidePanel1";
            // 
            // booksButton
            // 
            this.booksButton.AllowFocus = false;
            this.booksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.booksButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("booksButton.ImageOptions.Image")));
            this.booksButton.Location = new System.Drawing.Point(0, 222);
            this.booksButton.Name = "booksButton";
            this.booksButton.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.booksButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.booksButton.Size = new System.Drawing.Size(199, 35);
            this.booksButton.TabIndex = 1;
            this.booksButton.Text = "Kitaplarım";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 212);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(199, 10);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // bilgilerimLabel
            // 
            this.bilgilerimLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgilerimLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgilerimLabel.ForeColor = System.Drawing.Color.Gray;
            this.bilgilerimLabel.Location = new System.Drawing.Point(0, 155);
            this.bilgilerimLabel.Margin = new System.Windows.Forms.Padding(3);
            this.bilgilerimLabel.Name = "bilgilerimLabel";
            this.bilgilerimLabel.Padding = new System.Windows.Forms.Padding(10, 40, 0, 0);
            this.bilgilerimLabel.Size = new System.Drawing.Size(199, 57);
            this.bilgilerimLabel.TabIndex = 2;
            this.bilgilerimLabel.Text = "BİLGİLERİM";
            // 
            // menuUserPanel
            // 
            this.menuUserPanel.Controls.Add(this.profileButton);
            this.menuUserPanel.Controls.Add(this.signOutButton);
            this.menuUserPanel.Controls.Add(this.menuUserName);
            this.menuUserPanel.Controls.Add(this.menuImage);
            this.menuUserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuUserPanel.Location = new System.Drawing.Point(0, 0);
            this.menuUserPanel.Name = "menuUserPanel";
            this.menuUserPanel.Size = new System.Drawing.Size(199, 155);
            this.menuUserPanel.TabIndex = 0;
            // 
            // menuUserName
            // 
            this.menuUserName.AutoEllipsis = true;
            this.menuUserName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuUserName.ForeColor = System.Drawing.Color.Gray;
            this.menuUserName.Location = new System.Drawing.Point(3, 88);
            this.menuUserName.Name = "menuUserName";
            this.menuUserName.Size = new System.Drawing.Size(192, 31);
            this.menuUserName.TabIndex = 0;
            this.menuUserName.Text = "ÖMER TEMEL";
            this.menuUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuImage
            // 
            this.menuImage.BackColor = System.Drawing.Color.Transparent;
            this.menuImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuImage.BackgroundImage")));
            this.menuImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuImage.Image = global::Libapp.Properties.Resources.man;
            this.menuImage.Location = new System.Drawing.Point(69, 15);
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(60, 60);
            this.menuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuImage.TabIndex = 1;
            this.menuImage.TabStop = false;
            // 
            // myBooks
            // 
            this.myBooks.BackColor = System.Drawing.Color.White;
            this.myBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myBooks.Location = new System.Drawing.Point(200, 0);
            this.myBooks.Name = "myBooks";
            this.myBooks.Size = new System.Drawing.Size(734, 633);
            this.myBooks.TabIndex = 3;
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(254)))));
            this.profileButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(254)))));
            this.profileButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.profileButton.BorderRadius = 13;
            this.profileButton.BorderSize = 0;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Location = new System.Drawing.Point(10, 122);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(86, 26);
            this.profileButton.TabIndex = 3;
            this.profileButton.Text = "Profilim";
            this.profileButton.TextColor = System.Drawing.Color.White;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.signOutButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.signOutButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.signOutButton.BorderRadius = 13;
            this.signOutButton.BorderSize = 0;
            this.signOutButton.FlatAppearance.BorderSize = 0;
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.ForeColor = System.Drawing.Color.White;
            this.signOutButton.Location = new System.Drawing.Point(99, 122);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(86, 26);
            this.signOutButton.TabIndex = 2;
            this.signOutButton.Text = "Çıkış yap";
            this.signOutButton.TextColor = System.Drawing.Color.White;
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // MainMember
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 633);
            this.Controls.Add(this.myBooks);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(936, 665);
            this.Name = "MainMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libapp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMember_FormClosed);
            this.Load += new System.EventHandler(this.MainMember_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuUserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel menuPanel;
        private DevExpress.XtraEditors.SimpleButton booksButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label bilgilerimLabel;
        private System.Windows.Forms.Panel menuUserPanel;
        private UI.SmoothButton signOutButton;
        private System.Windows.Forms.Label menuUserName;
        private System.Windows.Forms.PictureBox menuImage;
        private UI.SmoothButton profileButton;
        private UserControls.MainMember.MyBooks myBooks;
    }
}