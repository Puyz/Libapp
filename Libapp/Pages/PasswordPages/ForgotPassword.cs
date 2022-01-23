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
using Libapp.Mail;


namespace Libapp.Pages.PasswordPages
{
    public partial class ForgotPassword : DevExpress.XtraEditors.XtraForm
    {
        BaseDatabaseManager Database = new MySqlDatabaseManager();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void sendCodeButton_Click(object sender, EventArgs e)
        {
            if (!this.textEmail.Text.Contains('@') || !this.textEmail.Text.Contains('.')) // Email için @ ve . kontrolü
            {
                MessageBox.Show("Lütfen geçerli email giriniz", "Geçersiz email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Database.emailControl(textEmail.Text)) // Email kontrolü
                {
                    MailVerify mailVerify = new MailVerify(textEmail.Text);
                    mailVerify.stepProgress.Items.Add("");
                    mailVerify.ShowDialog();
                    this.Close();
                }
                else { MessageBox.Show("Kayıtlı mail bulunamadı"); }

            }
        }
    }
}
