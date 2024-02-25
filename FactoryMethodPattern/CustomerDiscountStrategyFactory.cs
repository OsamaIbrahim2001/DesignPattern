using FactoryMethodPattern.Core;
using FactoryMethodPattern.DiscountStrategies;

namespace FactoryMethodPattern
{
    internal class CustomerDiscountStrategyFactory
    {
        internal ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory category) {
            if (category == CustomerCategory.Gold)
                return new GoldenCustomerDiscountStrategy();
            else if (category == CustomerCategory.Silver)
               return new SilverCustomerDiscountStrategy();
            return new NullCustomerDiscountStrategy();
        }
    }
}
