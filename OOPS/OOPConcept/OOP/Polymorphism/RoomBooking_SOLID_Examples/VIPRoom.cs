namespace RoomBooking_SOLID_Examples
{
    public class VIPRoom : IRoomBooking
    {
        public void BookRoom(int roomNumber)
        {
            Console.WriteLine("VIP Room Booked");
        }
    }
}