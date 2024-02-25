using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShoppingCart
{
    internal class OnlineShoppingCart : ShoppingCart
    {
        protected override void ApplyDiscount(Invoice invoice)
        {
            invoice.DiscountPercentage = invoice.TotalPrice >= 10000 ? .1 : 0;
        }
    }
}
