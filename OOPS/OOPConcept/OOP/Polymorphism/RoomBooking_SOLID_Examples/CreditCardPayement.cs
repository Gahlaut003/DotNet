namespace RoomBooking_SOLID_Examples
{
    public class CreditCardPayement : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Credit Card Payment: " + amount);
        }
    }
}