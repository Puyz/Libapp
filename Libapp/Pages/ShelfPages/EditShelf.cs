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
    public partial class EditShelf : DevExpress.XtraEditors.XtraForm
    {
        Shelfs functions = new Shelfs();
        Shelf shelf = new Shelf();
        Logs functionsLogs = new Logs();
        private int oldCapacity;
        public EditShelf(Shelf shelf)
        {
            InitializeComponent();
            this.shelf = shelf;
        }

        private void textShelfName_TextChanged(object sender, EventArgs e)
        {
            infoShelf.labelName.Text = textShelfName.Text;
        }

        private void textCapacity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newCapacity = Convert.ToInt32(textCapacity.Text);
                int fullness = Convert.ToInt32(textFullness.Text);

                int colorCalculator75 = newCapacity * 75 / 100;
                int colorCalculator25 = newCapacity * 25 / 100;
                infoShelf.progressBar.Maximum = newCapacity;
                infoShelf.progressBar.Value = fullness; // Doluluk

                if (fullness > colorCalculator25 && fullness <= colorCalculator75)
                    infoShelf.progressBar.ValueColor = Color.ForestGreen;
                else if (fullness <= colorCalculator25)
                    infoShelf.progressBar.ValueColor = Color.RoyalBlue;
                else
                    infoShelf.progressBar.ValueColor = Color.Tomato;

                infoShelf.labelValue.Text = fullness + "/" + newCapacity;
            }
            catch (Exception)
            {
               
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int newCapacity = Convert.ToInt32(textCapacity.Text);
            int fullness = Convert.ToInt32(textFullness.Text);

            if (!(string.IsNullOrWhiteSpace(textShelfName.Text) || string.IsNullOrWhiteSpace(textCapacity.Text)))
            {
                if ( !( fullness > newCapacity) )
                {
                    if (textShelfName.Text == shelf.name)
                    {
                        editShelf();
                    }
                    else
                    {
                        if (!functions.isShelfExists(textShelfName.Text))
                        {
                            editShelf();
                        }
                        else
                        {
                            MessageBox.Show("Böyle bir raf mevcut.");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Kapasite doluluktan küçük olamaz.");
                }


            }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");
            }
        }

        private void EditShelf_Load(object sender, EventArgs e)
        {

            fillInfoShelf();
            oldCapacity = shelf.capacity;
            textShelfName.Text = shelf.name;
            textFullness.Text = (shelf.capacity - shelf.free).ToString();
            textCapacity.Text = shelf.capacity.ToString();
        }

        private void fillInfoShelf()
        {
            int colorCalculator75 = shelf.capacity * 75 / 100;
            int colorCalculator25 = shelf.capacity * 25 / 100;
            int fullness = shelf.capacity - shelf.free;// Doluluk
            infoShelf.progressBar.Maximum = shelf.capacity;
            infoShelf.progressBar.Value = fullness;

            if (fullness > colorCalculator25 && fullness <= colorCalculator75)
                infoShelf.progressBar.ValueColor = Color.ForestGreen;
            else if (fullness <= colorCalculator25)
                infoShelf.progressBar.ValueColor = Color.RoyalBlue;
            else
                infoShelf.progressBar.ValueColor = Color.Tomato;

            infoShelf.labelName.Text = shelf.name;
            infoShelf.labelValue.Text = fullness + "/" + shelf.capacity;
        }

        private void editShelf()
        {
            shelf.capacity = Convert.ToInt32(textCapacity.Text);
            shelf.free = shelf.capacity - oldCapacity;
            shelf.name = textShelfName.Text;
            functions.editShelf(shelf);
            functionsLogs.addLog($"{shelf.name} adlı raf düzenlendi.");
            MessageBox.Show("Raf düzenlendi.");
            Main main = (Main)Application.OpenForms["Main"];
            main.addOrEdit.aoeShelfs.refresh();
            this.Close();
        }
    }
}
