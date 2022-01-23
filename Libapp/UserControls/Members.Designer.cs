
namespace Libapp.UserControls
{
    partial class Members
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filterPanel = new DevExpress.XtraEditors.SidePanel();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterText = new DevExpress.XtraEditors.TextEdit();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.dateOfRegistration = new System.Windows.Forms.Label();
            this.labelDateOfRegistration = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.imageMember = new System.Windows.Forms.PictureBox();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.identity = new System.Windows.Forms.Label();
            this.labelIdentity = new System.Windows.Forms.Label();
            this.memberName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageMember)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White;
            this.gridControl.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridControl.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.End;
            this.gridControl.Location = new System.Drawing.Point(0, 44);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(779, 692);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.ActiveFilterEnabled = false;
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowFilter = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsDetail.EnableMasterViewMode = false;
            this.gridView.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView.OptionsNavigation.AutoMoveRowFocus = false;
            this.gridView.OptionsPrint.PrintVertLines = false;
            this.gridView.OptionsPrint.UsePrintStyles = false;
            this.gridView.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.Click += new System.EventHandler(this.gridView_Click);
            // 
            // filterPanel
            // 
            this.filterPanel.AllowResize = false;
            this.filterPanel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.filterPanel.Appearance.Options.UseBackColor = true;
            this.filterPanel.Controls.Add(this.refreshButton);
            this.filterPanel.Controls.Add(this.filterButton);
            this.filterPanel.Controls.Add(this.filterText);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(779, 44);
            this.filterPanel.TabIndex = 5;
            this.filterPanel.Text = "sidePanel2";
            // 
            // refreshButton
            // 
            this.refreshButton.AllowFocus = false;
            this.refreshButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.refreshButton.Appearance.FontSizeDelta = 1;
            this.refreshButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Appearance.Options.UseBackColor = true;
            this.refreshButton.Appearance.Options.UseFont = true;
            this.refreshButton.Appearance.Options.UseForeColor = true;
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.ImageOptions.Image")));
            this.refreshButton.Location = new System.Drawing.Point(0, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.refreshButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.refreshButton.Size = new System.Drawing.Size(58, 43);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.AllowFocus = false;
            this.filterButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.filterButton.Appearance.FontSizeDelta = 1;
            this.filterButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.filterButton.Appearance.Options.UseBackColor = true;
            this.filterButton.Appearance.Options.UseFont = true;
            this.filterButton.Appearance.Options.UseForeColor = true;
            this.filterButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("filterButton.ImageOptions.Image")));
            this.filterButton.Location = new System.Drawing.Point(751, 0);
            this.filterButton.Name = "filterButton";
            this.filterButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.filterButton.Size = new System.Drawing.Size(28, 43);
            this.filterButton.TabIndex = 1;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterText
            // 
            this.filterText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filterText.Location = new System.Drawing.Point(622, 12);
            this.filterText.Name = "filterText";
            this.filterText.Properties.NullValuePrompt = "Ara";
            this.filterText.Size = new System.Drawing.Size(123, 20);
            this.filterText.TabIndex = 0;
            this.filterText.TextChanged += new System.EventHandler(this.filterText_TextChanged);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.dateOfRegistration);
            this.sidePanel1.Controls.Add(this.labelDateOfRegistration);
            this.sidePanel1.Controls.Add(this.phone);
            this.sidePanel1.Controls.Add(this.labelPhone);
            this.sidePanel1.Controls.Add(this.mail);
            this.sidePanel1.Controls.Add(this.labelMail);
            this.sidePanel1.Controls.Add(this.imageMember);
            this.sidePanel1.Controls.Add(this.dateOfBirth);
            this.sidePanel1.Controls.Add(this.labelDateOfBirth);
            this.sidePanel1.Controls.Add(this.gender);
            this.sidePanel1.Controls.Add(this.labelGender);
            this.sidePanel1.Controls.Add(this.identity);
            this.sidePanel1.Controls.Add(this.labelIdentity);
            this.sidePanel1.Controls.Add(this.memberName);
            this.sidePanel1.Controls.Add(this.labelName);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(779, 0);
            this.sidePanel1.MaximumSize = new System.Drawing.Size(300, 0);
            this.sidePanel1.MinimumSize = new System.Drawing.Size(217, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(217, 736);
            this.sidePanel1.TabIndex = 3;
            this.sidePanel1.Text = "sidePanel1";
            this.sidePanel1.Resize += new System.EventHandler(this.sidePanel1_Resize);
            // 
            // dateOfRegistration
            // 
            this.dateOfRegistration.AutoEllipsis = true;
            this.dateOfRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateOfRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateOfRegistration.Location = new System.Drawing.Point(78, 382);
            this.dateOfRegistration.Name = "dateOfRegistration";
            this.dateOfRegistration.Size = new System.Drawing.Size(136, 13);
            this.dateOfRegistration.TabIndex = 21;
            this.dateOfRegistration.Text = "Status";
            // 
            // labelDateOfRegistration
            // 
            this.labelDateOfRegistration.AutoSize = true;
            this.labelDateOfRegistration.ForeColor = System.Drawing.Color.DimGray;
            this.labelDateOfRegistration.Location = new System.Drawing.Point(7, 382);
            this.labelDateOfRegistration.Name = "labelDateOfRegistration";
            this.labelDateOfRegistration.Size = new System.Drawing.Size(58, 13);
            this.labelDateOfRegistration.TabIndex = 20;
            this.labelDateOfRegistration.Text = "Kayıt tarihi:";
            // 
            // phone
            // 
            this.phone.AutoEllipsis = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phone.Location = new System.Drawing.Point(78, 344);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(136, 13);
            this.phone.TabIndex = 19;
            this.phone.Text = "Status";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.ForeColor = System.Drawing.Color.DimGray;
            this.labelPhone.Location = new System.Drawing.Point(7, 344);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(46, 13);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "Telefon:";
            // 
            // mail
            // 
            this.mail.AutoEllipsis = true;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mail.Location = new System.Drawing.Point(78, 306);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(136, 13);
            this.mail.TabIndex = 17;
            this.mail.Text = "Status";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.ForeColor = System.Drawing.Color.DimGray;
            this.labelMail.Location = new System.Drawing.Point(7, 306);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(29, 13);
            this.labelMail.TabIndex = 16;
            this.labelMail.Text = "Mail:";
            // 
            // imageMember
            // 
            this.imageMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageMember.ErrorImage = global::Libapp.Properties.Resources.defaultBook;
            this.imageMember.Image = global::Libapp.Properties.Resources.female;
            this.imageMember.ImageLocation = "";
            this.imageMember.Location = new System.Drawing.Point(1, 0);
            this.imageMember.Name = "imageMember";
            this.imageMember.Size = new System.Drawing.Size(216, 132);
            this.imageMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageMember.TabIndex = 15;
            this.imageMember.TabStop = false;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoEllipsis = true;
            this.dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateOfBirth.Location = new System.Drawing.Point(78, 268);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(151, 13);
            this.dateOfBirth.TabIndex = 8;
            this.dateOfBirth.Text = "Status";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.ForeColor = System.Drawing.Color.DimGray;
            this.labelDateOfBirth.Location = new System.Drawing.Point(7, 268);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.labelDateOfBirth.TabIndex = 7;
            this.labelDateOfBirth.Text = "Doğum tarihi:";
            // 
            // gender
            // 
            this.gender.AutoEllipsis = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gender.Location = new System.Drawing.Point(78, 230);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(136, 13);
            this.gender.TabIndex = 6;
            this.gender.Text = "Novel";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.ForeColor = System.Drawing.Color.DimGray;
            this.labelGender.Location = new System.Drawing.Point(7, 230);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(46, 13);
            this.labelGender.TabIndex = 5;
            this.labelGender.Text = "Cinsiyet:";
            // 
            // identity
            // 
            this.identity.AutoEllipsis = true;
            this.identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.identity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.identity.Location = new System.Drawing.Point(78, 192);
            this.identity.Name = "identity";
            this.identity.Size = new System.Drawing.Size(136, 13);
            this.identity.TabIndex = 4;
            this.identity.Text = "Author";
            // 
            // labelIdentity
            // 
            this.labelIdentity.AutoSize = true;
            this.labelIdentity.ForeColor = System.Drawing.Color.DimGray;
            this.labelIdentity.Location = new System.Drawing.Point(7, 192);
            this.labelIdentity.Name = "labelIdentity";
            this.labelIdentity.Size = new System.Drawing.Size(52, 13);
            this.labelIdentity.TabIndex = 3;
            this.labelIdentity.Text = "Kimlik no:";
            // 
            // memberName
            // 
            this.memberName.AutoEllipsis = true;
            this.memberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memberName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memberName.Location = new System.Drawing.Point(78, 154);
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(136, 13);
            this.memberName.TabIndex = 2;
            this.memberName.Text = "Book";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.DimGray;
            this.labelName.Location = new System.Drawing.Point(7, 154);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Ad soyad:";
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.sidePanel1);
            this.Name = "Members";
            this.Size = new System.Drawing.Size(996, 736);
            this.Load += new System.EventHandler(this.Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SidePanel filterPanel;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraEditors.SimpleButton filterButton;
        private DevExpress.XtraEditors.TextEdit filterText;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.PictureBox imageMember;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label identity;
        private System.Windows.Forms.Label labelIdentity;
        private System.Windows.Forms.Label memberName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label dateOfRegistration;
        private System.Windows.Forms.Label labelDateOfRegistration;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label labelMail;
    }
}
