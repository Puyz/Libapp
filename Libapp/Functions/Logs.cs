using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libapp.Database;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Windows;
using System.Data;
using DevExpress.XtraEditors;

namespace Libapp.Functions
{
    class Logs
    {
        BaseDatabaseManager dataBase = new MySqlDatabaseManager();

        public void clearDataGrid(ref GridControl gridControl)
        {
            gridControl.DataSource = null;
        }
        public void fillDataGrid(ref GridControl gridControl)
        {
            gridControl.DataSource = dataBase.logsGridDataSource();
        }
        public void hideColumn(ref GridView gridView)
        {
            gridView.Columns["id"].Visible = false;

            //çizgi
            gridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
        }
        public void filterData(string data, ref GridView gridView)
        {
            gridView.ActiveFilterString = $"olay LIKE '%{data}%' OR tarih LIKE '%{data}%'";
        }
        public void addLog(string log)
        {
            dataBase.addLog(log);
        }
        public void fillLogsCbox(ref ComboBoxEdit comboBox)
        {
            comboBox.Properties.Items.Clear();
            DirectoryInfo fileinfo = new DirectoryInfo("log\\");
            foreach (FileInfo item in fileinfo.GetFiles())
            {
                comboBox.Properties.Items.Add(item);
            }
        }
        public void saveLogs(ref GridView gridView)
        {
            try
            {
                StreamWriter streamWriter;
                string filename = DateTime.Now.ToShortDateString();
                string dirname = "log\\";
                if (File.Exists($"{dirname}{filename}.txt"))
                {
                    MessageBox.Show("Aynı gün içinde birden fazla kayıt yapılamaz.");
                }
                else
                {
                    streamWriter = File.CreateText($"{dirname}{filename}.txt");
                    streamWriter.Close();
                    streamWriter = new StreamWriter($"{dirname}{filename}.txt");

                    foreach (DataRow item in dataBase.logsGridDataSource().Rows)
                    {
                        string date = item["tarih"].ToString();
                        string log = item["olay"].ToString();
                        streamWriter.WriteLine($"Tarih: {date} - Olay: {log} \n");
                    }
                    streamWriter.Close();
                    dataBase.deteleLogs();
                    MessageBox.Show("Başarıyla kaydedildi.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçmiş kaydedilemedi.");
            }
        }

    }
}
