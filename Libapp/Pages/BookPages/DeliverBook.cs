using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libapp.Models;

namespace Libapp.Pages.BookPages
{
    public partial class DeliverBook : DevExpress.XtraEditors.XtraForm
    {
        Functions.Members functionsMember = new Functions.Members();
        Functions.Books functionsBook = new Functions.Books();
        Functions.Logs functionsLog = new Functions.Logs();
        Member member = new Member();
        Book book = new Book();

        public DeliverBook(Book book)
        {
            InitializeComponent();
            this.book = book;
        }
        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            functionsMember.assignValue(ref member, ref gridView);
            if (MessageBox.Show($"{member.name} adlı üyeye teslim etmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                functionsBook.deliverBook(book,member);
                functionsLog.addLog($"{book.bookName} kitabı {member.name} kişisine teslim edildi.");
                MessageBox.Show("Kitap teslim edildi.");
                Main main = (Main)Application.OpenForms["Main"];
                main.books.refresh();
                this.Close();
            }
        }
        private void DeliverBook_Load(object sender, EventArgs e)
        {
            refresh();
            functionsMember.hideColumn(ref gridView);
            functionsMember.assignValue(ref member, ref gridView);
        }
        private void filterText_TextChanged(object sender, EventArgs e)
        {
            functionsMember.filterData(filterText.Text, ref gridView);
        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            functionsMember.filterData(filterText.Text, ref gridView);
        }
        private void refresh()
        {
            functionsMember.clearDataGrid(ref gridControl);
            functionsMember.fillDataGrid(ref gridControl,2);
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
