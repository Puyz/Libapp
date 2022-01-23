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
    public partial class AddBook : DevExpress.XtraEditors.XtraForm
    {
        Books bookFunctions = new Books();
        Shelfs shelfFunctions = new Shelfs();
        Logs logFunctions = new Logs();
        

        public AddBook()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            Shelf shelf = new Shelf();
            book.bookName = textBookName.Text;
            book.authorName = textAuthorName.Text;
            book.shelfName = cBoxShelfs.Text.Substring(0, cBoxShelfs.Text.IndexOf(":") - 32);
            shelf.name = cBoxShelfs.Text.Substring(0, cBoxShelfs.Text.IndexOf(":") - 32);

            if (!(string.IsNullOrWhiteSpace(textBookName.Text) || string.IsNullOrWhiteSpace(textAuthorName.Text)))
            {
                bookFunctions.addBook(book);
                shelfFunctions.shelfDeValue(shelf);
                logFunctions.addLog($"{book.bookName} adlı kitap eklendi.");
                MessageBox.Show("Kitap eklendi.");
                Main main = (Main)Application.OpenForms["Main"];
                main.addOrEdit.aoeBooks.refresh();
                this.Close();
            }else
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");
            }
           
            
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            shelfFunctions.cboxFillShelfs(ref cBoxShelfs);
            cBoxShelfs.Text = cBoxShelfs.Properties.Items[0].ToString();
        }
    }
}
