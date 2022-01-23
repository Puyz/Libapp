using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libapp.Pages.ShelfPages;
using Libapp.Functions;
using Libapp.Pages;
using Libapp.Models;

namespace Libapp.UI
{
    public partial class infoShelf : UserControl
    {
        Shelfs functions = new Shelfs();
        Shelf shelf = new Shelf();
        Logs functionsLogs = new Logs();
        public infoShelf(Shelf shelf)
        {
            InitializeComponent();
            this.shelf = shelf;
        }
        private void progressBar_MouseEnter(object sender, EventArgs e)
        {
            labelName.BackColor = Color.FromArgb(220,220,220);
        }

        private void progressBar_MouseLeave(object sender, EventArgs e)
        {
            labelName.BackColor = Color.White;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"{shelf.name} adlı rafı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                functions.deleteShelf(shelf);
                functionsLogs.addLog($"{shelf.name} adlı raf silindi.");
                MessageBox.Show("Raf silindi.");
                Main main = (Main)Application.OpenForms["Main"];
                main.addOrEdit.aoeShelfs.refresh();
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditShelf editShelf = new EditShelf(shelf);
            editShelf.ShowDialog();
        }

       

        
    }
}
