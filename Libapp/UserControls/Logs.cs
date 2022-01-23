using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using Libapp.Functions;
using Libapp.Pages.LogPages;

namespace Libapp.UserControls
{
    public partial class Logs : UserControl
    {
        Functions.Logs functions = new Functions.Logs();
        public Logs()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            functions.clearDataGrid(ref gridControl);
            functions.fillDataGrid(ref gridControl);
            functions.fillLogsCbox(ref cBoxLogs);
            cBoxLogs.Text = null;
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void filterText_TextChanged(object sender, EventArgs e)
        {
            functions.filterData(filterText.Text, ref gridView);
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            refresh();
            functions.hideColumn(ref gridView);
            
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            functions.filterData(filterText.Text, ref gridView);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (gridView.DataRowCount != 0)
            {
                if (MessageBox.Show("Geçmişi kaydetmek istediğinizden emin misiniz? \nKayıttan sonra geçmiş silinir!", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    functions.saveLogs(ref gridView);
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("Kayıt edilecek herhangi bir geçmiş bulunamadı.");
            }
           
        }

        private void showLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cBoxLogs.Text))
                {
                    ShowLogs showLogs = new ShowLogs();
                    showLogs.Text = $"Geçmiş - {cBoxLogs.Text}";
                    showLogs.labelLogs.Text = File.ReadAllText("log\\" + cBoxLogs.Text, Encoding.UTF8);
                    showLogs.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dosya açılamadı.");
            }
        }

        private void deleteLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cBoxLogs.Text))
                {
                    if (MessageBox.Show("Geçmişi silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        File.Delete("log\\" + cBoxLogs.Text);
                        MessageBox.Show("Geçmiş silindi.");
                        refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçmiş silinemedi.");
            }
           
        }
    }
}
