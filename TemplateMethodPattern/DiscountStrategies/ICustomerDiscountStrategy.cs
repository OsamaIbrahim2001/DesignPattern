namespace TemplateMethodPattern.DiscountStrategies
{
    internal interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
