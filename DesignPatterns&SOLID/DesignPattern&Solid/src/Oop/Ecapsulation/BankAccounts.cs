using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApp1.src.Oop.Encapsulation{

public class BankAccount{
private decimal balance;


public decimal GetBalance(){
    return balance;
}
public BankAccount(decimal balance){

    Deposit(balance);
}

public void Deposit(decimal amount){
if (amount <= 0){
    throw new ArgumentException("Deposit amount must be greater than 0");
}
this.balance += amount;

}

public void Withdraw(decimal amount){

    if (amount <=0){
        throw new ArgumentException("Withdrawal amount must be +ve");
    }

    if (amount > balance){
        throw new InvalidOperationException("Invalid Operartion");
    }
    this.balance -= amount; 
}
}

}