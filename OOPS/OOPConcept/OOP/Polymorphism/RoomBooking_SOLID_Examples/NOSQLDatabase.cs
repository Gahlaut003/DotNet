namespace RoomBooking_SOLID_Examples
{
    public class NOSQLDatabase : IDataSaver
    {
        public void SaveData(string data)
        {
            Console.WriteLine("Data saved to NOSQL database");
        }
    }
}