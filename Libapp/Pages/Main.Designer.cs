
namespace Libapp.Pages
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuUserName = new System.Windows.Forms.Label();
            this.menuPanel = new DevExpress.XtraEditors.SidePanel();
            this.logsButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.addOrEditButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.islemlerLabel = new System.Windows.Forms.Label();
            this.membersButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.booksButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listelerLabel = new System.Windows.Forms.Label();
            this.menuUserPanel = new System.Windows.Forms.Panel();
            this.signOutButton = new Libapp.UI.SmoothButton();
            this.menuImage = new System.Windows.Forms.PictureBox();
            this.books = new Libapp.UserControls.Books();
            this.logs = new Libapp.UserControls.Logs();
            this.members = new Libapp.UserControls.Members();
            this.addOrEdit = new Libapp.UserControls.AddOrEdit();
            this.menuPanel.SuspendLayout();
            this.menuUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuUserName
            // 
            this.menuUserName.AutoEllipsis = true;
            this.menuUserName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuUserName.ForeColor = System.Drawing.Color.Gray;
            this.menuUserName.Location = new System.Drawing.Point(3, 88);
            this.menuUserName.Name = "menuUserName";
            this.menuUserName.Size = new System.Drawing.Size(179, 31);
            this.menuUserName.TabIndex = 0;
            this.menuUserName.Text = "ÖMER TEMEL";
            this.menuUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuPanel
            // 
            this.menuPanel.AllowResize = false;
            this.menuPanel.Controls.Add(this.logsButton);
            this.menuPanel.Controls.Add(this.splitter4);
            this.menuPanel.Controls.Add(this.addOrEditButton);
            this.menuPanel.Controls.Add(this.splitter3);
            this.menuPanel.Controls.Add(this.islemlerLabel);
            this.menuPanel.Controls.Add(this.membersButton);
            this.menuPanel.Controls.Add(this.splitter2);
            this.menuPanel.Controls.Add(this.booksButton);
            this.menuPanel.Controls.Add(this.splitter1);
            this.menuPanel.Controls.Add(this.listelerLabel);
            this.menuPanel.Controls.Add(this.menuUserPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(186, 736);
            this.menuPanel.TabIndex = 1;
            this.menuPanel.Text = "sidePanel1";
            // 
            // logsButton
            // 
            this.logsButton.AllowFocus = false;
            this.logsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logsButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("logsButton.ImageOptions.Image")));
            this.logsButton.Location = new System.Drawing.Point(0, 401);
            this.logsButton.Name = "logsButton";
            this.logsButton.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.logsButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.logsButton.Size = new System.Drawing.Size(185, 35);
            this.logsButton.TabIndex = 7;
            this.logsButton.Text = "Geçmiş";
            this.logsButton.Click += new System.EventHandler(this.logsButton_Click);
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Enabled = false;
            this.splitter4.Location = new System.Drawing.Point(0, 391);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(185, 10);
            this.splitter4.TabIndex = 10;
            this.splitter4.TabStop = false;
            // 
            // addOrEditButton
            // 
            this.addOrEditButton.AllowFocus = false;
            this.addOrEditButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addOrEditButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addOrEditButton.ImageOptions.Image")));
            this.addOrEditButton.Location = new System.Drawing.Point(0, 356);
            this.addOrEditButton.Name = "addOrEditButton";
            this.addOrEditButton.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.addOrEditButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.addOrEditButton.Size = new System.Drawing.Size(185, 35);
            this.addOrEditButton.TabIndex = 9;
            this.addOrEditButton.Text = "Ekle / Düzenle";
            this.addOrEditButton.Click += new System.EventHandler(this.addOrEditButton_Click);
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(0, 346);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(185, 10);
            this.splitter3.TabIndex = 8;
            this.splitter3.TabStop = false;
            // 
            // islemlerLabel
            // 
            this.islemlerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.islemlerLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemlerLabel.ForeColor = System.Drawing.Color.Gray;
            this.islemlerLabel.Location = new System.Drawing.Point(0, 302);
            this.islemlerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.islemlerLabel.Name = "islemlerLabel";
            this.islemlerLabel.Padding = new System.Windows.Forms.Padding(10, 25, 0, 0);
            this.islemlerLabel.Size = new System.Drawing.Size(185, 44);
            this.islemlerLabel.TabIndex = 6;
            this.islemlerLabel.Text = "İŞLEMLER";
            // 
            // membersButton
            // 
            this.membersButton.AllowFocus = false;
            this.membersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.membersButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("membersButton.ImageOptions.SvgImage")));
            this.membersButton.Location = new System.Drawing.Point(0, 267);
            this.membersButton.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.membersButton.Name = "membersButton";
            this.membersButton.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.membersButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.membersButton.Size = new System.Drawing.Size(185, 35);
            this.membersButton.TabIndex = 3;
            this.membersButton.Text = "Üyeler";
            this.membersButton.Click += new System.EventHandler(this.membersButton_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(0, 257);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(185, 10);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
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
            this.booksButton.Size = new System.Drawing.Size(185, 35);
            this.booksButton.TabIndex = 1;
            this.booksButton.Text = "Kitaplar";
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 212);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(185, 10);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // listelerLabel
            // 
            this.listelerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listelerLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listelerLabel.ForeColor = System.Drawing.Color.Gray;
            this.listelerLabel.Location = new System.Drawing.Point(0, 155);
            this.listelerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.listelerLabel.Name = "listelerLabel";
            this.listelerLabel.Padding = new System.Windows.Forms.Padding(10, 40, 0, 0);
            this.listelerLabel.Size = new System.Drawing.Size(185, 57);
            this.listelerLabel.TabIndex = 2;
            this.listelerLabel.Text = "LİSTELER";
            // 
            // menuUserPanel
            // 
            this.menuUserPanel.Controls.Add(this.signOutButton);
            this.menuUserPanel.Controls.Add(this.menuUserName);
            this.menuUserPanel.Controls.Add(this.menuImage);
            this.menuUserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuUserPanel.Location = new System.Drawing.Point(0, 0);
            this.menuUserPanel.Name = "menuUserPanel";
            this.menuUserPanel.Size = new System.Drawing.Size(185, 155);
            this.menuUserPanel.TabIndex = 0;
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
            this.signOutButton.Location = new System.Drawing.Point(49, 122);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(86, 26);
            this.signOutButton.TabIndex = 2;
            this.signOutButton.Text = "Çıkış yap";
            this.signOutButton.TextColor = System.Drawing.Color.White;
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // menuImage
            // 
            this.menuImage.BackColor = System.Drawing.Color.Transparent;
            this.menuImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuImage.BackgroundImage")));
            this.menuImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuImage.Image = global::Libapp.Properties.Resources.man;
            this.menuImage.Location = new System.Drawing.Point(62, 15);
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(60, 60);
            this.menuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuImage.TabIndex = 1;
            this.menuImage.TabStop = false;
            // 
            // books
            // 
            this.books.Dock = System.Windows.Forms.DockStyle.Fill;
            this.books.Location = new System.Drawing.Point(186, 0);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(996, 736);
            this.books.TabIndex = 2;
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.Color.White;
            this.logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logs.Location = new System.Drawing.Point(186, 0);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(996, 736);
            this.logs.TabIndex = 3;
            // 
            // members
            // 
            this.members.Dock = System.Windows.Forms.DockStyle.Fill;
            this.members.Location = new System.Drawing.Point(186, 0);
            this.members.Name = "members";
            this.members.Size = new System.Drawing.Size(996, 736);
            this.members.TabIndex = 4;
            // 
            // addOrEdit
            // 
            this.addOrEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOrEdit.Location = new System.Drawing.Point(186, 0);
            this.addOrEdit.Name = "addOrEdit";
            this.addOrEdit.Size = new System.Drawing.Size(996, 736);
            this.addOrEdit.TabIndex = 5;
            // 
            // Main
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 736);
            this.Controls.Add(this.books);
            this.Controls.Add(this.addOrEdit);
            this.Controls.Add(this.members);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.menuPanel);
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libapp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuUserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label menuUserName;
        private DevExpress.XtraEditors.SidePanel menuPanel;
        private System.Windows.Forms.PictureBox menuImage;
        private System.Windows.Forms.Panel menuUserPanel;
        private DevExpress.XtraEditors.SimpleButton booksButton;
        private System.Windows.Forms.Label listelerLabel;
        private DevExpress.XtraEditors.SimpleButton membersButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label islemlerLabel;
        private DevExpress.XtraEditors.SimpleButton logsButton;
        private DevExpress.XtraEditors.SimpleButton addOrEditButton;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private UI.SmoothButton signOutButton;
        private UserControls.Logs logs;
        private UserControls.Members members;
        public UserControls.AddOrEdit addOrEdit;
        public UserControls.Books books;
    }
}