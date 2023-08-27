using SOLID.DIP.Common;

namespace SOLID.DIP.Incorrect;

public class InvoiceGenerator
{
    private readonly InvoiceDao _invoiceDao;
    private readonly EmailSender _emailSender;

    public InvoiceGenerator(InvoiceDao invoiceDao, EmailSender emailSender)
    {
        _invoiceDao = invoiceDao;
        _emailSender = emailSender;
    }

    public Invoice Generate(double value)
    {
        var invoice = new Invoice(value, value * 0.06);

        _emailSender.Send(invoice);
        _invoiceDao.Save(invoice);

        return invoice;
    }
}

// Acoplamento com InvoiceDao e EmailSender, ou seja, detalhes
// Mudanças podem propagar problemas para InvoiceGenerator

public class EmailSender
{
    public void Send(Invoice invoice)
    {
    }
}

public class InvoiceDao
{
    public void Save(Invoice invoice)
    {
    }
}