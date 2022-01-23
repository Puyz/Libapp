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

namespace Libapp.UserControls
{
    public partial class Members : UserControl
    {
        Functions.Members functions = new Functions.Members();
        Member member = new Member();
        public int authority=2;
        private void filterButton_Click(object sender, EventArgs e)
        {
            functions.filterData(filterText.Text, ref gridView);
        }

        private void Members_Load(object sender, EventArgs e)
        {
            refresh(authority);
            functions.hideColumn(ref gridView);
            functions.assignValue(ref member, ref gridView);
            memberName.Text = member.name;
            identity.Text = member.identity;
            gender.Text = member.gender;
            dateOfBirth.Text = member.date;
            mail.Text = member.email;
            phone.Text = member.phone;
            dateOfRegistration.Text = member.dateOfRegistration;
            imageMember.Image = (member.gender == "Erkek") ? imageMember.Image = Properties.Resources.male : imageMember.Image = Properties.Resources.female;

        }

        private void filterText_TextChanged(object sender, EventArgs e)
        {
            functions.filterData(filterText.Text, ref gridView);
        }

        public void refresh(int authority)
        {
            functions.clearDataGrid(ref gridControl);
            functions.fillDataGrid(ref gridControl,authority); 
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh(authority);
        }

        private void sidePanel1_Resize(object sender, EventArgs e)
        {
            memberName.Width = sidePanel1.Width - 85;
            identity.Width = sidePanel1.Width - 85;
            gender.Width = sidePanel1.Width - 85;
            dateOfBirth.Width = sidePanel1.Width - 85;
            mail.Width = sidePanel1.Width - 85;
            phone.Width = sidePanel1.Width - 85;
            dateOfRegistration.Width = sidePanel1.Width - 85;
        }

        private void gridView_Click(object sender, EventArgs e)
        {
            functions.assignValue(ref member, ref gridView);
            memberName.Text = member.name;
            identity.Text = member.identity;
            gender.Text = member.gender;
            dateOfBirth.Text = member.date;
            mail.Text = member.email;
            phone.Text = member.phone;
            dateOfRegistration.Text = member.dateOfRegistration;
            imageMember.Image = (member.gender == "Erkek") ? imageMember.Image = Properties.Resources.male : imageMember.Image = Properties.Resources.female;
        }





        public Members()
        {
            InitializeComponent();
        }


    }
}
