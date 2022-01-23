using Libapp.UserControls.AddOrEditPages;
namespace Libapp.UserControls
{
    partial class AddOrEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEdit));
            this.sidePanel = new DevExpress.XtraEditors.SidePanel();
            this.shelfsButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.membersButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.booksButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listelerLabel = new System.Windows.Forms.Label();
            this.aoeBooks = new Libapp.UserControls.AddOrEditPages.AOEBooks();
            this.aoeShelfs = new Libapp.UserControls.AddOrEditPages.AOEShelfs();
            this.aoeMembers = new Libapp.UserControls.AddOrEditPages.AOEMembers();
            this.edKitaplar1 = new Libapp.UserControls.AddOrEditPages.AOEBooks();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AllowResize = false;
            this.sidePanel.Controls.Add(this.shelfsButton);
            this.sidePanel.Controls.Add(this.splitter3);
            this.sidePanel.Controls.Add(this.membersButton);
            this.sidePanel.Controls.Add(this.splitter2);
            this.sidePanel.Controls.Add(this.booksButton);
            this.sidePanel.Controls.Add(this.splitter1);
            this.sidePanel.Controls.Add(this.listelerLabel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(185, 736);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.Text = "sidePanel1";
            // 
            // shelfsButton
            // 
            this.shelfsButton.AllowFocus = false;
            this.shelfsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.shelfsButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("shelfsButton.ImageOptions.SvgImage")));
            this.shelfsButton.Location = new System.Drawing.Point(0, 202);
            this.shelfsButton.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.shelfsButton.Name = "shelfsButton";
            this.shelfsButton.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.shelfsButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.shelfsButton.Size = new System.Drawing.Size(184, 35);
            this.shelfsButton.TabIndex = 11;
            this.shelfsButton.Text = "Raflar";
            this.shelfsButton.Click += new System.EventHandler(this.shelfsButton_Click);
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(0, 177);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(184, 25);
            this.splitter3.TabIndex = 12;
            this.splitter3.TabStop = false;
            // 
            // membersButton
            // 
            this.membersButton.AllowFocus = false;
            this.membersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.membersButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("membersButton.ImageOptions.SvgImage")));
            this.membersButton.Location = new System.Drawing.Point(0, 142);
            this.membersButton.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.membersButton.Name = "membersButton";
            this.membersButton.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.membersButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.membersButton.Size = new System.Drawing.Size(184, 35);
            this.membersButton.TabIndex = 8;
            this.membersButton.Text = "Üyeler";
            this.membersButton.Click += new System.EventHandler(this.membersButton_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(0, 117);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(184, 25);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // booksButton
            // 
            this.booksButton.AllowFocus = false;
            this.booksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.booksButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("booksButton.ImageOptions.Image")));
            this.booksButton.Location = new System.Drawing.Point(0, 82);
            this.booksButton.Name = "booksButton";
            this.booksButton.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.booksButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.booksButton.Size = new System.Drawing.Size(184, 35);
            this.booksButton.TabIndex = 6;
            this.booksButton.Text = "Kitaplar";
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 57);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(184, 25);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // listelerLabel
            // 
            this.listelerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listelerLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listelerLabel.ForeColor = System.Drawing.Color.Gray;
            this.listelerLabel.Location = new System.Drawing.Point(0, 0);
            this.listelerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.listelerLabel.Name = "listelerLabel";
            this.listelerLabel.Padding = new System.Windows.Forms.Padding(10, 40, 0, 0);
            this.listelerLabel.Size = new System.Drawing.Size(184, 57);
            this.listelerLabel.TabIndex = 7;
            this.listelerLabel.Text = "İŞLEMLER";
            // 
            // aoeBooks
            // 
            this.aoeBooks.BackColor = System.Drawing.Color.White;
            this.aoeBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aoeBooks.Location = new System.Drawing.Point(185, 0);
            this.aoeBooks.Name = "aoeBooks";
            this.aoeBooks.Size = new System.Drawing.Size(811, 736);
            this.aoeBooks.TabIndex = 1;
            // 
            // aoeShelfs
            // 
            this.aoeShelfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aoeShelfs.Location = new System.Drawing.Point(185, 0);
            this.aoeShelfs.Name = "aoeShelfs";
            this.aoeShelfs.Size = new System.Drawing.Size(811, 736);
            this.aoeShelfs.TabIndex = 3;
            this.aoeShelfs.Visible = false;
            // 
            // aoeMembers
            // 
            this.aoeMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aoeMembers.Location = new System.Drawing.Point(185, 0);
            this.aoeMembers.Name = "aoeMembers";
            this.aoeMembers.Size = new System.Drawing.Size(811, 736);
            this.aoeMembers.TabIndex = 2;
            this.aoeMembers.Visible = false;
            // 
            // edKitaplar1
            // 
            this.edKitaplar1.BackColor = System.Drawing.Color.White;
            this.edKitaplar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edKitaplar1.Location = new System.Drawing.Point(185, 0);
            this.edKitaplar1.Name = "edKitaplar1";
            this.edKitaplar1.Size = new System.Drawing.Size(811, 736);
            this.edKitaplar1.TabIndex = 1;
            // 
            // AddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aoeBooks);
            this.Controls.Add(this.aoeShelfs);
            this.Controls.Add(this.aoeMembers);
            this.Controls.Add(this.sidePanel);
            this.Name = "AddOrEdit";
            this.Size = new System.Drawing.Size(996, 736);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel;
        private DevExpress.XtraEditors.SimpleButton shelfsButton;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private DevExpress.XtraEditors.SimpleButton booksButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label listelerLabel;
        private AOEBooks edKitaplar1;
        public AOEBooks aoeBooks;
        public AOEMembers aoeMembers;
        public AOEShelfs aoeShelfs;
        public DevExpress.XtraEditors.SimpleButton membersButton;
    }
}
