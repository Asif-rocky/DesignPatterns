namespace DesignPatterns.src.OopPrinciples.Encapsulation;

public class BankAccount(decimal amount)
{
    private decimal balance = amount;

    public decimal GetBalance()
    {
        return this.balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative");
        }
        this.balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount cannot be negative");
        }
        if (amount > this.balance)
        {
            throw new ArgumentException("Insufficient funds");
        }
        this.balance -= amount;
    }
}

// Example usage:
//BankAccount bankAccount = new(100);

//Console.WriteLine(bankAccount.GetBalance());

//bankAccount.Deposit(50);
//Console.WriteLine(bankAccount.GetBalance());

//bankAccount.Withdraw(200);
//Console.WriteLine(bankAccount.GetBalance());
