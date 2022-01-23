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
using Libapp.Pages.PasswordPages;
using Libapp.Pages.MemberPages;
using Libapp.Pages;
using Libapp.Models;
using Libapp.Functions;

namespace Libapp.Mail
{
    public partial class MailVerify : DevExpress.XtraEditors.XtraForm
    {
        BaseDatabaseManager dataBase = new MySqlDatabaseManager();
        Members functions = new Members();
        MailManager mailManager = new MailManager();
        Member member;
        Logs functionsLogs = new Logs();

        int right = 3;
        private int authority;
        private string method;
        private int code;
        private string email;

        private void SendMailBW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string subject = "Doğrulama kodu";
                mailManager.SendCodeToMail(email, code, subject);
            }
            catch { MessageBox.Show("Üzgünüz, şu anda kodunuzu gönderemiyoruz."); this.Close(); }
        }



        public MailVerify(Member member, int authority)
        {
            InitializeComponent();
            method = "New Account";
            this.member = member;
            this.authority = authority;
            code = mailManager.RandomCode();
            this.email = member.email;
            SendMailBW.RunWorkerAsync();
        }

        public MailVerify(string mail)
        {
            InitializeComponent();
            method = "Reset Password";
            this.email = mail;
            code = mailManager.RandomCode();
            SendMailBW.RunWorkerAsync();
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (code == Convert.ToInt32(textCode.Text))
                {
                    if (method == "New Account")
                    {
                        try
                        {
                            AddMember addMember = (AddMember)Application.OpenForms["AddMember"];
                            Main main = (Main)Application.OpenForms["Main"];
                            functions.addMember(member,authority);
                            functionsLogs.addLog($"{member.name} adlı yeni üye eklendi.");
                            MessageBox.Show("Üye oluşturuldu.");
                            MessageBox.Show("Üye giriş bilgileri mail tarafından bilgilendirildi.");
                            main.addOrEdit.aoeMembers.refresh();
                            addMember.Close();
                            this.Close();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show("Üye oluşturulurken hata oluştu." + exception.Message);
                            this.Close();
                        }
                    }
                    else if (method == "Reset Password")
                    {
                        ResetPassword resetPassword = new ResetPassword(email);
                        resetPassword.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    right--;
                    MessageBox.Show($"Hatalı kod girdiniz.\nDeneme hakkınız: {right}");
                    if (right == 0)
                    {
                        this.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                right--;
                MessageBox.Show($"Hatalı kod girdiniz.\nDeneme hakkınız: {right}");
                if (right == 0)
                {
                    this.Dispose();
                }

            }
            
        }
    }
}
