using System;
using System.Data;
using Libapp.Database;
using DevExpress.XtraEditors;
using Libapp.UI;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using Libapp.Models;

namespace Libapp.Functions
{
    class Shelfs
    {
        BaseDatabaseManager dataBase = new MySqlDatabaseManager();
        
        public bool isShelfExists(string name)
        {
           return dataBase.isShelfExists(name);
        }
        public void cboxFillShelfs(ref ComboBoxEdit cbox)
        {
            foreach (DataRow item in dataBase.fillShelfs().Rows)
            {
                if (!(Convert.ToInt32(item["eklenebilirKitapSayisi"]) <= 0))
                {
                    cbox.Properties.Items.Add(item["rafAdi"] + " rafına eklenebilir kitap sayısı: " + item["eklenebilirKitapSayisi"]);
                }
            }
        }
        public void shelfDeValue(Shelf shelf)
        {
            dataBase.shelfDeValue(shelf);
        }
        public void shelfReValue(Shelf shelf)
        {
            dataBase.shelfReValue(shelf);
        }
        public void listShelfs(FlowLayoutPanel panelShelfs)
        {
            try
            {
                foreach (DataRow item in dataBase.fillShelfs().Rows)
                {
                    Shelf shelf = new Shelf();
                    shelf.id = Convert.ToInt32(item["id"]);
                    shelf.name= item["rafAdi"].ToString();
                    shelf.capacity= Convert.ToInt32(item["kapasite"]);
                    shelf.free = Convert.ToInt32(item["eklenebilirKitapSayisi"]);
                    infoShelf infoShelf = new infoShelf(shelf);
                  
                    int colorCalculator75 = shelf.capacity * 75 / 100;
                    int colorCalculator25 = shelf.capacity * 25 / 100;
                    

                    int fullness = shelf.capacity - shelf.free;

                        panelShelfs.Invoke( (MethodInvoker)delegate {
                            infoShelf.progressBar.Maximum = shelf.capacity;
                            infoShelf.progressBar.Value = fullness; // Doluluk

                            if (fullness > colorCalculator25 && fullness <= colorCalculator75)
                                infoShelf.progressBar.ValueColor = Color.ForestGreen; 
                            else if(fullness <= colorCalculator25)
                                infoShelf.progressBar.ValueColor = Color.RoyalBlue; 
                            else
                                infoShelf.progressBar.ValueColor = Color.Tomato;


                            infoShelf.labelName.Text = shelf.name;
                            infoShelf.labelValue.Text = fullness + "/" + shelf.capacity;

                            infoShelf.Dock = DockStyle.Top;
                            panelShelfs.Controls.Add(infoShelf);
                        });
                    
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
            }
           
           
        }
        public void filterData(FlowLayoutPanel panelShelfs, string filterName)
        {
            try
            {

                foreach (DataRow item in dataBase.filterShelfs(filterName).Rows)
                {
                    Shelf shelf = new Shelf();
                    shelf.id = Convert.ToInt32(item["id"]);
                    shelf.name = item["rafAdi"].ToString();
                    shelf.capacity = Convert.ToInt32(item["kapasite"]);
                    shelf.free = Convert.ToInt32(item["eklenebilirKitapSayisi"]);
                    infoShelf infoShelf = new infoShelf(shelf);

                    int colorCalculator75 = shelf.capacity * 75 / 100;
                    int colorCalculator25 = shelf.capacity * 25 / 100;


                    int fullness = shelf.capacity - shelf.free;

                    panelShelfs.Invoke((MethodInvoker)delegate {
                        infoShelf.progressBar.Maximum = shelf.capacity;
                        infoShelf.progressBar.Value = fullness; // Doluluk

                        if (fullness > colorCalculator25 && fullness <= colorCalculator75)
                            infoShelf.progressBar.ValueColor = Color.ForestGreen;
                        else if (fullness <= colorCalculator25)
                            infoShelf.progressBar.ValueColor = Color.RoyalBlue;
                        else
                            infoShelf.progressBar.ValueColor = Color.Tomato;


                        infoShelf.labelName.Text = shelf.name;
                        infoShelf.labelValue.Text = fullness + "/" + shelf.capacity;

                        infoShelf.Dock = DockStyle.Top;
                        panelShelfs.Controls.Add(infoShelf);
                    });

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        public void addShelf(Shelf shelf)
        {
            dataBase.addShelf(shelf);
        }
        public void editShelf(Shelf shelf)
        {
            dataBase.editShelf(shelf);
        }
        public void deleteShelf(Shelf shelf)
        {
            dataBase.deleteShelf(shelf);
        }
    }
}
