using StrategyPattern.Core;
using StrategyPattern.DiscountStrategies;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();
while (true)
{
    Console.WriteLine("Customer List: [1] Osama [2] Mostafa");
    Console.Write("Enter Customer ID: ");
    var id = int.Parse(Console.ReadLine());
    Console.Write("Enter Item Quantity: ");
    var quantity = int.Parse(Console.ReadLine());
    Console.Write("Enter Unit Price: ");
    var unitPrice = int.Parse(Console.ReadLine());

    var customer = customers.First(c => c.Id == id);
    var invoiceManager = new InvoiceManager();

    if (customer.CustomerCategory == CustomerCategory.Gold)
        invoiceManager.SetStrategy(new GoldenCustomerDiscountStrategy());
    else if (customer.CustomerCategory == CustomerCategory.Silver)
        invoiceManager.SetStrategy(new SilverCustomerDiscountStrategy());
    var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);
    Console.WriteLine($"Invoice Create for Customer {invoice.Customer.Name} with net price {invoice.NetPrice}");
    Console.WriteLine("Press any key to create another invoice");
    Console.ReadKey();
    Console.WriteLine("-----------------------------");
}