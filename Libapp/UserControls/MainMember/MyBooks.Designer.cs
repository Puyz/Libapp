
namespace Libapp.UserControls.MainMember
{
    partial class MyBooks
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
            this.emptyLabel = new System.Windows.Forms.Label();
            this.emptyPicture = new System.Windows.Forms.PictureBox();
            this.emptyPanel = new System.Windows.Forms.Panel();
            this.panelMyBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.bwMyBooks = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPicture)).BeginInit();
            this.emptyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emptyLabel
            // 
            this.emptyLabel.AutoEllipsis = true;
            this.emptyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.emptyLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emptyLabel.ForeColor = System.Drawing.Color.Gray;
            this.emptyLabel.Location = new System.Drawing.Point(0, 0);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(734, 182);
            this.emptyLabel.TabIndex = 1;
            this.emptyLabel.Text = "Teslim aldığın bir kitap bulunmuyor.";
            this.emptyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emptyPicture
            // 
            this.emptyPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.emptyPicture.Image = global::Libapp.Properties.Resources.empty;
            this.emptyPicture.Location = new System.Drawing.Point(0, 182);
            this.emptyPicture.Name = "emptyPicture";
            this.emptyPicture.Size = new System.Drawing.Size(734, 313);
            this.emptyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emptyPicture.TabIndex = 2;
            this.emptyPicture.TabStop = false;
            // 
            // emptyPanel
            // 
            this.emptyPanel.Controls.Add(this.emptyPicture);
            this.emptyPanel.Controls.Add(this.emptyLabel);
            this.emptyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyPanel.Location = new System.Drawing.Point(0, 0);
            this.emptyPanel.Name = "emptyPanel";
            this.emptyPanel.Size = new System.Drawing.Size(734, 633);
            this.emptyPanel.TabIndex = 3;
            // 
            // panelMyBooks
            // 
            this.panelMyBooks.AutoScroll = true;
            this.panelMyBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMyBooks.Location = new System.Drawing.Point(0, 0);
            this.panelMyBooks.Name = "panelMyBooks";
            this.panelMyBooks.Size = new System.Drawing.Size(734, 633);
            this.panelMyBooks.TabIndex = 4;
            // 
            // bwMyBooks
            // 
            this.bwMyBooks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMyBooks_DoWork);
            // 
            // MyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.emptyPanel);
            this.Controls.Add(this.panelMyBooks);
            this.Name = "MyBooks";
            this.Size = new System.Drawing.Size(734, 633);
            this.Load += new System.EventHandler(this.MyBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emptyPicture)).EndInit();
            this.emptyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label emptyLabel;
        private System.Windows.Forms.PictureBox emptyPicture;
        private System.Windows.Forms.Panel emptyPanel;
        private System.Windows.Forms.FlowLayoutPanel panelMyBooks;
        private System.ComponentModel.BackgroundWorker bwMyBooks;
    }
}
