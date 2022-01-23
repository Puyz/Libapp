using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libapp.UserControls.MainMember
{
    public partial class MyBooks : UserControl
    {
        Functions.Books functions = new Functions.Books();
        public int teID;
        public MyBooks()
        {
            InitializeComponent();
        }

        private void bwMyBooks_DoWork(object sender, DoWorkEventArgs e)
        {
            if (functions.ControlListMyBooks(teID))
            {
                functions.ListMyBooks(panelMyBooks, teID);
                emptyPanel.Invoke((MethodInvoker)delegate {
                    emptyPanel.Visible = false; panelMyBooks.Visible = true;
                });
                
            }
            else
            {
                emptyPanel.Invoke((MethodInvoker)delegate {
                    emptyPanel.Visible = true; panelMyBooks.Visible = false;
                });
                
            }
            
        }

        private void MyBooks_Load(object sender, EventArgs e)
        {

            bwMyBooks.RunWorkerAsync();
        }
    }
}
