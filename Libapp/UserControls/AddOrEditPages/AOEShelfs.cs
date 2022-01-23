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
using Libapp.Pages.ShelfPages;

namespace Libapp.UserControls.AddOrEditPages
{
    public partial class AOEShelfs : UserControl
    {
        Shelfs functionsShelfs = new Shelfs();   
        public AOEShelfs()
        {
            InitializeComponent();
        }

        private void bwShelfs_DoWork(object sender, DoWorkEventArgs e)
        {
            functionsShelfs.listShelfs(shelfsPanel);
        }

        private void AOEShelfs_Load(object sender, EventArgs e)
        {
            bwShelfs.RunWorkerAsync();
        }
        public void refresh()
        {
            shelfsPanel.Controls.Clear();
            if (!bwShelfs.IsBusy)
            {
                bwShelfs.RunWorkerAsync();
            }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                shelfsPanel.Controls.Clear();
                if (!bwShelfs.IsBusy)
                {
                    bwFilterShelfs.RunWorkerAsync();
                }
            }
            catch (Exception){}
           
        }

        private void bwFilterShelfs_DoWork(object sender, DoWorkEventArgs e)
        {
            functionsShelfs.filterData(shelfsPanel,filterText.Text);
        }

        private void filterText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    shelfsPanel.Controls.Clear();
                    if (!bwShelfs.IsBusy)
                    {
                        bwFilterShelfs.RunWorkerAsync();
                    }
                }
            }
            catch (Exception){}
           
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddShelf addShelf = new AddShelf();
            addShelf.ShowDialog();
        }
    }
}
