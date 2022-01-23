using System;
using Libapp.Database;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using Libapp.Models;
using System.Windows.Forms;
using System.Data;
using Libapp.UI;
using System.Drawing;

namespace Libapp.Functions
{
    class Books
    {
        BaseDatabaseManager dataBase = new MySqlDatabaseManager();

        public void clearDataGrid(ref GridControl gridControl)
        {
            gridControl.DataSource = null;
        }
        public void fillDataGrid(ref GridControl gridControl)
        {
            gridControl.DataSource = dataBase.booksGridDataSource();
        }
        public void hideColumn(ref GridView gridView)
        {
            gridView.Columns["id"].Visible = false;
            gridView.Columns["teTarih"].Visible = false;
            gridView.Columns["teKisi"].Visible = false;
            gridView.Columns["teId"].Visible = false;
            gridView.Columns["kitapResmi"].Visible = false;

            //çizgi
            gridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
        }

        public void assignValue(ref Book book, ref GridView gridView)
        {
            book.id = Convert.ToInt32(gridView.GetFocusedRowCellValue("id"));
            book.bookName = gridView.GetFocusedRowCellValue("kitapAdi").ToString();
            book.authorName = gridView.GetFocusedRowCellValue("yazarAdi").ToString();
            book.shelfName = gridView.GetFocusedRowCellValue("rafAdi").ToString();
            book.status = gridView.GetFocusedRowCellValue("durum").ToString();
            book.teDate = gridView.GetFocusedRowCellValue("teTarih").ToString();
            if (!String.IsNullOrEmpty(gridView.GetFocusedRowCellValue("teId").ToString())) { book.teID = Convert.ToInt32(gridView.GetFocusedRowCellValue("teId")); }
            book.teMember = gridView.GetFocusedRowCellValue("teKisi").ToString();

            if (String.IsNullOrEmpty(gridView.GetFocusedRowCellValue("kitapResmi").ToString()))
            {
                book.bookImage = Properties.Resources.defaultBook.ToString();
            }
            else
            {
                book.bookImage = gridView.GetFocusedRowCellValue("kitapResmi").ToString();
            }



        }

        public void filterData(string data, ref GridView gridView)
        {
            gridView.ActiveFilterString = $"kitapAdi LIKE '%{data}%' OR yazarAdi LIKE '%{data}%' " +
                $"OR rafAdi LIKE '%{data}%' OR durum LIKE '%{data}%'";
        }

        public void addBook(Book book)
        {
            dataBase.addBook(book);
        }
        public void editBook(Book book)
        {
            dataBase.editBook(book);
        }
        public void deleteBook(Book book)
        {
            dataBase.deleteBook(book);
        }

        public void deliverBook(Book book, Member member)
        {
            dataBase.deliverBook(book, member);
        }
        public void receiveBook(Book book)
        {
            dataBase.receiveBook(book);
        }


        public bool ControlListMyBooks(int teID)
        {
            return (dataBase.listMyBook(teID).Rows.Count != 0) ? true : false;
        }
        public void ListMyBooks(FlowLayoutPanel panelShelfs, int teID)
        {
            try
            {
                int color = 0;
                foreach (DataRow item in dataBase.listMyBook(teID).Rows)
                {
                    Book book = new Book();
                    book.id = Convert.ToInt32(item["id"]);
                    book.bookName = item["kitapAdi"].ToString();
                    book.authorName = item["yazarAdi"].ToString();
                    book.bookImage = item["kitapResmi"].ToString();
                    book.teID = Convert.ToInt32(item["teId"]);
                    UIMyBooks uiMyBooks = new UIMyBooks();

                    panelShelfs.Invoke((MethodInvoker)delegate
                    {
                        if (color % 2 == 0) uiMyBooks.BackColor = Color.White;
                        else uiMyBooks.BackColor = Color.WhiteSmoke;

                        uiMyBooks.imageBook.ImageLocation = book.bookImage;
                        uiMyBooks.bookName.Text = book.bookName;
                        uiMyBooks.authorName.Text = book.authorName;
                        uiMyBooks.Dock = DockStyle.Top;
                        panelShelfs.Controls.Add(uiMyBooks);
                    });
                    color++;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }


        }
    }
}
