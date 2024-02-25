namespace PayrollSystem.Core
{
    public class PayrollCalaculator
    {
        public decimal Calculate(Employee employee)
        {
            Console.WriteLine($"Calculate salary for employee {employee.FullName}");
            if (employee.PayItems?.Any() == false)
                return 0;
            var monthTotal = employee.PayItems.Sum(pay => pay.Value);
            return Math.Round(monthTotal / DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) * DateTime.Today.Day, 2);
        }
    }
}
