namespace BankingServices
{

public class NOSQLDatabase : IDataSaver{

void IDataSaver.SaveData(string data){
    //Save data to NOSQL database
    System.Console.WriteLine("Data saved to NOSQL database");
}   

}
}