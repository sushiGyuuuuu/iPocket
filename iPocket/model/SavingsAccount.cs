public class SavingsAccount
{
    private decimal balance;
    private decimal interestRate;
    private int year;

    private InterestManager interestManager;

    public decimal Balance => balance;
    public decimal InterestRate => interestRate;

    public SavingsAccount(decimal initialDeposit)
    {
        balance = initialDeposit;
        interestManager = new InterestManager();
        year = 1;
        interestRate = (decimal)interestManager.GetAnnualRate(year);
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new Exception("Invalid amount.");

        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > balance)
            throw new Exception("Invalid withdrawal.");

        balance -= amount;
    }

    public void ApplyInterest()
    {
        decimal interest = balance * interestRate;
        balance += interest;

        year++;
        interestRate = (decimal)interestManager.GetAnnualRate(year);
    }

    public void SendMoney(decimal amount, SavingsAccount recipient)
    {
        Withdraw(amount);
        recipient.Deposit(amount);
    }
}