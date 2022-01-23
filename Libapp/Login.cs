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
using Libapp.Pages;
using Libapp.Pages.PasswordPages;
using Libapp.Models;

namespace Libapp
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        BaseDatabaseManager database = new MySqlDatabaseManager();
        MemberLogin memberLogin = new MemberLogin();
        
        public Login()
        {
            InitializeComponent();
        }

      

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            memberLogin.email = textEmail.Text.Trim();
            memberLogin.password = textSifre.Text;
            if (!(string.IsNullOrWhiteSpace(memberLogin.email) || string.IsNullOrWhiteSpace(memberLogin.password)))
            {
                if (database.isUserExists(memberLogin))
                {
                    Member member = database.GetMemberFromMemberLogin(memberLogin);
                    int authortiy = database.GetAuthority(memberLogin);
                    if (authortiy != 1)
                    {
                        Main main = new Main(member);
                        main.authority = authortiy;
                        main.Show();
                    }
                    else
                    {
                        MainMember mainMember = new MainMember(member);
                        mainMember.Show();
                    }
                   
                    this.Hide();
                }
                else { MessageBox.Show("Email veya şifre hatalı."); }
            }
            else { MessageBox.Show("Lütfen boş bırakmayınız."); }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
