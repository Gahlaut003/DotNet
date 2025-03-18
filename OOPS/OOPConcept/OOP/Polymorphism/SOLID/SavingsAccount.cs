
namespace BankingServices
{
public class SavingsAccount:IBankAccount{
private decimal balance;
private readonly ILogger _logger;
public SavingsAccount(ILogger logger){
    _logger = logger;
}
    
 public void deposit(decimal amount){
    balance += amount;
    _logger.LogError($"Depositing {amount} to Savings Account");
 
}

public void withdraw(decimal amount){
    if (balance < amount){
        _logger.LogError("Insufficient funds");
        return;
    }
    else if (balance >= amount){
        balance -= amount;
        _logger.LogError($"Withdrawing {amount} from Savings Account");
    }
   
}


}
}