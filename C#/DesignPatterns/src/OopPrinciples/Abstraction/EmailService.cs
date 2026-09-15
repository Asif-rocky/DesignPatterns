namespace DesignPatterns.src.OopPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            ConnectToSmtpServer();
            Authenticate();

            // Logic to send email
            Console.WriteLine($"Sending email ....");

            DisconnectFromSmtpServer();
        }

        private void ConnectToSmtpServer()
        {
            // Logic to connect to SMTP server
            Console.WriteLine($"Connecting to SMTP server ....");
        }

        private void Authenticate()
        {
            // Logic to authenticate with SMTP server
            Console.WriteLine($"Authenticating with SMTP server ....");
        }

        private void DisconnectFromSmtpServer()
        {
            // Logic to disconnect from SMTP server
            Console.WriteLine($"Disconnecting from SMTP server ....");
        }
    }
}
