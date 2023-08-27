namespace SOLID.LSP.Correct;

public class CommonAccount
{
    private readonly BalanceHandler _balanceHandler;

    public CommonAccount()
    {
        _balanceHandler = new BalanceHandler();
    }

    public void Deposit(double value) => _balanceHandler.Add(value);

    public void Withdraw(double value) => _balanceHandler.Remove(value);

    public void Yield() => _balanceHandler.Yield(0.1);
}

public class StudentAccount
{
    private readonly BalanceHandler _balanceHandler;

    public StudentAccount()
    {
        _balanceHandler = new BalanceHandler();
    }

    public void Deposit(double value) => _balanceHandler.Add(value);

    public void Withdraw(double value) => _balanceHandler.Remove(value);

    // Doesn't implement the 'Yield' method.
}