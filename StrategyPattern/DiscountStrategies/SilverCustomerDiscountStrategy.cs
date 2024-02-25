namespace StrategyPattern.DiscountStrategies
{
    internal class SilverCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        => totalPrice >= 10000 ? .05 : 0;
    }
}
