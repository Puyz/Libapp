
namespace Libapp.UI
{
    partial class UIMyBooks
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
            this.imageBook = new System.Windows.Forms.PictureBox();
            this.authorName = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBook
            // 
            this.imageBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageBook.ErrorImage = global::Libapp.Properties.Resources.defaultBook;
            this.imageBook.Image = global::Libapp.Properties.Resources.defaultBook;
            this.imageBook.ImageLocation = "";
            this.imageBook.Location = new System.Drawing.Point(0, 0);
            this.imageBook.Name = "imageBook";
            this.imageBook.Size = new System.Drawing.Size(76, 51);
            this.imageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBook.TabIndex = 16;
            this.imageBook.TabStop = false;
            // 
            // authorName
            // 
            this.authorName.AutoEllipsis = true;
            this.authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorName.Location = new System.Drawing.Point(435, 19);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(248, 13);
            this.authorName.TabIndex = 20;
            this.authorName.Text = "Author";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.ForeColor = System.Drawing.Color.DimGray;
            this.labelAuthorName.Location = new System.Drawing.Point(385, 19);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(54, 13);
            this.labelAuthorName.TabIndex = 19;
            this.labelAuthorName.Text = "Yazar adı:";
            // 
            // bookName
            // 
            this.bookName.AutoEllipsis = true;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookName.Location = new System.Drawing.Point(165, 19);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(184, 13);
            this.bookName.TabIndex = 18;
            this.bookName.Text = "Book";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.ForeColor = System.Drawing.Color.DimGray;
            this.labelBookName.Location = new System.Drawing.Point(115, 19);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(51, 13);
            this.labelBookName.TabIndex = 17;
            this.labelBookName.Text = "Kitap adı:";
            // 
            // UIMyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.imageBook);
            this.Name = "UIMyBooks";
            this.Size = new System.Drawing.Size(734, 51);
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label labelBookName;
        public System.Windows.Forms.PictureBox imageBook;
        public System.Windows.Forms.Label authorName;
        public System.Windows.Forms.Label bookName;
    }
}
