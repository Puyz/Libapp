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
    public partial class MainMember : DevExpress.XtraEditors.XtraForm
    {
        Member member;
        public MainMember(Member member)
        {
            InitializeComponent();
            this.member = member;
            myBooks.teID = member.memberID;
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

        private void profileButton_Click(object sender, EventArgs e)
        {
            MemberPages.InfoMember infoMember = new MemberPages.InfoMember(member.memberID);
            infoMember.ShowDialog();
        }

        private void MainMember_Load(object sender, EventArgs e)
        {
            menuImage.Image = (member.gender == "Erkek") ? Properties.Resources.man : Properties.Resources.woman;
            menuUserName.Text = member.name;
        }

        private void MainMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
