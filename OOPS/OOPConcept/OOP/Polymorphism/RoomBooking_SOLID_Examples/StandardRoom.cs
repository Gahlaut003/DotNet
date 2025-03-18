namespace RoomBooking_SOLID_Examples
{
  
    public class StandardRoom : IRoomBooking
    {

        public void BookRoom(int roomNumber)
        {
            Console.WriteLine("Standard Room Booked: " + roomNumber);
        } 
    

        
    }
}