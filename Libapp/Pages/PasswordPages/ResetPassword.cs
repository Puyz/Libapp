using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libapp.Database;

namespace Libapp.Pages.PasswordPages
{
    public partial class ResetPassword : DevExpress.XtraEditors.XtraForm
    {
        BaseDatabaseManager Database = new MySqlDatabaseManager();
        string mail;
        int id;
        public ResetPassword(string mail)
        {
            InitializeComponent();
            this.mail = mail;
            id = Database.getId(mail);
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textSifre.Text)))
            {
                Database.resetPassword(id, textSifre.Text);
                MessageBox.Show("Şifreniz yenilendi.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");
            }
        }
    }
}
