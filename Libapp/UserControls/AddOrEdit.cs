using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libapp.UserControls
{
    public partial class AddOrEdit : UserControl
    {

        public AddOrEdit()
        {
            InitializeComponent();
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            aoeBooks.Visible = true;
            aoeMembers.Visible = false;
            aoeShelfs.Visible = false;
            aoeBooks.refresh();
        }

        private void membersButton_Click(object sender, EventArgs e)
        {
            aoeMembers.Visible = true;
            aoeBooks.Visible = false;
            aoeShelfs.Visible = false;
            aoeMembers.refresh();
        }

        private void shelfsButton_Click(object sender, EventArgs e)
        {
            aoeShelfs.Visible = true;
            aoeBooks.Visible = false;
            aoeMembers.Visible = false;
            aoeShelfs.refresh();
        }
    }
}
