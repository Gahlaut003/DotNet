namespace RoomBooking_SOLID_Examples
{
    public class PayPalPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("PayPal Payment: " + amount);
        }
    }
}