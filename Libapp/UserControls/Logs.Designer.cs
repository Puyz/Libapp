
namespace Libapp.UserControls
{
    partial class Logs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logs));
            this.filterPanel = new DevExpress.XtraEditors.SidePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showLogButton = new DevExpress.XtraEditors.SimpleButton();
            this.cBoxLogs = new DevExpress.XtraEditors.ComboBoxEdit();
            this.deleteLogButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterText = new DevExpress.XtraEditors.TextEdit();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.filterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBoxLogs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.AllowResize = false;
            this.filterPanel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.filterPanel.Appearance.Options.UseBackColor = true;
            this.filterPanel.Controls.Add(this.panel1);
            this.filterPanel.Controls.Add(this.saveButton);
            this.filterPanel.Controls.Add(this.refreshButton);
            this.filterPanel.Controls.Add(this.filterButton);
            this.filterPanel.Controls.Add(this.filterText);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(996, 44);
            this.filterPanel.TabIndex = 7;
            this.filterPanel.Text = "sidePanel2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showLogButton);
            this.panel1.Controls.Add(this.cBoxLogs);
            this.panel1.Controls.Add(this.deleteLogButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(111, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 43);
            this.panel1.TabIndex = 8;
            // 
            // showLogButton
            // 
            this.showLogButton.AllowFocus = false;
            this.showLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showLogButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.showLogButton.Appearance.FontSizeDelta = 1;
            this.showLogButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.showLogButton.Appearance.Options.UseBackColor = true;
            this.showLogButton.Appearance.Options.UseFont = true;
            this.showLogButton.Appearance.Options.UseForeColor = true;
            this.showLogButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("showLogButton.ImageOptions.Image")));
            this.showLogButton.Location = new System.Drawing.Point(192, 1);
            this.showLogButton.Name = "showLogButton";
            this.showLogButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.showLogButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.showLogButton.Size = new System.Drawing.Size(53, 43);
            this.showLogButton.TabIndex = 19;
            this.showLogButton.Click += new System.EventHandler(this.showLogButton_Click);
            // 
            // cBoxLogs
            // 
            this.cBoxLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxLogs.Location = new System.Drawing.Point(33, 12);
            this.cBoxLogs.Name = "cBoxLogs";
            this.cBoxLogs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cBoxLogs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cBoxLogs.Size = new System.Drawing.Size(153, 20);
            this.cBoxLogs.TabIndex = 18;
            // 
            // deleteLogButton
            // 
            this.deleteLogButton.AllowFocus = false;
            this.deleteLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteLogButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.deleteLogButton.Appearance.FontSizeDelta = 1;
            this.deleteLogButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.deleteLogButton.Appearance.Options.UseBackColor = true;
            this.deleteLogButton.Appearance.Options.UseFont = true;
            this.deleteLogButton.Appearance.Options.UseForeColor = true;
            this.deleteLogButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteLogButton.ImageOptions.Image")));
            this.deleteLogButton.Location = new System.Drawing.Point(245, 0);
            this.deleteLogButton.Name = "deleteLogButton";
            this.deleteLogButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.deleteLogButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.deleteLogButton.Size = new System.Drawing.Size(53, 43);
            this.deleteLogButton.TabIndex = 20;
            this.deleteLogButton.Visible = false;
            this.deleteLogButton.Click += new System.EventHandler(this.deleteLogButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AllowFocus = false;
            this.saveButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.saveButton.Appearance.FontSizeDelta = 1;
            this.saveButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.saveButton.Appearance.Options.UseBackColor = true;
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.Appearance.Options.UseForeColor = true;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.Location = new System.Drawing.Point(58, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.saveButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.saveButton.Size = new System.Drawing.Size(53, 43);
            this.saveButton.TabIndex = 3;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.filterButton.Location = new System.Drawing.Point(968, 0);
            this.filterButton.Name = "filterButton";
            this.filterButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.filterButton.Size = new System.Drawing.Size(28, 43);
            this.filterButton.TabIndex = 1;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterText
            // 
            this.filterText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filterText.Location = new System.Drawing.Point(839, 12);
            this.filterText.Name = "filterText";
            this.filterText.Properties.NullValuePrompt = "Ara";
            this.filterText.Size = new System.Drawing.Size(123, 20);
            this.filterText.TabIndex = 0;
            this.filterText.TextChanged += new System.EventHandler(this.filterText_TextChanged);
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
            this.gridControl.Size = new System.Drawing.Size(996, 692);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.filterPanel);
            this.Name = "Logs";
            this.Size = new System.Drawing.Size(996, 736);
            this.Load += new System.EventHandler(this.Logs_Load);
            this.filterPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cBoxLogs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SidePanel filterPanel;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraEditors.SimpleButton filterButton;
        private DevExpress.XtraEditors.TextEdit filterText;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton showLogButton;
        private DevExpress.XtraEditors.ComboBoxEdit cBoxLogs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton deleteLogButton;
    }
}
