using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libapp.Functions;
using Libapp.Models;

namespace Libapp.Pages.BookPages
{
    public partial class EditBook : DevExpress.XtraEditors.XtraForm
    {
        Books functionsBooks = new Books();
        Shelfs functionsShelfs = new Shelfs();
        Logs functionsLogs = new Logs();
        Book book = new Book();
        Shelf shelf = new Shelf();
        

        string oldBookName, oldAuthorName, oldShelfName;
        string selectedShelfName;
        public EditBook(Book book)
        {
            InitializeComponent();
            this.book = book;
            this.oldBookName = book.bookName;
            this.oldAuthorName = book.authorName;
            this.oldShelfName = book.shelfName;
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            textBookName.Text = oldBookName;
            textAuthorName.Text = oldAuthorName;
            cBoxShelfs.Text = oldShelfName;
            selectedShelfName = oldShelfName;
            functionsShelfs.cboxFillShelfs(ref cBoxShelfs);
        }

        private void cBoxShelfs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShelfName = cBoxShelfs.Text.Substring(0, cBoxShelfs.Text.IndexOf(":")-32);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            
            if (!(String.IsNullOrWhiteSpace(textBookName.Text) || String.IsNullOrWhiteSpace(textAuthorName.Text)))
            {
                book.bookName = textBookName.Text;
                book.authorName = textAuthorName.Text;
                book.shelfName = selectedShelfName;
                if (selectedShelfName != oldShelfName)
                {
                    Shelf oldShelf = new Shelf();
                    oldShelf.name = oldShelfName;
                    shelf.name = selectedShelfName;
                    functionsShelfs.shelfDeValue(shelf); // Yeni raf -1
                    functionsShelfs.shelfReValue(oldShelf);   // Eski raf +1
                }
                functionsBooks.editBook(book);
                functionsLogs.addLog($"{book.bookName} adlı kitap güncellendi.");
                MessageBox.Show("Kitap güncellendi.");
                Main main = (Main)Application.OpenForms["Main"];
                main.addOrEdit.aoeBooks.refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");
            }

           
        }

        
    }
}
