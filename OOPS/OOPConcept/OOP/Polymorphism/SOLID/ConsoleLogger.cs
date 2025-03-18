namespace BankingServices
{

public class ConsoleLogger:ILogger{
    public void LogError(string message){
        Console.WriteLine(message);
    }

}}