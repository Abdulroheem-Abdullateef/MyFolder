
using MailKit.Net.Smtp;
using MimeKit;

namespace ApiProject.SendingMessages
{
    public class MailMessage : IMailMessage
    {
        public void SendingMail(string ReceivingEmail, string MessageBody, string MessageContent)
        {
           MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("VirtualHealthApp", "olaide@gmail.com"));
            message.To.Add(MailboxAddress.Parse(ReceivingEmail));
            message.Subject = MessageContent;
            message.Body = new TextPart("html")
            {
              Text = MessageBody
            };
            string email = "virtualhealthapp@gmail.com";
            string password = "CodeLearnersBatch6";
            SmtpClient client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(email,password);
                client.Send(message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }
    }
}