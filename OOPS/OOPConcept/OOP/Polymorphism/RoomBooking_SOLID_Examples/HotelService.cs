namespace RoomBooking_SOLID_Examples
{
    public class HotelService{
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IAuthentication _authentication;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IDataSaver _dataSaver;
        private readonly INotification _notification;
        private readonly IRoomBooking _roomBooking;

        public HotelService(IRoomBooking roomBooking,IPaymentProcessor paymentProcessor, IAuthentication authetication, IDataSaver dataSaver, INotification notification){
            _paymentProcessor = paymentProcessor;
            _authentication = authetication;
            _dataSaver = dataSaver;
            _notification = notification;
            _roomBooking = roomBooking;
        }

        public void BookRoom(string username, string password, int roomType,decimal amount){
            if(_authentication.Authentication(username,password)){
                _roomBooking.BookRoom(roomType);
                _paymentProcessor.ProcessPayment(amount);
                _dataSaver.SaveData($"Room Booked: {username}, Room Type: {roomType}, Amount: {amount}");
                _notification.SendNotification(username, "Room Booked");
            }
            else {
                Console.WriteLine("Authentication failed");
            }
        }

    }
}