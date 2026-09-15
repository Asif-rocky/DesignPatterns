namespace DesignPatterns.src.OopPrinciples.Coupling
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            // Logic to send SMS notification
            Console.WriteLine($"Sending SMS notification: {message}");
        }
    }
}
