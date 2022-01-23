using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libapp.Functions;
using Libapp.Pages;
using Libapp.Pages.BookPages;
using Libapp.Pages.MemberPages;
using Libapp.Models;

namespace Libapp.UserControls
{
    public partial class Books : UserControl
    {
        Functions.Books functions = new Functions.Books();
        Functions.Logs functionsLog = new Functions.Logs();
        Book book = new Book();

       
        private void Books_Load(object sender, EventArgs e)
        {
            functions.clearDataGrid(ref gridControl);
            functions.fillDataGrid(ref gridControl);
            functions.hideColumn(ref gridView);
            memberClick();
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            if (book.status == "Teslim edilebilir")
            {
                DeliverBook deliverBook = new DeliverBook(book);
                deliverBook.ShowDialog();
            }
            else
            {
                if (MessageBox.Show($"{book.bookName} adlı kitabı {book.teMember} adlı üyeden teslim almak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    functions.receiveBook(book);
                    functionsLog.addLog($"{book.bookName} kitabı {book.teMember} tarafından teslim alındı.");
                    MessageBox.Show("Kitap teslim alındı.");
                    Main main = (Main)Application.OpenForms["Main"];
                    main.books.refresh();
                }
            }
        }

        private void deliveryUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoMember infoMember = new InfoMember(book.teID);
            infoMember.ShowDialog();
        }

        private void filterText_TextChanged(object sender, EventArgs e)
        {
            functions.filterData(filterText.Text, ref gridView);
        }

        public void refresh()
        {
            functions.clearDataGrid(ref gridControl);
            functions.fillDataGrid(ref gridControl);
            memberClick();

        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            functions.filterData(filterText.Text,ref gridView);
        }

        private void sidePanel1_Resize(object sender, EventArgs e)
        {
            bookName.Width = sidePanel1.Width -55;
            authorName.Width = sidePanel1.Width -55;
            shelfName.Width = sidePanel1.Width -55;
            panelDelivery.Width = sidePanel1.Width-10;
        }

        
        public Books()
        {
            InitializeComponent();
        }

        
        
        private void gridView1_Click(object sender, EventArgs e)
        {
            memberClick();
        }
        private void memberClick()
        {
            functions.assignValue(ref book, ref gridView);
            bookName.Text = book.bookName;
            authorName.Text = book.authorName;
            shelfName.Text = book.shelfName;

            status.Text = book.status;
            date.Text = book.teDate;
            deliveryUser.Text = book.teMember;
            imageBook.ImageLocation = book.bookImage;

            if (book.status == "Teslim edilebilir")
            {
                panelDelivery.Visible = false;
                buttonStatus.Text = "Teslim et";
                buttonStatus.BackColor = Color.FromArgb(1, 146, 71);
            }
            else
            {
                panelDelivery.Visible = true;
                buttonStatus.Text = "Teslim al";
                buttonStatus.BackColor = Color.FromArgb(0, 122, 204);
            }
        }
    }
}
