using SOLID.OCP.Common;

namespace SOLID.OCP.Correct;

public class PriceCalculator
{
    private readonly IPriceTable _priceTable;
    private readonly IDeliveryService _deliveryService;

    public PriceCalculator(IDeliveryService deliveryService, IPriceTable priceTable)
    {
        _deliveryService = deliveryService;
        _priceTable = priceTable;
    }

    public double Calculate(Purchase purchase)
    {
        var discount = _priceTable.DiscountTo(purchase.Value);

        var shipping = _deliveryService.Calculate(purchase.City);

        return purchase.Value * (1 - discount) + shipping;
    }
}

public interface IPriceTable
{
    double DiscountTo(double value);
}

public interface IDeliveryService
{
    double Calculate(string city);
}

public class StandardPriceTable : IPriceTable
{
    public double DiscountTo(double value) => 0;
}

public class DifferentiatedPriceTable : IPriceTable
{
    public double DiscountTo(double value) => 0;
}

public class Correios : IDeliveryService
{
    public double Calculate(string city) => 0;
}