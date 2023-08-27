using SOLID.ISP.Common;

namespace SOLID.ISP.Correct;

public interface ITaxCalculator
{
    double GenerateTax(double value);
}

public interface IInvoiceGenerator
{
    Invoice GenerateInvoce();
}

public class Iss : ITaxCalculator, IInvoiceGenerator
{
    public double GenerateTax(double value) => value * 0.1;

    public Invoice GenerateInvoce() => new Invoice();
}

public class Ixmx : ITaxCalculator
{
    public double GenerateTax(double value) => value * 0.2;
}