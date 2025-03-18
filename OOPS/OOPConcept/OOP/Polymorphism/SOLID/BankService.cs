namespace BankingServices
{

public class BankService{

    private IBankAccount _bankAccount;
    private IAuthentication _authentication;
    private IDataSaver _dataSave;

    public BankService(IBankAccount bankAccount, IAuthentication authentication, IDataSaver dataSave){
        _bankAccount = bankAccount;
        _authentication = authentication;
        _dataSave = dataSave;
    }

    public void PerformTransaction(string username, string password, decimal amount, bool isDeposit){
        if(_authentication.Authenticate(username, password)){
            if(isDeposit){
                _bankAccount.deposit(amount);
            }
            else{
                _bankAccount.withdraw(amount);
                _dataSave.SaveData( $"Transaction: {username}, Amount: {amount}");
            }
        }
        else{
            Console.WriteLine("Authentication failed");
        }
    }
}   

}