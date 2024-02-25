namespace SalesSystemPaymentsAbstraction
{
    public interface IPaymentMethod
    {
        Payment Charge(int customerId, double amount);
    }
}
