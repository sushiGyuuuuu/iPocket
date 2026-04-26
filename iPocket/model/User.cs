public class User
{
    public int UserId{get; set;}
    public string Name{get; set;}
    public string Email{get; set;}

    public SavingsAccount Account{get; private set;}

    public void CreateAccount(decimal initialDeposit)
    {
        Account = new SavingsAccount(initialDeposit);
    }

    public double ViewBalance()
    {
        return (double)(Account?.Balance ?? 0);
    }
}