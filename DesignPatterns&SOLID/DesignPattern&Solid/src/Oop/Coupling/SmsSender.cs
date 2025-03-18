namespace ConsoleApp1.Coupling{


    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending Sms: "+message);
    }
        }
    }
