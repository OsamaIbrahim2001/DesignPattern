namespace TemplateMethodPattern.DiscountStrategies
{
    internal class NullCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice) => 0;
       
    }
}
