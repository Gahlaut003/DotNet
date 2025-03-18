namespace BankingServices
{
   public class SQLDatabase : IDataReader,IDataSaver{

    public void Read(){
        Console.WriteLine("Reading data from SQL Database");
    }

    public void SaveData(string data){
        Console.WriteLine("Saving data to SQL Database");
    }
   }
}