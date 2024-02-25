using NullObjectPattern;
using NullObjectPattern.Core;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();
while (true)
{
    Console.WriteLine("Customer List");
    foreach (var item in customers)
        Console.WriteLine($"\t {item.Id}. {item.Name} {item.CustomerCategory}");
    Console.WriteLine();
    Console.Write("Enter Customer ID: ");
    var id = int.Parse(Console.ReadLine());
    Console.Write("Enter Item Quantity: ");
    var quantity = int.Parse(Console.ReadLine());
    Console.Write("Enter Unit Price: ");
    var unitPrice = int.Parse(Console.ReadLine());

    var customer = customers.First(c => c.Id == id);
    var invoiceManager = new InvoiceManager();
    invoiceManager.SetStrategy(new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategy(customer.CustomerCategory));
    var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);
    Console.WriteLine($"Invoice Create for Customer {invoice.Customer.Name} with net price {invoice.NetPrice}");
    Console.WriteLine("Press any key to create another invoice");
    Console.ReadKey();
    Console.WriteLine("-----------------------------");
}