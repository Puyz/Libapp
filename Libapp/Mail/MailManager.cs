using System;
using System.Net.Mail;
using System.Xml;

namespace Libapp.Mail
{
    class MailManager
    {
        public void SendCodeToMail(string toMail, int code, string subject)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("noname@puyz.net", "Puyz® Bilişim");
            mailMessage.To.Add(toMail);
            mailMessage.Subject = subject;
            mailMessage.Body = "Doğrulama kodun: " + code;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("noname@puyz.net", "pass");
            smtp.Host = "mail.puyz.net";
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(mailMessage);
        }

        public void SendPasswordToMail(string toMail, string password, string subject)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("noname@puyz.net", "Puyz® Bilişim");
            mailMessage.To.Add(toMail);
            mailMessage.Subject = subject;
            mailMessage.Body = "Email: " + toMail+"\nŞifre: "+password;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("noname@puyz.net", "pass");
            smtp.Host = "mail.puyz.net";
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(mailMessage);
        }

        public int RandomCode()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
            
        }

        public int RandomPassword()
        {
            Random random = new Random();
            return random.Next(1000, 999999);
        }
    }
}
