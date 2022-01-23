
namespace Libapp.Pages.BookPages
{
    partial class EditBook
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
            this.cBoxShelfs = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelShelfName = new System.Windows.Forms.Panel();
            this.panelAuthorName = new System.Windows.Forms.Panel();
            this.textAuthorName = new DevExpress.XtraEditors.TextEdit();
            this.panelBookName = new System.Windows.Forms.Panel();
            this.textBookName = new DevExpress.XtraEditors.TextEdit();
            this.imageBook = new System.Windows.Forms.PictureBox();
            this.editButton = new Libapp.UI.SmoothButton();
            ((System.ComponentModel.ISupportInitialize)(this.cBoxShelfs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAuthorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBookName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxShelfs
            // 
            this.cBoxShelfs.Location = new System.Drawing.Point(118, 298);
            this.cBoxShelfs.Name = "cBoxShelfs";
            this.cBoxShelfs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cBoxShelfs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cBoxShelfs.Size = new System.Drawing.Size(222, 20);
            this.cBoxShelfs.TabIndex = 25;
            this.cBoxShelfs.SelectedIndexChanged += new System.EventHandler(this.cBoxShelfs_SelectedIndexChanged);
            // 
            // panelShelfName
            // 
            this.panelShelfName.BackColor = System.Drawing.Color.Teal;
            this.panelShelfName.Location = new System.Drawing.Point(118, 318);
            this.panelShelfName.Name = "panelShelfName";
            this.panelShelfName.Size = new System.Drawing.Size(222, 1);
            this.panelShelfName.TabIndex = 24;
            // 
            // panelAuthorName
            // 
            this.panelAuthorName.BackColor = System.Drawing.Color.Teal;
            this.panelAuthorName.Location = new System.Drawing.Point(118, 258);
            this.panelAuthorName.Name = "panelAuthorName";
            this.panelAuthorName.Size = new System.Drawing.Size(222, 1);
            this.panelAuthorName.TabIndex = 23;
            // 
            // textAuthorName
            // 
            this.textAuthorName.EditValue = "";
            this.textAuthorName.Location = new System.Drawing.Point(118, 234);
            this.textAuthorName.Name = "textAuthorName";
            this.textAuthorName.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textAuthorName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAuthorName.Properties.Appearance.Options.UseFont = true;
            this.textAuthorName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textAuthorName.Properties.NullValuePrompt = "Yazar adı";
            this.textAuthorName.Size = new System.Drawing.Size(222, 22);
            this.textAuthorName.TabIndex = 22;
            // 
            // panelBookName
            // 
            this.panelBookName.BackColor = System.Drawing.Color.Teal;
            this.panelBookName.Location = new System.Drawing.Point(118, 194);
            this.panelBookName.Name = "panelBookName";
            this.panelBookName.Size = new System.Drawing.Size(222, 1);
            this.panelBookName.TabIndex = 21;
            // 
            // textBookName
            // 
            this.textBookName.EditValue = "";
            this.textBookName.Location = new System.Drawing.Point(118, 170);
            this.textBookName.Name = "textBookName";
            this.textBookName.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.textBookName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textBookName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBookName.Properties.Appearance.Options.UseFont = true;
            this.textBookName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textBookName.Properties.NullValuePrompt = "Kitap adı";
            this.textBookName.Size = new System.Drawing.Size(222, 22);
            this.textBookName.TabIndex = 20;
            // 
            // imageBook
            // 
            this.imageBook.Image = global::Libapp.Properties.Resources.defaultBook;
            this.imageBook.Location = new System.Drawing.Point(169, 33);
            this.imageBook.Name = "imageBook";
            this.imageBook.Size = new System.Drawing.Size(120, 95);
            this.imageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBook.TabIndex = 19;
            this.imageBook.TabStop = false;
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
            this.editButton.Location = new System.Drawing.Point(175, 360);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(108, 35);
            this.editButton.TabIndex = 26;
            this.editButton.Text = "Kaydet";
            this.editButton.TextColor = System.Drawing.Color.White;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // EditBook
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 428);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.cBoxShelfs);
            this.Controls.Add(this.panelShelfName);
            this.Controls.Add(this.panelAuthorName);
            this.Controls.Add(this.textAuthorName);
            this.Controls.Add(this.panelBookName);
            this.Controls.Add(this.textBookName);
            this.Controls.Add(this.imageBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.Name = "EditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap düzenle";
            this.Load += new System.EventHandler(this.EditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cBoxShelfs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAuthorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBookName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.SmoothButton editButton;
        private DevExpress.XtraEditors.ComboBoxEdit cBoxShelfs;
        private System.Windows.Forms.Panel panelShelfName;
        private System.Windows.Forms.Panel panelAuthorName;
        private DevExpress.XtraEditors.TextEdit textAuthorName;
        private System.Windows.Forms.Panel panelBookName;
        private DevExpress.XtraEditors.TextEdit textBookName;
        private System.Windows.Forms.PictureBox imageBook;
    }
}