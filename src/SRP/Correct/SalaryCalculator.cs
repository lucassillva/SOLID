using SOLID.SRP.Common;

namespace SOLID.SRP.Correct;

public class SalaryCalculator
{
    public double Calculate(Employee employee)
    {
        return new CalculationRule(employee).Calculate();
    }
}

public class CalculationRule
{
    private IRule _rule { get; }
    private Employee _employee { get; }

    public CalculationRule(Employee employee)
    {
        // Dictionary<Position, IRule>
    }

    public double Calculate() => _rule.Calculate(_employee.Salary);
}

public interface IRule
{
    double Calculate(double value);
}