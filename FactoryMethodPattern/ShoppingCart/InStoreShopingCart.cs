using FactoryMethodPattern.Core;

namespace FactoryMethodPattern.ShoppingCart
{
    internal class InStoreShopingCart : ShoppingCart
    {
        protected override void ApplyDiscount(Invoice invoice)
        {

        }
    }
}
