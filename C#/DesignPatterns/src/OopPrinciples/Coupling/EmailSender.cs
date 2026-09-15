namespace DesignPatterns.src.OopPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            // Logic to send email notification
            Console.WriteLine($"Sending email notification: {message}");
        }
    }
}
