using SalesSystemPaymentsAbstraction;

namespace FactoryMethodPattern.Payments
{
    internal class PaypalPaymentMethod : IPaymentMethod
    {
        public Payment Charge(int customerId, double amount)
        {
            return new Payment()
            {
                CustomerId = customerId,
                RefrenceNumber = Guid.NewGuid(),
                ChargeAmount = amount + amount * 0.05
            };
        }
    }
}
