using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libapp.Pages.BookPages;
using Libapp.Models;

namespace Libapp.UserControls.AddOrEditPages
{
    public partial class AOEBooks : UserControl
    {
        Functions.Books functionsBooks = new Functions.Books();
        Functions.Shelfs functionsShelfs = new Functions.Shelfs();
        Functions.Logs  FunctionsLog = new Functions.Logs();
        
        public AOEBooks()
        {
            InitializeComponent();
        }
        public void refresh()
        {

            functionsBooks.clearDataGrid(ref gridControl);
            functionsBooks.fillDataGrid(ref gridControl);
        } 

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            functionsBooks.filterData(filterText.Text, ref gridView);
        }

       

        private void filterText_TextChanged(object sender, EventArgs e)
        {
            functionsBooks.filterData(filterText.Text, ref gridView);
        }

        private void AOEBooks_Load(object sender, EventArgs e)
        {
            functionsBooks.clearDataGrid(ref gridControl);
            functionsBooks.fillDataGrid(ref gridControl);
            functionsBooks.hideColumn(ref gridView);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.id = Convert.ToInt32(gridView.GetFocusedRowCellValue("id"));
            book.bookName = gridView.GetFocusedRowCellValue("kitapAdi").ToString();
            book.authorName = gridView.GetFocusedRowCellValue("yazarAdi").ToString();
            book.shelfName = gridView.GetFocusedRowCellValue("rafAdi").ToString();
            //
            EditBook editBook = new EditBook(book);
            editBook.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            Shelf shelf = new Shelf();
            book.id = Convert.ToInt32(gridView.GetFocusedRowCellValue("id"));
            book.bookName = gridView.GetFocusedRowCellValue("kitapAdi").ToString();
            shelf.name = gridView.GetFocusedRowCellValue("rafAdi").ToString();
            if (MessageBox.Show($"{book.bookName} adlı kitabı silmek istediğinizden emin misiniz?","Uyarı",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                functionsBooks.deleteBook(book);
                functionsShelfs.shelfReValue(shelf);
                FunctionsLog.addLog($"{book.bookName} adlı kitap silindi.");
                MessageBox.Show("Kitap silindi.");
                refresh();
            }
        }
    }
}
