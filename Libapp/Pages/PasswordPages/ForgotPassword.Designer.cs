
namespace Libapp.Pages.PasswordPages
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.panelUsername = new System.Windows.Forms.Panel();
            this.textEmail = new DevExpress.XtraEditors.TextEdit();
            this.StepProgress = new DevExpress.XtraEditors.StepProgressBar();
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem2 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem3 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.sendCodeButton = new Libapp.UI.SmoothButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.panelUsername.Location = new System.Drawing.Point(61, 77);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(222, 1);
            this.panelUsername.TabIndex = 10;
            // 
            // textEmail
            // 
            this.textEmail.EditValue = "";
            this.textEmail.Location = new System.Drawing.Point(61, 53);
            this.textEmail.Name = "textEmail";
            this.textEmail.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEmail.Properties.Appearance.Options.UseFont = true;
            this.textEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textEmail.Properties.NullValuePrompt = "Email";
            this.textEmail.Size = new System.Drawing.Size(222, 22);
            this.textEmail.TabIndex = 8;
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
            this.StepProgress.Location = new System.Drawing.Point(0, 181);
            this.StepProgress.Name = "StepProgress";
            this.StepProgress.SelectedItemIndex = 0;
            this.StepProgress.Size = new System.Drawing.Size(342, 59);
            this.StepProgress.TabIndex = 22;
            // 
            // stepProgressBarItem1
            // 
            this.stepProgressBarItem1.Name = "stepProgressBarItem1";
            this.stepProgressBarItem1.State = DevExpress.XtraEditors.StepProgressBarItemState.Active;
            // 
            // stepProgressBarItem2
            // 
            this.stepProgressBarItem2.Name = "stepProgressBarItem2";
            // 
            // stepProgressBarItem3
            // 
            this.stepProgressBarItem3.Name = "stepProgressBarItem3";
            // 
            // sendCodeButton
            // 
            this.sendCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.sendCodeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.sendCodeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sendCodeButton.BorderRadius = 17;
            this.sendCodeButton.BorderSize = 0;
            this.sendCodeButton.FlatAppearance.BorderSize = 0;
            this.sendCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendCodeButton.ForeColor = System.Drawing.Color.White;
            this.sendCodeButton.Location = new System.Drawing.Point(76, 110);
            this.sendCodeButton.Name = "sendCodeButton";
            this.sendCodeButton.Size = new System.Drawing.Size(192, 36);
            this.sendCodeButton.TabIndex = 23;
            this.sendCodeButton.Text = "Doğrulama kodu gönder";
            this.sendCodeButton.TextColor = System.Drawing.Color.White;
            this.sendCodeButton.UseVisualStyleBackColor = false;
            this.sendCodeButton.Click += new System.EventHandler(this.sendCodeButton_Click);
            // 
            // ForgotPassword
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 240);
            this.Controls.Add(this.sendCodeButton);
            this.Controls.Add(this.StepProgress);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.textEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(344, 272);
            this.MinimumSize = new System.Drawing.Size(344, 272);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsername;
        private DevExpress.XtraEditors.TextEdit textEmail;
        private DevExpress.XtraEditors.StepProgressBar StepProgress;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem2;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem3;
        private UI.SmoothButton sendCodeButton;
    }
}