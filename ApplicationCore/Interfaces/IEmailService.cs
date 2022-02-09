namespace Edgias.Elections.ApplicationCore.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail(string recipientEmail, string subject, string body);

        bool SendEmail(IEnumerable<string> recipientsEmails, string subject, string body);
    }
}
