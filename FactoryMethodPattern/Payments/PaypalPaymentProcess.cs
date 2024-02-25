using SalesSystemPaymentsAbstraction;

namespace FactoryMethodPattern.Payments
{
    internal class PaypalPaymentProcess : PaymentProcess
    {
        public override IPaymentMethod CreatePaymentMethod()
        {
            return new PaypalPaymentMethod();
        }
    }
}
