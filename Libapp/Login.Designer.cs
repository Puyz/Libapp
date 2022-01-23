
namespace Libapp
{
    partial class Login
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textEmail = new DevExpress.XtraEditors.TextEdit();
            this.textSifre = new DevExpress.XtraEditors.TextEdit();
            this.forgotPassword = new System.Windows.Forms.LinkLabel();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageLogin = new System.Windows.Forms.PictureBox();
            this.girisButton = new Libapp.UI.SmoothButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.EditValue = "";
            this.textEmail.Location = new System.Drawing.Point(89, 164);
            this.textEmail.Name = "textEmail";
            this.textEmail.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEmail.Properties.Appearance.Options.UseFont = true;
            this.textEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textEmail.Properties.NullValuePrompt = "Email";
            this.textEmail.Size = new System.Drawing.Size(222, 22);
            this.textEmail.TabIndex = 1;
            // 
            // textSifre
            // 
            this.textSifre.EditValue = "";
            this.textSifre.Location = new System.Drawing.Point(89, 223);
            this.textSifre.Name = "textSifre";
            this.textSifre.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSifre.Properties.Appearance.Options.UseFont = true;
            this.textSifre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textSifre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textSifre.Properties.NullValuePrompt = "Şifre";
            this.textSifre.Properties.UseSystemPasswordChar = true;
            this.textSifre.Size = new System.Drawing.Size(222, 22);
            this.textSifre.TabIndex = 4;
            // 
            // forgotPassword
            // 
            this.forgotPassword.ActiveLinkColor = System.Drawing.Color.Black;
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.forgotPassword.Location = new System.Drawing.Point(229, 255);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(82, 13);
            this.forgotPassword.TabIndex = 6;
            this.forgotPassword.TabStop = true;
            this.forgotPassword.Text = "Şifremi unuttum";
            this.forgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPassword_LinkClicked);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.panelUsername.Location = new System.Drawing.Point(89, 188);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(222, 1);
            this.panelUsername.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.panel1.Location = new System.Drawing.Point(89, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 1);
            this.panel1.TabIndex = 8;
            // 
            // imageLogin
            // 
            this.imageLogin.BackColor = System.Drawing.Color.Transparent;
            this.imageLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageLogin.BackgroundImage")));
            this.imageLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageLogin.Image = global::Libapp.Properties.Resources.logo;
            this.imageLogin.Location = new System.Drawing.Point(148, 34);
            this.imageLogin.Name = "imageLogin";
            this.imageLogin.Size = new System.Drawing.Size(104, 83);
            this.imageLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLogin.TabIndex = 0;
            this.imageLogin.TabStop = false;
            // 
            // girisButton
            // 
            this.girisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.girisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.girisButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.girisButton.BorderColor = System.Drawing.Color.BlueViolet;
            this.girisButton.BorderRadius = 17;
            this.girisButton.BorderSize = 0;
            this.girisButton.FlatAppearance.BorderSize = 0;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.ForeColor = System.Drawing.Color.White;
            this.girisButton.Location = new System.Drawing.Point(130, 309);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(140, 34);
            this.girisButton.TabIndex = 9;
            this.girisButton.Text = "Giriş yap";
            this.girisButton.TextColor = System.Drawing.Color.White;
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 409);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.imageLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 441);
            this.MinimumSize = new System.Drawing.Size(400, 441);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş yap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageLogin;
        private DevExpress.XtraEditors.TextEdit textEmail;
        private DevExpress.XtraEditors.TextEdit textSifre;
        private System.Windows.Forms.LinkLabel forgotPassword;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panel1;
        private UI.SmoothButton girisButton;
    }
}

