namespace RoomBooking_SOLID_Examples
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}