
namespace Libapp.UserControls.AddOrEditPages
{
    partial class AOEShelfs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AOEShelfs));
            this.filterPanel = new DevExpress.XtraEditors.SidePanel();
            this.filterText = new DevExpress.XtraEditors.TextEdit();
            this.bwShelfs = new System.ComponentModel.BackgroundWorker();
            this.shelfsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bwFilterShelfs = new System.ComponentModel.BackgroundWorker();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.AllowResize = false;
            this.filterPanel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.filterPanel.Appearance.Options.UseBackColor = true;
            this.filterPanel.Controls.Add(this.addButton);
            this.filterPanel.Controls.Add(this.refreshButton);
            this.filterPanel.Controls.Add(this.filterButton);
            this.filterPanel.Controls.Add(this.filterText);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(811, 44);
            this.filterPanel.TabIndex = 7;
            this.filterPanel.Text = "sidePanel2";
            // 
            // filterText
            // 
            this.filterText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filterText.Location = new System.Drawing.Point(654, 12);
            this.filterText.Name = "filterText";
            this.filterText.Properties.NullValuePrompt = "Ara";
            this.filterText.Size = new System.Drawing.Size(123, 20);
            this.filterText.TabIndex = 0;
            this.filterText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterText_KeyDown);
            // 
            // bwShelfs
            // 
            this.bwShelfs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwShelfs_DoWork);
            // 
            // shelfsPanel
            // 
            this.shelfsPanel.AutoScroll = true;
            this.shelfsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shelfsPanel.Location = new System.Drawing.Point(0, 44);
            this.shelfsPanel.Name = "shelfsPanel";
            this.shelfsPanel.Size = new System.Drawing.Size(811, 692);
            this.shelfsPanel.TabIndex = 9;
            // 
            // bwFilterShelfs
            // 
            this.bwFilterShelfs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwFilterShelfs_DoWork);
            // 
            // addButton
            // 
            this.addButton.AllowFocus = false;
            this.addButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.addButton.Appearance.FontSizeDelta = 1;
            this.addButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.addButton.Appearance.Options.UseBackColor = true;
            this.addButton.Appearance.Options.UseFont = true;
            this.addButton.Appearance.Options.UseForeColor = true;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addButton.ImageOptions.Image")));
            this.addButton.Location = new System.Drawing.Point(52, 0);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.addButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.addButton.Size = new System.Drawing.Size(51, 43);
            this.addButton.TabIndex = 3;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.ImageOptions.Image")));
            this.refreshButton.Location = new System.Drawing.Point(0, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.refreshButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.refreshButton.Size = new System.Drawing.Size(52, 43);
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
            this.filterButton.Location = new System.Drawing.Point(783, 0);
            this.filterButton.Name = "filterButton";
            this.filterButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.filterButton.Size = new System.Drawing.Size(28, 43);
            this.filterButton.TabIndex = 1;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // AOEShelfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shelfsPanel);
            this.Controls.Add(this.filterPanel);
            this.Name = "AOEShelfs";
            this.Size = new System.Drawing.Size(811, 736);
            this.Load += new System.EventHandler(this.AOEShelfs_Load);
            this.filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel filterPanel;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraEditors.SimpleButton filterButton;
        private DevExpress.XtraEditors.TextEdit filterText;
        private System.ComponentModel.BackgroundWorker bwShelfs;
        private System.Windows.Forms.FlowLayoutPanel shelfsPanel;
        private System.ComponentModel.BackgroundWorker bwFilterShelfs;
    }
}
