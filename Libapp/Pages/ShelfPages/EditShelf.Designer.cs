
namespace Libapp.Pages.ShelfPages
{
    partial class EditShelf
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
        /// 
        private void InitializeComponent()
        {
            
            this.panelCapacity = new System.Windows.Forms.Panel();
            this.textFullness = new DevExpress.XtraEditors.TextEdit();
            this.panelShelfName = new System.Windows.Forms.Panel();
            this.textShelfName = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textCapacity = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new Libapp.UI.SmoothButton();

            Models.Shelf mShelf = new Models.Shelf();
            this.infoShelf = new Libapp.UI.infoShelf(mShelf);

            ((System.ComponentModel.ISupportInitialize)(this.textFullness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textShelfName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCapacity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCapacity
            // 
            this.panelCapacity.BackColor = System.Drawing.Color.Teal;
            this.panelCapacity.Location = new System.Drawing.Point(156, 278);
            this.panelCapacity.Name = "panelCapacity";
            this.panelCapacity.Size = new System.Drawing.Size(88, 1);
            this.panelCapacity.TabIndex = 27;
            // 
            // textFullness
            // 
            this.textFullness.EditValue = "";
            this.textFullness.Enabled = false;
            this.textFullness.Location = new System.Drawing.Point(156, 254);
            this.textFullness.Name = "textFullness";
            this.textFullness.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.textFullness.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textFullness.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFullness.Properties.Appearance.Options.UseFont = true;
            this.textFullness.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textFullness.Properties.Mask.EditMask = "\\d{0,9}";
            this.textFullness.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textFullness.Properties.Mask.ShowPlaceHolders = false;
            this.textFullness.Properties.NullValuePrompt = "Doluluk";
            this.textFullness.Size = new System.Drawing.Size(88, 22);
            this.textFullness.TabIndex = 26;
            // 
            // panelShelfName
            // 
            this.panelShelfName.BackColor = System.Drawing.Color.Teal;
            this.panelShelfName.Location = new System.Drawing.Point(156, 196);
            this.panelShelfName.Name = "panelShelfName";
            this.panelShelfName.Size = new System.Drawing.Size(222, 1);
            this.panelShelfName.TabIndex = 25;
            // 
            // textShelfName
            // 
            this.textShelfName.EditValue = "";
            this.textShelfName.Location = new System.Drawing.Point(156, 172);
            this.textShelfName.Name = "textShelfName";
            this.textShelfName.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.textShelfName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textShelfName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textShelfName.Properties.Appearance.Options.UseFont = true;
            this.textShelfName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textShelfName.Properties.NullValuePrompt = "Raf adı";
            this.textShelfName.Size = new System.Drawing.Size(222, 22);
            this.textShelfName.TabIndex = 24;
            this.textShelfName.TextChanged += new System.EventHandler(this.textShelfName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(290, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 1);
            this.panel1.TabIndex = 29;
            // 
            // textCapacity
            // 
            this.textCapacity.EditValue = "";
            this.textCapacity.Location = new System.Drawing.Point(290, 254);
            this.textCapacity.Name = "textCapacity";
            this.textCapacity.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.textCapacity.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textCapacity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textCapacity.Properties.Appearance.Options.UseFont = true;
            this.textCapacity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textCapacity.Properties.Mask.EditMask = "\\d{0,9}";
            this.textCapacity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textCapacity.Properties.Mask.ShowPlaceHolders = false;
            this.textCapacity.Properties.NullValuePrompt = "Kapasite";
            this.textCapacity.Size = new System.Drawing.Size(88, 22);
            this.textCapacity.TabIndex = 28;
            this.textCapacity.TextChanged += new System.EventHandler(this.textCapacity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "/";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Teal;
            this.editButton.BackgroundColor = System.Drawing.Color.Teal;
            this.editButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editButton.BorderRadius = 17;
            this.editButton.BorderSize = 0;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(213, 335);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(108, 35);
            this.editButton.TabIndex = 31;
            this.editButton.Text = "Kaydet";
            this.editButton.TextColor = System.Drawing.Color.White;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // infoShelf
            // 
            this.infoShelf.BackColor = System.Drawing.Color.White;
            this.infoShelf.Enabled = false;
            this.infoShelf.Location = new System.Drawing.Point(190, 26);
            this.infoShelf.Name = "infoShelf";
            this.infoShelf.Size = new System.Drawing.Size(155, 106);
            this.infoShelf.TabIndex = 0;
            // 
            // EditShelf
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 425);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textCapacity);
            this.Controls.Add(this.panelCapacity);
            this.Controls.Add(this.textFullness);
            this.Controls.Add(this.panelShelfName);
            this.Controls.Add(this.textShelfName);
            this.Controls.Add(this.infoShelf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.Name = "EditShelf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raf düzenle";
            this.Load += new System.EventHandler(this.EditShelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textFullness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textShelfName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCapacity.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.infoShelf infoShelf; 
        private System.Windows.Forms.Panel panelCapacity;
        private DevExpress.XtraEditors.TextEdit textFullness;
        private System.Windows.Forms.Panel panelShelfName;
        private DevExpress.XtraEditors.TextEdit textShelfName;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit textCapacity;
        private System.Windows.Forms.Label label1;
        private UI.SmoothButton editButton;
    }
}