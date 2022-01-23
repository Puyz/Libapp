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

namespace Libapp.Pages
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        Member member;
        public int authority;
        public Main(Member member)
        {
            InitializeComponent();
            this.member = member;
            menuUserName.Text = member.name.ToUpper(); 
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void booksButton_Click(object sender, EventArgs e)
        {
            books.Visible = true;
            members.Visible = false;
            addOrEdit.Visible = false;
            logs.Visible = false;
            books.refresh();
        }

        private void logsButton_Click(object sender, EventArgs e)
        {
            logs.Visible = true;
            addOrEdit.Visible = false;
            members.Visible = false;
            books.Visible = false;
            logs.refresh();
        }

        private void addOrEditButton_Click(object sender, EventArgs e)
        {
            addOrEdit.Visible = true;
            members.Visible = false;
            books.Visible = false;
            logs.Visible = false;
            addOrEdit.aoeBooks.refresh();
        }

        private void membersButton_Click(object sender, EventArgs e)
        {
            members.Visible = true;
            books.Visible = false;
            addOrEdit.Visible = false;
            logs.Visible = false;
            members.refresh(authority);
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Dispose();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            menuImage.Image = (member.gender == "Erkek") ? Properties.Resources.man : Properties.Resources.woman;
            addOrEdit.aoeMembers.authority = authority;
            members.authority = authority;
            if (authority == 3)
            {
                membersButton.Text = "Üyeler / Personeller";
                addOrEdit.membersButton.Text = "Üyeler / Personeller";
                logs.deleteLogButton.Visible = true;
            }
        }
    }
}
