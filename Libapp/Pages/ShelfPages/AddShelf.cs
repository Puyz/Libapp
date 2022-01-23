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

namespace Libapp.Pages.ShelfPages
{
    public partial class AddShelf : DevExpress.XtraEditors.XtraForm
    {
        Shelfs functions = new Shelfs();
        Shelf shelf = new Shelf();
        Logs functionsLogs = new Logs();
        public AddShelf()
        {
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            shelf.name = textShelfName.Text.Trim();
            shelf.capacity = Convert.ToInt32(textCapacity.Text);
            if (!(string.IsNullOrWhiteSpace(shelf.name) || string.IsNullOrWhiteSpace( shelf.capacity.ToString() )))
            {
                if (!functions.isShelfExists(shelf.name))
                {
                    
                    functions.addShelf(shelf);
                    functionsLogs.addLog($"{shelf.name} adlı yeni raf eklendi.");
                    MessageBox.Show("Raf eklendi.");
                    Main main = (Main)Application.OpenForms["Main"];
                    main.addOrEdit.aoeShelfs.refresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Böyle bir raf mevcut.");
                }
               
            }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");
            }

        }

        private void textShelfName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ':') e.Handled = true;
        }
    }
}
