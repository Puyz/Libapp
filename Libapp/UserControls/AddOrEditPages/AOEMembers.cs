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
using Libapp.Pages.MemberPages;
using Libapp.Models;

namespace Libapp.UserControls.AddOrEditPages
{
    public partial class AOEMembers : UserControl
    {
        Functions.Members functions = new Functions.Members();
        Member member = new Member();
        Functions.Logs functionsLogs = new Functions.Logs();
        public int authority;
        public AOEMembers()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            functions.clearDataGrid(ref gridControl);
            functions.fillDataGrid(ref gridControl, authority);
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            functions.filterData(filterText.Text, ref gridView);
        }

        private void AOEMembers_Load(object sender, EventArgs e)
        {
            refresh();
            functions.hideColumn(ref gridView);
        }

        private void filterText_TextChanged(object sender, EventArgs e)
        {
            functions.filterData(filterText.Text, ref gridView);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            if (authority == 2) addMember.cboxAuthority.Visible = false;
            addMember.ShowDialog();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            member.memberID = Convert.ToInt32(gridView.GetFocusedRowCellValue("id"));
            member.name = gridView.GetFocusedRowCellValue("adisoyadi").ToString();
            member.identity = gridView.GetFocusedRowCellValue("kimlikno").ToString();
            member.gender = gridView.GetFocusedRowCellValue("cinsiyet").ToString();
            member.date = gridView.GetFocusedRowCellValue("dogumtarihi").ToString();
            member.email = gridView.GetFocusedRowCellValue("email").ToString();
            member.phone = gridView.GetFocusedRowCellValue("telefonno").ToString();
            //
            EditMember editMember = new EditMember(member);
            editMember.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            member.memberID = Convert.ToInt32(gridView.GetFocusedRowCellValue("id"));
            member.name = gridView.GetFocusedRowCellValue("adisoyadi").ToString();
            if (MessageBox.Show($"{member.name} adlı üyeyi silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                functions.deleteMember(member);
                functions.deleteLogin(member);
                functionsLogs.addLog($"{member.name} adlı üye silindi.");
                MessageBox.Show("Üye silindi.");
                refresh();
            }
        }
    }
}
