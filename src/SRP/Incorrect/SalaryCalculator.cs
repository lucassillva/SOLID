using SOLID.SRP.Common;

namespace SOLID.SRP.Incorrect;

public class SalaryCalculator
{
    public double Calculate(Employee employee)
    {
        if (employee.Position.Equals("Developer"))
            return employee.Salary * 0.9;

        if (employee.Position.Equals("Manager"))
            return employee.Salary * 0.75;

        // ifs

        throw new ArgumentException("Invalid Employee!");
    }
}

// Não para de crescer (ifs)
// Várias regras de cálculo diferentes
// As regras podem compartilhar implementações (e bugs)