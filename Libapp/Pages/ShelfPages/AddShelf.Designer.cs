
namespace Libapp.Pages.ShelfPages
{
    partial class AddShelf
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
            this.panelShelfName = new System.Windows.Forms.Panel();
            this.textShelfName = new DevExpress.XtraEditors.TextEdit();
            this.panelCapacity = new System.Windows.Forms.Panel();
            this.textCapacity = new DevExpress.XtraEditors.TextEdit();
            this.addButton = new Libapp.UI.SmoothButton();
            ((System.ComponentModel.ISupportInitialize)(this.textShelfName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCapacity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShelfName
            // 
            this.panelShelfName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelShelfName.Location = new System.Drawing.Point(74, 76);
            this.panelShelfName.Name = "panelShelfName";
            this.panelShelfName.Size = new System.Drawing.Size(222, 1);
            this.panelShelfName.TabIndex = 20;
            // 
            // textShelfName
            // 
            this.textShelfName.EditValue = "";
            this.textShelfName.Location = new System.Drawing.Point(74, 52);
            this.textShelfName.Name = "textShelfName";
            this.textShelfName.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.textShelfName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textShelfName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textShelfName.Properties.Appearance.Options.UseFont = true;
            this.textShelfName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textShelfName.Properties.HideSelection = false;
            this.textShelfName.Properties.Mask.EditMask = "\\p{L}+";
            this.textShelfName.Properties.Mask.ShowPlaceHolders = false;
            this.textShelfName.Properties.NullValuePrompt = "Raf adı";
            this.textShelfName.Size = new System.Drawing.Size(222, 22);
            this.textShelfName.TabIndex = 19;
            this.textShelfName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textShelfName_KeyPress);
            // 
            // panelCapacity
            // 
            this.panelCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelCapacity.Location = new System.Drawing.Point(74, 158);
            this.panelCapacity.Name = "panelCapacity";
            this.panelCapacity.Size = new System.Drawing.Size(222, 1);
            this.panelCapacity.TabIndex = 23;
            // 
            // textCapacity
            // 
            this.textCapacity.EditValue = "";
            this.textCapacity.Location = new System.Drawing.Point(74, 134);
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
            this.textCapacity.Size = new System.Drawing.Size(222, 22);
            this.textCapacity.TabIndex = 22;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.addButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 17;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(131, 216);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 35);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Ekle";
            this.addButton.TextColor = System.Drawing.Color.White;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddShelf
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 299);
            this.Controls.Add(this.panelCapacity);
            this.Controls.Add(this.textCapacity);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.panelShelfName);
            this.Controls.Add(this.textShelfName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Libapp.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.Name = "AddShelf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raf ekle";
            ((System.ComponentModel.ISupportInitialize)(this.textShelfName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCapacity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.SmoothButton addButton;
        private System.Windows.Forms.Panel panelShelfName;
        private DevExpress.XtraEditors.TextEdit textShelfName;
        private System.Windows.Forms.Panel panelCapacity;
        private DevExpress.XtraEditors.TextEdit textCapacity;
    }
}