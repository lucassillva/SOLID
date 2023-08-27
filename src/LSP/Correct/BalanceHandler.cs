namespace SOLID.LSP.Correct;

public class BalanceHandler
{
    public double Balance { get; private set; }

    public void Add(double value)
    {
        if (value <= 0) throw new ArgumentOutOfRangeException();
        Balance += value;
    }

    public void Remove(double value)
    {
        if (value <= 0) throw new ArgumentOutOfRangeException();
        Balance -= value;
    }

    public void Yield(double tax) => Balance *= 1 + tax;
}