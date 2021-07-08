using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace TrackerLibrary
{
    public static class EmailLogic
    {

        public static void SendEmail(string to, string subject, string body)
        {
            MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.AppKeyLookup("senderDisplayName"));

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("tomaszkuzmadark@interia.pl");
            //client.EnableSsl = true;
            //client.Port = 25;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.Credentials = new NetworkCredential(fromMailAddress.ToString(), "testing"); ;
            //client.Send(mail);

        }
    }
}
