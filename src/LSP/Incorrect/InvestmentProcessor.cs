namespace SOLID.LSP.Incorrect;

public class InvestmentProcessor
{
    public void Process(IEnumerable<CommonAccount> accounts)
    {
        foreach (var account in accounts)
        {
            account.Yield();
            Console.WriteLine($"New Balance: {account.Balance}");
        }
    }
}

public class CommonAccount
{
    public double Balance { get; protected set; }

    public CommonAccount() => Balance = 0;

    public void Deposit(double value)
    {
        if (value <= 0) throw new ArgumentOutOfRangeException();

        Balance += value;
    }

    public virtual void Yield() => Balance *= 1.1;
}

public class StudentAccount : CommonAccount
{
    public override void Yield()
    {
        throw new NotSupportedException();
    }
}

// InvestmentProcessor não sabe que existem contas que não rendem. Uma exceção será lançada
// A classe StudentAccount "quebrou" o contrato definido pela classe CommonAccount