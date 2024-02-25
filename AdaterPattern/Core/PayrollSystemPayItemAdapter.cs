namespace AdaterPattern.Core
{
    public class PayrollSystemPayItemAdapter
    {
        private readonly PayItem _payItem;

        public PayrollSystemPayItemAdapter(PayItem payItem)
        {
            _payItem = payItem;
        }
        public decimal Value => _payItem.IsDeductive ? _payItem.Value * -1 : _payItem.Value;
        public string Name => _payItem.Name;
    }
}
