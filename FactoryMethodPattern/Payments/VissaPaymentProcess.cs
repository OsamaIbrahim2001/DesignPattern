using SalesSystemPaymentsAbstraction;

namespace FactoryMethodPattern.Payments
{
    internal class VissaPaymentProcess : PaymentProcess
    {
        public override IPaymentMethod CreatePaymentMethod()
        {
            return new VissaPaymentMethod();
        }
    }
}
