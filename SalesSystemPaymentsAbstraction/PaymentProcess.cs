namespace SalesSystemPaymentsAbstraction
{
    public abstract class PaymentProcess
    {
        public Payment ProcessPayment(int customerId, double amount)
        {
            return CreatePaymentMethod().Charge(customerId, amount);
        }

        public abstract IPaymentMethod CreatePaymentMethod();
    }
}
