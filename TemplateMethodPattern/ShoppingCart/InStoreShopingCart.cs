using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShoppingCart
{
    internal class InStoreShopingCart : ShoppingCart
    {
        protected override void ApplyDiscount(Invoice invoice)
        {

        }
    }
}
