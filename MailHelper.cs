using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyBestBuddy
{
    public static class MailHelper
    {
        public static void SendMail(string emailAddresses, string from, string subject, string body)
        {
            string email = ConfigurationManager.AppSettings["emailAddress"];
            string password = ConfigurationManager.AppSettings["emailPassword"];
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(email, from);
            emailAddresses?.Split(';').ToList().ForEach(x => mail.Bcc.Add(x));
            mail.Subject = subject;
            mail.Body = body;

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            //mail.Attachments.Add(attachment);

            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential(email, password);
            smtpServer.EnableSsl = true;
            smtpServer.Send(mail);
        }
    }
}
