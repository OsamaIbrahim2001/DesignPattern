using FactoryMethodPattern.Core;
using SalesSystemPaymentsAbstraction;

namespace FactoryMethodPattern.ShoppingCart
{
    internal abstract class ShoppingCart
    {
        private List<InvoiceLine> _lines = new();
        public void AddItem(int itemId, int quantity, double unitPrice)
        {
            _lines.Add(new InvoiceLine() { ItemId = itemId, Quantity = quantity, UnitPrice = unitPrice });
        }

        public void Checkout(Customer customer, PaymentProcess paymentProcess)
        {
            Invoice invoice = new()
            {
                Customer = customer,
                Lines = _lines
            };
            ApplayTaxes(invoice);
            ApplyDiscount(invoice);
            ProcessPayment(invoice, paymentProcess);
        }

        private void ApplayTaxes(Invoice invoice)
        {
            invoice.Taxes = invoice.TotalPrice * .15;
        }
        protected abstract void ApplyDiscount(Invoice invoice);
        private void ProcessPayment(Invoice invoice, PaymentProcess paymentProcess)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{GetType().Name} Invoice create by {invoice.Customer.Name} with net price {invoice.NetPrice}");
            var payment = paymentProcess.ProcessPayment(invoice.Customer.Id, invoice.NetPrice);
            Console.WriteLine($"Customer charged with {payment.ChargeAmount} with refrence number {payment.RefrenceNumber}");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
