namespace ApiProject.SendingMessages
{
    public interface IMailMessage
    {
         void SendingMail(string ReceivingEmail, string MessageBody, string MessageContent);
    }
}