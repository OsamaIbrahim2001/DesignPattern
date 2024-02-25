using StrategyPattern.DiscountStrategies;

namespace StrategyPattern.Core
{
    internal class InvoiceManager
    {
        private ICustomerDiscountStrategy _customerDiscountStrategy;
        internal void SetStrategy(ICustomerDiscountStrategy customerDiscountStrategy)
        {
            _customerDiscountStrategy = customerDiscountStrategy;
        }

        public Invoice CreateInvoice(Customer customer, int quantity, double unitPrice)
        {
            Invoice invoice = new()
            {
                Customer = customer,
                Lines = new[] {
                    new InvoiceLine() { Quantity = quantity, UnitPrice = unitPrice }
                },
            };
            invoice.DiscountPercentage = _customerDiscountStrategy.CalculateDiscount(invoice.TotalPrice);
            return invoice;
        }
    }
}
