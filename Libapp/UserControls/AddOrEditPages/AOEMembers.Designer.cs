
namespace Libapp.UserControls.AddOrEditPages
{
    partial class AOEMembers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AOEMembers));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filterPanel = new DevExpress.XtraEditors.SidePanel();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterText = new DevExpress.XtraEditors.TextEdit();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.ContextMenuStrip = this.contextMenu;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White;
            this.gridControl.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridControl.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.End;
            this.gridControl.Location = new System.Drawing.Point(0, 44);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(811, 692);
            this.gridControl.TabIndex = 5;
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
            this.filterPanel.TabIndex = 6;
            this.filterPanel.Text = "sidePanel2";
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
            // filterText
            // 
            this.filterText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filterText.Location = new System.Drawing.Point(654, 12);
            this.filterText.Name = "filterText";
            this.filterText.Properties.NullValuePrompt = "Ara";
            this.filterText.Size = new System.Drawing.Size(123, 20);
            this.filterText.TabIndex = 0;
            this.filterText.TextChanged += new System.EventHandler(this.filterText_TextChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(117, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = global::Libapp.Properties.Resources.edit;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.silToolStripMenuItem.Image = global::Libapp.Properties.Resources.remove;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // AOEMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.filterPanel);
            this.Name = "AOEMembers";
            this.Size = new System.Drawing.Size(811, 736);
            this.Load += new System.EventHandler(this.AOEMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SidePanel filterPanel;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraEditors.SimpleButton filterButton;
        private DevExpress.XtraEditors.TextEdit filterText;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}
