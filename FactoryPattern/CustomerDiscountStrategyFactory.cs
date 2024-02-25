using FactoryPattern.Core;
using FactoryPattern.DiscountStrategies;

namespace FactoryPattern
{
    internal class CustomerDiscountStrategyFactory
    {
        internal ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory category) {
            InvoiceManager invoiceManager = new();
            if (category == CustomerCategory.Gold)
                return new GoldenCustomerDiscountStrategy();
            else if (category == CustomerCategory.Silver)
               return new SilverCustomerDiscountStrategy();
            return null;
        }
    }
}
