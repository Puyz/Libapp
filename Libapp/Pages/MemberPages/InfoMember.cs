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
    public partial class InfoMember : DevExpress.XtraEditors.XtraForm
    {
        Members functions = new Members();
        Member member = new Member();
        public InfoMember(int id)
        {
            InitializeComponent();
            member = functions.getMember(id);
        }

        private void InfoMember_Load(object sender, EventArgs e)
        {
            memberName.Text = member.name;
            identity.Text = member.identity;
            gender.Text = member.gender;
            dateOfBirth.Text = member.date;
            mail.Text = member.email;
            phone.Text = member.phone;
            dateOfRegistration.Text = member.dateOfRegistration;
            imageMember.Image = (member.gender == "Erkek") ? imageMember.Image = Properties.Resources.male : imageMember.Image = Properties.Resources.female;
            
        }

        private void InfoMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
