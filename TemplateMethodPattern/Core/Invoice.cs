namespace TemplateMethodPattern.Core
{
    internal class Invoice
    {
        public Customer Customer { get; set; }
        public IEnumerable<InvoiceLine> Lines { get; set; }
        public double TotalPrice => Lines.Sum(p => p.Quantity * p.UnitPrice)+Taxes;
        public double DiscountPercentage { get; set; }
        public double Taxes { get; set; }
        public double NetPrice => TotalPrice - (TotalPrice * DiscountPercentage);
    }
}
