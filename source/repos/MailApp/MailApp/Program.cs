using System;
using MimeKit;
using MailKit;
using MailKit.Net.Smtp;

namespace MailApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("roheem", "roheemlateef.3@gmail.com"));

            message.To.Add(MailboxAddress.Parse("roheemlateef.3@gmail.com"));

            message.Subject = "Notification";


            message.Body = new TextPart("Plain")
            {
                Text = @" Hello,
                        Notification on your event."
                    
            };

            Console.WriteLine("Email:");
            string emailaddress = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();  
            
            SmtpClient client = new SmtpClient();

            try
            {
                client.Connect("smtp.gmail.com", 465, true);

                client.Authenticate(emailaddress, password); 
                client.Send(message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
            Console.ReadLine();


        }
    }
}
