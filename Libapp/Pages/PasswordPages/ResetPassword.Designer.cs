
namespace Libapp.Pages.PasswordPages
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSifre = new DevExpress.XtraEditors.TextEdit();
            this.StepProgress = new DevExpress.XtraEditors.StepProgressBar();
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem2 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem3 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.resetPasswordButton = new Libapp.UI.SmoothButton();
            ((System.ComponentModel.ISupportInitialize)(this.textSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.panel1.Location = new System.Drawing.Point(54, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 1);
            this.panel1.TabIndex = 11;
            // 
            // textSifre
            // 
            this.textSifre.EditValue = "";
            this.textSifre.Location = new System.Drawing.Point(54, 70);
            this.textSifre.Name = "textSifre";
            this.textSifre.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSifre.Properties.Appearance.Options.UseFont = true;
            this.textSifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textSifre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textSifre.Properties.NullValuePrompt = "Şifre";
            this.textSifre.Properties.UseSystemPasswordChar = true;
            this.textSifre.Size = new System.Drawing.Size(222, 22);
            this.textSifre.TabIndex = 10;
            // 
            // StepProgress
            // 
            this.StepProgress.Appearance.BackColor = System.Drawing.Color.White;
            this.StepProgress.Appearance.Options.UseBackColor = true;
            this.StepProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StepProgress.ItemOptions.Indicator.ActiveStateImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("StepProgress.ItemOptions.Indicator.ActiveStateImageOptions.Image")));
            this.StepProgress.Items.Add(this.stepProgressBarItem1);
            this.StepProgress.Items.Add(this.stepProgressBarItem2);
            this.StepProgress.Items.Add(this.stepProgressBarItem3);
            this.StepProgress.Location = new System.Drawing.Point(0, 204);
            this.StepProgress.Name = "StepProgress";
            this.StepProgress.SelectedItemIndex = 2;
            this.StepProgress.Size = new System.Drawing.Size(328, 59);
            this.StepProgress.TabIndex = 23;
            // 
            // stepProgressBarItem1
            // 
            this.stepProgressBarItem1.Name = "stepProgressBarItem1";
            this.stepProgressBarItem1.State = DevExpress.XtraEditors.StepProgressBarItemState.Active;
            // 
            // stepProgressBarItem2
            // 
            this.stepProgressBarItem2.Name = "stepProgressBarItem2";
            this.stepProgressBarItem2.State = DevExpress.XtraEditors.StepProgressBarItemState.Active;
            // 
            // stepProgressBarItem3
            // 
            this.stepProgressBarItem3.Name = "stepProgressBarItem3";
            this.stepProgressBarItem3.State = DevExpress.XtraEditors.StepProgressBarItemState.Active;
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.resetPasswordButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.resetPasswordButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.resetPasswordButton.BorderRadius = 17;
            this.resetPasswordButton.BorderSize = 0;
            this.resetPasswordButton.FlatAppearance.BorderSize = 0;
            this.resetPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPasswordButton.ForeColor = System.Drawing.Color.White;
            this.resetPasswordButton.Location = new System.Drawing.Point(83, 136);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(164, 36);
            this.resetPasswordButton.TabIndex = 24;
            this.resetPasswordButton.Text = "Şifreyi yenile";
            this.resetPasswordButton.TextColor = System.Drawing.Color.White;
            this.resetPasswordButton.UseVisualStyleBackColor = false;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // ResetPassword
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 263);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.StepProgress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textSifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre yenileme";
            ((System.ComponentModel.ISupportInitialize)(this.textSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit textSifre;
        private DevExpress.XtraEditors.StepProgressBar StepProgress;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem2;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem3;
        private UI.SmoothButton resetPasswordButton;
    }
}