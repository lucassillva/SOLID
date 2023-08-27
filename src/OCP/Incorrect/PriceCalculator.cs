using SOLID.OCP.Common;

namespace SOLID.OCP.Incorrect;

public class PriceCalculator
{
    public double Calculate(Purchase purchase)
    {
        double discount = 0;
        var correios = new Correios();

        if (purchase.Value > 100) // Rule 1
        {
            var standardPriceTabletable = new StandardPriceTable();
            discount = standardPriceTabletable.DiscountTo(purchase.Value);
        }

        if (purchase.Value > 200) // Rule 2
        {
            var differentiatedPriceTable = new DifferentiatedPriceTable();
            discount = differentiatedPriceTable.DiscountTo(purchase.Value);
        }

        // Rule 3
        // Rule ...

        var shipping = correios.Calculate(purchase.City);

        return purchase.Value * (1 - discount) + shipping;
    }
}

// Muitas regras de desconto, e também pode haver muitas regras de frete
// Está aberta para muitas modificações
// Difícil de manter e testar

public class Correios
{
    public double Calculate(string city) => 0;
}

public class StandardPriceTable
{
    public double DiscountTo(double value) => 0;
}

public class DifferentiatedPriceTable
{
    public double DiscountTo(double value) => 0;
}