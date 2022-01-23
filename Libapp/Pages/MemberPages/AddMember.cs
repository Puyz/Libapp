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
using Libapp.Mail;
using Libapp.Models;

namespace Libapp.Pages.MemberPages
{
    public partial class AddMember : DevExpress.XtraEditors.XtraForm
    {
        Members functions = new Members();
       
        public AddMember()
        {
            InitializeComponent();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            int authority = Convert.ToInt32(cboxAuthority.Text.Substring(0,cboxAuthority.Text.IndexOf('.')));
            Member member = new Member();
            member.email = textEmail.Text;
            member.name = textName.Text;
            member.identity = textIdentity.Text;
            member.date = dateOfBirth.Text;
            member.phone = textPhone.Text;
            member.gender = textGender.Text;
            if (!(String.IsNullOrWhiteSpace(member.email) || String.IsNullOrWhiteSpace(member.name) || String.IsNullOrWhiteSpace(member.identity) ||
                String.IsNullOrWhiteSpace(member.date) || String.IsNullOrWhiteSpace(member.phone)))
            {
                if (!this.textEmail.Text.Contains('@') || !this.textEmail.Text.Contains('.')) // Email için @ ve . kontrolü
                {
                    MessageBox.Show("Lütfen geçerli bir email adresi giriniz.", "Geçersiz email");
                }
                else
                {
                    if (!functions.memberControl(member)) // Kullanıcı kontrolü
                    {
                        MailVerify mailVerify = new MailVerify(member,authority);
                        mailVerify.ShowDialog();
                    }
                    else { MessageBox.Show("Bu maile kayıtlı bir kullanıcı zaten mevcut."); }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
        }
    }
}
