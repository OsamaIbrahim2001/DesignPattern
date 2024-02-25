namespace SalesSystemPaymentsAbstraction
{
    public class Payment
    {
        public int CustomerId { get; set; }
        public double ChargeAmount { get; set; }
        public Guid RefrenceNumber { get; set; }
    }
}
