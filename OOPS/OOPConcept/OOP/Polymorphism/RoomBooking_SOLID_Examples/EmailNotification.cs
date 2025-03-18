namespace RoomBooking_SOLID_Examples
{
    public class EmailNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Email Notification: " + message);
        }
    }
}