namespace RoomBooking_SOLID_Examples
{
    public class SQLDatabase : IDataSaver
    {
        public void SaveData(string data)
        {
            Console.WriteLine("Data saved to SQL database: " + data);
        }
    }
}