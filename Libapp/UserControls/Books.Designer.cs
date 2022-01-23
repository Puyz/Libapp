
namespace Libapp.UserControls
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.panelButtonStatus = new System.Windows.Forms.Panel();
            this.buttonStatus = new Libapp.UI.SmoothButton();
            this.imageBook = new System.Windows.Forms.PictureBox();
            this.panelDelivery = new System.Windows.Forms.Panel();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.deliveryUser = new System.Windows.Forms.LinkLabel();
            this.labelDeliveryUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.shelfName = new System.Windows.Forms.Label();
            this.labelShelfName = new System.Windows.Forms.Label();
            this.authorName = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filterPanel = new DevExpress.XtraEditors.SidePanel();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterText = new DevExpress.XtraEditors.TextEdit();
            this.sidePanel1.SuspendLayout();
            this.panelButtonStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).BeginInit();
            this.panelDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.panelButtonStatus);
            this.sidePanel1.Controls.Add(this.imageBook);
            this.sidePanel1.Controls.Add(this.panelDelivery);
            this.sidePanel1.Controls.Add(this.status);
            this.sidePanel1.Controls.Add(this.labelStatus);
            this.sidePanel1.Controls.Add(this.shelfName);
            this.sidePanel1.Controls.Add(this.labelShelfName);
            this.sidePanel1.Controls.Add(this.authorName);
            this.sidePanel1.Controls.Add(this.labelAuthorName);
            this.sidePanel1.Controls.Add(this.bookName);
            this.sidePanel1.Controls.Add(this.labelBookName);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(779, 0);
            this.sidePanel1.MaximumSize = new System.Drawing.Size(300, 0);
            this.sidePanel1.MinimumSize = new System.Drawing.Size(217, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(217, 736);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            this.sidePanel1.Resize += new System.EventHandler(this.sidePanel1_Resize);
            // 
            // panelButtonStatus
            // 
            this.panelButtonStatus.Controls.Add(this.buttonStatus);
            this.panelButtonStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonStatus.Location = new System.Drawing.Point(1, 669);
            this.panelButtonStatus.Name = "panelButtonStatus";
            this.panelButtonStatus.Size = new System.Drawing.Size(216, 67);
            this.panelButtonStatus.TabIndex = 17;
            // 
            // buttonStatus
            // 
            this.buttonStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(85)))));
            this.buttonStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(85)))));
            this.buttonStatus.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonStatus.BorderRadius = 19;
            this.buttonStatus.BorderSize = 0;
            this.buttonStatus.FlatAppearance.BorderSize = 0;
            this.buttonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatus.ForeColor = System.Drawing.Color.White;
            this.buttonStatus.Location = new System.Drawing.Point(25, 14);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(169, 40);
            this.buttonStatus.TabIndex = 16;
            this.buttonStatus.Text = "Durum";
            this.buttonStatus.TextColor = System.Drawing.Color.White;
            this.buttonStatus.UseVisualStyleBackColor = false;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // imageBook
            // 
            this.imageBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageBook.ErrorImage = global::Libapp.Properties.Resources.defaultBook;
            this.imageBook.Image = global::Libapp.Properties.Resources.defaultBook;
            this.imageBook.ImageLocation = "";
            this.imageBook.Location = new System.Drawing.Point(1, 0);
            this.imageBook.Name = "imageBook";
            this.imageBook.Size = new System.Drawing.Size(216, 132);
            this.imageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBook.TabIndex = 15;
            this.imageBook.TabStop = false;
            // 
            // panelDelivery
            // 
            this.panelDelivery.Controls.Add(this.separatorControl1);
            this.panelDelivery.Controls.Add(this.deliveryUser);
            this.panelDelivery.Controls.Add(this.labelDeliveryUser);
            this.panelDelivery.Controls.Add(this.label3);
            this.panelDelivery.Controls.Add(this.date);
            this.panelDelivery.Controls.Add(this.labelDate);
            this.panelDelivery.Location = new System.Drawing.Point(6, 316);
            this.panelDelivery.Name = "panelDelivery";
            this.panelDelivery.Size = new System.Drawing.Size(208, 136);
            this.panelDelivery.TabIndex = 13;
            this.panelDelivery.Visible = false;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl1.Location = new System.Drawing.Point(0, 13);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(208, 23);
            this.separatorControl1.TabIndex = 9;
            // 
            // deliveryUser
            // 
            this.deliveryUser.ActiveLinkColor = System.Drawing.Color.Black;
            this.deliveryUser.AutoSize = true;
            this.deliveryUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deliveryUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deliveryUser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deliveryUser.Location = new System.Drawing.Point(39, 90);
            this.deliveryUser.Name = "deliveryUser";
            this.deliveryUser.Size = new System.Drawing.Size(63, 13);
            this.deliveryUser.TabIndex = 15;
            this.deliveryUser.TabStop = true;
            this.deliveryUser.Text = "Username";
            this.deliveryUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deliveryUser_LinkClicked);
            // 
            // labelDeliveryUser
            // 
            this.labelDeliveryUser.AutoSize = true;
            this.labelDeliveryUser.ForeColor = System.Drawing.Color.DimGray;
            this.labelDeliveryUser.Location = new System.Drawing.Point(2, 90);
            this.labelDeliveryUser.Name = "labelDeliveryUser";
            this.labelDeliveryUser.Size = new System.Drawing.Size(26, 13);
            this.labelDeliveryUser.TabIndex = 13;
            this.labelDeliveryUser.Text = "Kişi:";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Teslim bilgileri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.AutoEllipsis = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.date.Location = new System.Drawing.Point(39, 56);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(150, 13);
            this.date.TabIndex = 11;
            this.date.Text = "17.10.2021 04:24:45";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.ForeColor = System.Drawing.Color.DimGray;
            this.labelDate.Location = new System.Drawing.Point(2, 56);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(34, 13);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Tarih:";
            // 
            // status
            // 
            this.status.AutoEllipsis = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.status.Location = new System.Drawing.Point(57, 271);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(157, 13);
            this.status.TabIndex = 8;
            this.status.Text = "Status";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatus.Location = new System.Drawing.Point(7, 271);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 13);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Durum:";
            // 
            // shelfName
            // 
            this.shelfName.AutoEllipsis = true;
            this.shelfName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shelfName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shelfName.Location = new System.Drawing.Point(57, 232);
            this.shelfName.Name = "shelfName";
            this.shelfName.Size = new System.Drawing.Size(157, 13);
            this.shelfName.TabIndex = 6;
            this.shelfName.Text = "Novel";
            // 
            // labelShelfName
            // 
            this.labelShelfName.AutoSize = true;
            this.labelShelfName.ForeColor = System.Drawing.Color.DimGray;
            this.labelShelfName.Location = new System.Drawing.Point(7, 232);
            this.labelShelfName.Name = "labelShelfName";
            this.labelShelfName.Size = new System.Drawing.Size(44, 13);
            this.labelShelfName.TabIndex = 5;
            this.labelShelfName.Text = "Raf adı:";
            // 
            // authorName
            // 
            this.authorName.AutoEllipsis = true;
            this.authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorName.Location = new System.Drawing.Point(57, 193);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(157, 13);
            this.authorName.TabIndex = 4;
            this.authorName.Text = "Author";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.ForeColor = System.Drawing.Color.DimGray;
            this.labelAuthorName.Location = new System.Drawing.Point(7, 193);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(54, 13);
            this.labelAuthorName.TabIndex = 3;
            this.labelAuthorName.Text = "Yazar adı:";
            // 
            // bookName
            // 
            this.bookName.AutoEllipsis = true;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookName.Location = new System.Drawing.Point(57, 154);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(157, 13);
            this.bookName.TabIndex = 2;
            this.bookName.Text = "Book";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.ForeColor = System.Drawing.Color.DimGray;
            this.labelBookName.Location = new System.Drawing.Point(7, 154);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(51, 13);
            this.labelBookName.TabIndex = 1;
            this.labelBookName.Text = "Kitap adı:";
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
            this.gridControl.TabIndex = 1;
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
            this.gridView.Click += new System.EventHandler(this.gridView1_Click);
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
            this.filterPanel.TabIndex = 2;
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
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.sidePanel1);
            this.Name = "Books";
            this.Size = new System.Drawing.Size(996, 736);
            this.Load += new System.EventHandler(this.Books_Load);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.panelButtonStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).EndInit();
            this.panelDelivery.ResumeLayout(false);
            this.panelDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.Label shelfName;
        private System.Windows.Forms.Label labelShelfName;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panelDelivery;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDeliveryUser;
        private System.Windows.Forms.LinkLabel deliveryUser;
        private System.Windows.Forms.PictureBox imageBook;
        private DevExpress.XtraEditors.SidePanel filterPanel;
        private DevExpress.XtraEditors.SimpleButton filterButton;
        private DevExpress.XtraEditors.TextEdit filterText;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private UI.SmoothButton buttonStatus;
        private System.Windows.Forms.Panel panelButtonStatus;
    }
}
