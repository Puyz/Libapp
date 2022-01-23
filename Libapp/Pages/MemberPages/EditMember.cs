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

namespace Libapp.Pages.MemberPages
{
    public partial class EditMember : DevExpress.XtraEditors.XtraForm
    {
        Members functions = new Members();
        Member member = new Member();
        Logs functionsLogs = new Logs();

        private void editButton_Click(object sender, EventArgs e)
        {
            member.name = textName.Text;
            member.identity = textIdentity.Text;
            member.date = dateOfBirth.Text;
            member.phone = textPhone.Text;
            member.gender = textGender.Text;
            if (!(String.IsNullOrWhiteSpace(member.name) || String.IsNullOrWhiteSpace(member.identity) || String.IsNullOrWhiteSpace(member.date) || String.IsNullOrWhiteSpace(member.phone)))
            {
                functions.editMember(member);
                functionsLogs.addLog($"{member.name} adlı üye güncellendi.");
                MessageBox.Show("Üye güncellendi.");
                Main main = (Main)Application.OpenForms["Main"];
                main.addOrEdit.aoeMembers.refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");
            }
        }

        private void textGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textGender.Text == "Erkek")
            {
                imageMember.Image = Properties.Resources.male;
            }
            else
            {
                imageMember.Image = Properties.Resources.female;
            }
        }

        private void EditMember_Load(object sender, EventArgs e)
        {
            textName.Text = member.name;
            textIdentity.Text = member.identity;
            textGender.Text = member.gender;
            dateOfBirth.Text = member.date;
            textEmail.Text = member.email;
            textPhone.Text = member.phone;
        }

        public EditMember(Member member)
        {
            InitializeComponent();
            this.member = member;
        }
    }
}
