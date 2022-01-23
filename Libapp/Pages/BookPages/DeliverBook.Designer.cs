
namespace Libapp.Pages.BookPages
{
    partial class DeliverBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliverBook));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filterPanel = new DevExpress.XtraEditors.SidePanel();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterButton = new DevExpress.XtraEditors.SimpleButton();
            this.filterText = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White;
            this.gridControl.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridControl.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.End;
            this.gridControl.Location = new System.Drawing.Point(0, 38);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(676, 425);
            this.gridControl.TabIndex = 6;
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
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
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
            this.filterPanel.Size = new System.Drawing.Size(676, 38);
            this.filterPanel.TabIndex = 7;
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
            this.refreshButton.Size = new System.Drawing.Size(58, 37);
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
            this.filterButton.Location = new System.Drawing.Point(648, 0);
            this.filterButton.Name = "filterButton";
            this.filterButton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.filterButton.Size = new System.Drawing.Size(28, 37);
            this.filterButton.TabIndex = 1;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterText
            // 
            this.filterText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filterText.Location = new System.Drawing.Point(519, 9);
            this.filterText.Name = "filterText";
            this.filterText.Properties.NullValuePrompt = "Ara";
            this.filterText.Size = new System.Drawing.Size(123, 20);
            this.filterText.TabIndex = 0;
            this.filterText.TextChanged += new System.EventHandler(this.filterText_TextChanged);
            // 
            // DeliverBook
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 463);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.filterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.Name = "DeliverBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap teslim - Üye seçimi";
            this.Load += new System.EventHandler(this.DeliverBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SidePanel filterPanel;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraEditors.SimpleButton filterButton;
        private DevExpress.XtraEditors.TextEdit filterText;
    }
}