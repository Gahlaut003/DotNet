namespace BankingServices
{
public interface IBankAccount {
    void deposit(decimal amount);
    void withdraw(decimal amount);
    //double getBalance();
}
}