using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShoppingCart
{
    internal abstract class ShoppingCart
    {
        private List<InvoiceLine> _lines = new();
        public void AddItem(int itemId, int quantity, double unitPrice)
        {
            _lines.Add(new InvoiceLine() { ItemId = itemId, Quantity = quantity, UnitPrice = unitPrice });
        }

        public void Checkout(Customer customer)
        {
            Invoice invoice = new()
            {
                Customer = customer,
                Lines = _lines
            };
            ApplayTaxes(invoice);
            ApplyDiscount(invoice);
            ProcessPayment(invoice);
        }

        private void ApplayTaxes(Invoice invoice)
        {
            invoice.Taxes = invoice.TotalPrice * .15;
        }
        protected abstract void ApplyDiscount(Invoice invoice);
        private void ProcessPayment(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{GetType().Name} Invoice create by {invoice.Customer.Name} with net price {invoice.NetPrice}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
