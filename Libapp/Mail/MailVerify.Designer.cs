
namespace Libapp.Mail
{
    partial class MailVerify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailVerify));
            this.SendMailBW = new System.ComponentModel.BackgroundWorker();
            this.panelCode = new System.Windows.Forms.Panel();
            this.textCode = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.stepProgress = new DevExpress.XtraEditors.StepProgressBar();
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem2 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVerify = new Libapp.UI.SmoothButton();
            ((System.ComponentModel.ISupportInitialize)(this.textCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepProgress)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendMailBW
            // 
            this.SendMailBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SendMailBW_DoWork);
            // 
            // panelCode
            // 
            this.panelCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.panelCode.Location = new System.Drawing.Point(109, 173);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(180, 1);
            this.panelCode.TabIndex = 25;
            // 
            // textCode
            // 
            this.textCode.EditValue = "";
            this.textCode.Location = new System.Drawing.Point(109, 148);
            this.textCode.Name = "textCode";
            this.textCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textCode.Properties.Appearance.Options.UseBackColor = true;
            this.textCode.Properties.Appearance.Options.UseFont = true;
            this.textCode.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.textCode.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.textCode.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White;
            this.textCode.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.textCode.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
            this.textCode.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.textCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textCode.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("textCode.Properties.ContextImageOptions.Image")));
            this.textCode.Properties.Mask.EditMask = "f0";
            this.textCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textCode.Properties.Mask.SaveLiteral = false;
            this.textCode.Properties.NullValuePrompt = "Doğrulama kodu";
            this.textCode.Size = new System.Drawing.Size(180, 22);
            this.textCode.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mail Doğrulama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mailinize bir doğrulama kodu gönderdik";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Caption = "";
            this.progressPanel1.Description = "";
            this.progressPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressPanel1.Location = new System.Drawing.Point(0, 245);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.ShowCaption = false;
            this.progressPanel1.ShowDescription = false;
            this.progressPanel1.Size = new System.Drawing.Size(400, 73);
            this.progressPanel1.TabIndex = 28;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // stepProgress
            // 
            this.stepProgress.Appearance.BackColor = System.Drawing.Color.White;
            this.stepProgress.Appearance.Options.UseBackColor = true;
            this.stepProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stepProgress.ItemOptions.Indicator.ActiveStateImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stepProgress.ItemOptions.Indicator.ActiveStateImageOptions.Image")));
            this.stepProgress.Items.Add(this.stepProgressBarItem1);
            this.stepProgress.Items.Add(this.stepProgressBarItem2);
            this.stepProgress.Location = new System.Drawing.Point(0, 318);
            this.stepProgress.Name = "stepProgress";
            this.stepProgress.SelectedItemIndex = 1;
            this.stepProgress.Size = new System.Drawing.Size(400, 59);
            this.stepProgress.TabIndex = 29;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 104);
            this.panel1.TabIndex = 27;
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.buttonVerify.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.buttonVerify.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonVerify.BorderRadius = 17;
            this.buttonVerify.BorderSize = 0;
            this.buttonVerify.FlatAppearance.BorderSize = 0;
            this.buttonVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerify.ForeColor = System.Drawing.Color.White;
            this.buttonVerify.Location = new System.Drawing.Point(130, 206);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(140, 33);
            this.buttonVerify.TabIndex = 30;
            this.buttonVerify.Text = "Doğrula";
            this.buttonVerify.TextColor = System.Drawing.Color.White;
            this.buttonVerify.UseVisualStyleBackColor = false;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // MailVerify
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 377);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.panelCode);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.stepProgress);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.Name = "MailVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Doğrulama";
            ((System.ComponentModel.ISupportInitialize)(this.textCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepProgress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker SendMailBW;
        private System.Windows.Forms.Panel panelCode;
        private DevExpress.XtraEditors.TextEdit textCode;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        public DevExpress.XtraEditors.StepProgressBar stepProgress;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem2;
        private System.Windows.Forms.Panel panel1;
        private UI.SmoothButton buttonVerify;
    }
}