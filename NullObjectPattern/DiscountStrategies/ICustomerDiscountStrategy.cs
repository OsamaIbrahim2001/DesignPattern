namespace NullObjectPattern.DiscountStrategies
{
    internal interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
