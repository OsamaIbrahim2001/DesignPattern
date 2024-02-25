namespace NullObjectPattern.DiscountStrategies
{
    internal class GoldenCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice) => totalPrice >= 10000 ? .1 : 0;
        
    }
}
