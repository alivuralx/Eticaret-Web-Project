using Eticaret.Core.Entities;
using System.Net;
using System.Net.Mail;


namespace EticaretWebUI.Utils
{
    public class MailHelper
    {
        public static async Task<bool> SendMailAsync(Contact contact)
        {
            SmtpClient smtpClient = new SmtpClient("alivuralq@gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("alivuralq@gmail.com", "mailşifre");
            smtpClient.EnableSsl = false;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("alivuralq@gmail.com");
            message.To.Add("alivuralq@gmail.com");
            message.Subject = "Siteden mesaj geldi";
            message.Body = $"isim: {contact.Name} - Soyisim: {contact.Surname} - Email: {contact.Email}  - Phone: {contact.Phone} - Mesaj: {contact.Message}";
            message.IsBodyHtml = true;
            try
            {
                await smtpClient.SendMailAsync(message);
                smtpClient.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static async Task<bool> SendMailAsync(string email, string subject, string mailBody)
        {
            SmtpClient smtpClient = new SmtpClient("alivuralq@gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("alivuralq@gmail.com", "mailşifre");
            smtpClient.EnableSsl = false;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("alivuralq@gmail.com");
            message.To.Add(email);
            message.Subject = subject;
            message.Body = mailBody;
            message.IsBodyHtml = true;
            try
            {
                await smtpClient.SendMailAsync(message);
                smtpClient.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
