
namespace Libapp.Pages.LogPages
{
    partial class ShowLogs
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
            this.labelLogs = new System.Windows.Forms.Label();
            this.panelLogs = new System.Windows.Forms.Panel();
            this.panelLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogs
            // 
            this.labelLogs.AutoSize = true;
            this.labelLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLogs.Location = new System.Drawing.Point(0, 0);
            this.labelLogs.Name = "labelLogs";
            this.labelLogs.Size = new System.Drawing.Size(39, 13);
            this.labelLogs.TabIndex = 0;
            this.labelLogs.Text = "geçmiş";
            // 
            // panelLogs
            // 
            this.panelLogs.AutoScroll = true;
            this.panelLogs.Controls.Add(this.labelLogs);
            this.panelLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogs.Location = new System.Drawing.Point(0, 0);
            this.panelLogs.Name = "panelLogs";
            this.panelLogs.Size = new System.Drawing.Size(866, 504);
            this.panelLogs.TabIndex = 1;
            // 
            // ShowLogs
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(866, 504);
            this.Controls.Add(this.panelLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.Name = "ShowLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geçmiş";
            this.panelLogs.ResumeLayout(false);
            this.panelLogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelLogs;
        private System.Windows.Forms.Panel panelLogs;
    }
}