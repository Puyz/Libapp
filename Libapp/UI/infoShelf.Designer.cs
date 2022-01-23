
namespace Libapp.UI
{
    partial class infoShelf
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelValue = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new Libapp.UI.HalfCircularProgress();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(117, 48);
            // 
            // labelValue
            // 
            this.labelValue.ContextMenuStrip = this.contextMenu;
            this.labelValue.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelValue.Location = new System.Drawing.Point(25, 45);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(105, 23);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "4000/6000";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelValue.MouseEnter += new System.EventHandler(this.progressBar_MouseEnter);
            this.labelValue.MouseLeave += new System.EventHandler(this.progressBar_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.AutoEllipsis = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.ContextMenuStrip = this.contextMenu;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelName.Location = new System.Drawing.Point(0, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(155, 22);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Pazarlama Satış ve Reklam";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelName.MouseEnter += new System.EventHandler(this.progressBar_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.progressBar_MouseLeave);
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
            // progressBar
            // 
            this.progressBar.ContextMenuStrip = this.contextMenu;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(155, 84);
            this.progressBar.TabIndex = 0;
            this.progressBar.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressBar.Value = 25;
            this.progressBar.ValueColor = System.Drawing.Color.RoyalBlue;
            this.progressBar.MouseEnter += new System.EventHandler(this.progressBar_MouseEnter);
            this.progressBar.MouseLeave += new System.EventHandler(this.progressBar_MouseLeave);
            // 
            // infoShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelName);
            this.Name = "infoShelf";
            this.Size = new System.Drawing.Size(155, 106);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public HalfCircularProgress progressBar;
        public System.Windows.Forms.Label labelValue;
        public System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}
