using SalesSystemPaymentsAbstraction;

namespace FactoryMethodPattern.Payments
{
    internal class VissaPaymentMethod : IPaymentMethod
    {
        public Payment Charge(int customerId, double amount)
        {
            return new Payment()
            {
                CustomerId = customerId,
                RefrenceNumber = Guid.NewGuid(),
                ChargeAmount = amount < 10000 ? amount + amount * .02 : amount
            };
        }
    }
}
