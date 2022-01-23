
namespace Libapp.Pages.MemberPages
{
    partial class AddMember
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
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.textIdentity = new DevExpress.XtraEditors.TextEdit();
            this.textGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEmail = new DevExpress.XtraEditors.TextEdit();
            this.dateOfBirth = new DevExpress.XtraEditors.DateEdit();
            this.textPhone = new DevExpress.XtraEditors.TextEdit();
            this.panelName = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addButton = new Libapp.UI.SmoothButton();
            this.imageMember = new System.Windows.Forms.PictureBox();
            this.cboxAuthority = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textIdentity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxAuthority.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.EditValue = "";
            this.textName.Location = new System.Drawing.Point(109, 250);
            this.textName.Name = "textName";
            this.textName.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textName.Properties.Appearance.Options.UseFont = true;
            this.textName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textName.Properties.NullValuePrompt = "Adı soyadı";
            this.textName.Size = new System.Drawing.Size(168, 22);
            this.textName.TabIndex = 2;
            // 
            // textIdentity
            // 
            this.textIdentity.EditValue = "";
            this.textIdentity.Location = new System.Drawing.Point(109, 304);
            this.textIdentity.Name = "textIdentity";
            this.textIdentity.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textIdentity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textIdentity.Properties.Appearance.Options.UseFont = true;
            this.textIdentity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textIdentity.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textIdentity.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d";
            this.textIdentity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textIdentity.Properties.NullValuePrompt = "TC kimlik numarası";
            this.textIdentity.Size = new System.Drawing.Size(168, 22);
            this.textIdentity.TabIndex = 3;
            // 
            // textGender
            // 
            this.textGender.EditValue = "Erkek";
            this.textGender.Location = new System.Drawing.Point(406, 196);
            this.textGender.Name = "textGender";
            this.textGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textGender.Properties.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.textGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.textGender.Size = new System.Drawing.Size(168, 20);
            this.textGender.TabIndex = 4;
            this.textGender.SelectedIndexChanged += new System.EventHandler(this.textGender_SelectedIndexChanged);
            // 
            // textEmail
            // 
            this.textEmail.EditValue = "";
            this.textEmail.Location = new System.Drawing.Point(109, 196);
            this.textEmail.Name = "textEmail";
            this.textEmail.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEmail.Properties.Appearance.Options.UseFont = true;
            this.textEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textEmail.Properties.NullValuePrompt = "Email adresi";
            this.textEmail.Size = new System.Drawing.Size(168, 22);
            this.textEmail.TabIndex = 1;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.EditValue = null;
            this.dateOfBirth.Location = new System.Drawing.Point(406, 250);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOfBirth.Properties.NullValuePrompt = "Doğum tarihi";
            this.dateOfBirth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateOfBirth.Size = new System.Drawing.Size(168, 20);
            this.dateOfBirth.TabIndex = 5;
            // 
            // textPhone
            // 
            this.textPhone.EditValue = "";
            this.textPhone.Location = new System.Drawing.Point(406, 304);
            this.textPhone.Name = "textPhone";
            this.textPhone.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPhone.Properties.Appearance.Options.UseFont = true;
            this.textPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textPhone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textPhone.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.textPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textPhone.Properties.NullValuePrompt = "Telefon numarası";
            this.textPhone.Size = new System.Drawing.Size(168, 22);
            this.textPhone.TabIndex = 6;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.Green;
            this.panelName.Location = new System.Drawing.Point(109, 218);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(168, 1);
            this.panelName.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(109, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 1);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(109, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 1);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(406, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 1);
            this.panel3.TabIndex = 26;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.addButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 19;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(270, 369);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 40);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Üye ekle";
            this.addButton.TextColor = System.Drawing.Color.White;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // imageMember
            // 
            this.imageMember.Image = global::Libapp.Properties.Resources.male;
            this.imageMember.Location = new System.Drawing.Point(274, 23);
            this.imageMember.Name = "imageMember";
            this.imageMember.Size = new System.Drawing.Size(139, 117);
            this.imageMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageMember.TabIndex = 0;
            this.imageMember.TabStop = false;
            // 
            // cboxAuthority
            // 
            this.cboxAuthority.EditValue = "1. Üye";
            this.cboxAuthority.Location = new System.Drawing.Point(274, 146);
            this.cboxAuthority.Name = "cboxAuthority";
            this.cboxAuthority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxAuthority.Properties.Items.AddRange(new object[] {
            "1. Üye",
            "2. Personel",
            "3. Yönetici"});
            this.cboxAuthority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxAuthority.Size = new System.Drawing.Size(139, 20);
            this.cboxAuthority.TabIndex = 27;
            // 
            // AddMember
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 445);
            this.Controls.Add(this.cboxAuthority);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textGender);
            this.Controls.Add(this.textIdentity);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.imageMember);
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.Name = "AddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye ekle";
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textIdentity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxAuthority.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageMember;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.TextEdit textIdentity;
        private DevExpress.XtraEditors.ComboBoxEdit textGender;
        private DevExpress.XtraEditors.TextEdit textEmail;
        private DevExpress.XtraEditors.DateEdit dateOfBirth;
        private DevExpress.XtraEditors.TextEdit textPhone;
        private UI.SmoothButton addButton;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public DevExpress.XtraEditors.ComboBoxEdit cboxAuthority;
    }
}