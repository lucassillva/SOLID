using SOLID.DIP.Common;

namespace SOLID.DIP.Correct;

public class InvoiceGenerator
{
    private readonly IList<IActionAfterGenerateInvoice> _actions;

    public InvoiceGenerator(IList<IActionAfterGenerateInvoice> actions)
    {
        _actions = actions;
    }

    public Invoice Generate(double value)
    {
        var invoice = new Invoice(value, value * 0.06);

        foreach (var action in _actions)
            action.Execute(invoice);

        return invoice;
    }
}

public interface IActionAfterGenerateInvoice
{
    void Execute(Invoice invoice);
}

public class EmailSender : IActionAfterGenerateInvoice
{
    public void Execute(Invoice invoice)
    {
    }
}

public class InvoiceDao : IActionAfterGenerateInvoice
{
    public void Execute(Invoice invoice)
    {
    }
}