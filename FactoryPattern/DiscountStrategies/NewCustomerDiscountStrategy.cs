namespace FactoryPattern.DiscountStrategies
{
    internal class NewCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice) => 0;
        
    }
}
