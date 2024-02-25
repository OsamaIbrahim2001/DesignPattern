namespace AdaterPattern.Core
{
    public class PayrollSystemEmployeeAdapter
    {
        private readonly Employee _employee;
        private IEnumerable<PayrollSystemPayItemAdapter> _payItems;
        public PayrollSystemEmployeeAdapter(Employee employee)
        {
            _employee = employee;
            _payItems=employee.PayItems.Select(payItem=>new PayrollSystemPayItemAdapter(payItem)).ToList();
        }
        public string FullName => _employee.FullName;
        public IEnumerable<PayrollSystemPayItemAdapter> PayItems => _payItems;
    }
}
