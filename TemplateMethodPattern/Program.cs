using TemplateMethodPattern.Core;
using TemplateMethodPattern.ShoppingCart;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();
var itemReader=new ItemDataReader();
var items = itemReader.GetItems();
while (true)
{
    Console.WriteLine("Customer List");
    foreach (var item in customers)
        Console.WriteLine($"\t {item.Id}. {item.Name} {item.CustomerCategory}");
    Console.WriteLine();
    
    Console.WriteLine("Item List");
    foreach (var item in items)
        Console.WriteLine($"\t {item.ItemId}. {item.Name} {item.UnitPrice}");
    Console.WriteLine();

    Console.Write("Enter Customer ID: ");
    var customerId = int.Parse(Console.ReadLine());
    Console.Write("Enter Item ID: ");
    
    //Console.Write("Enter Unit Price: ");
    //var unitPrice = int.Parse(Console.ReadLine());

    var customer = customers.FirstOrDefault(c => c.Id == customerId);
    Console.WriteLine("Select Shopping Cart Type (Online | InStore): ");
    ShoppingCart shoppingCart = Console.ReadLine().Equals("Online",StringComparison.OrdinalIgnoreCase) ? new OnlineShoppingCart() : new InStoreShopingCart();
    while (true)
    {
        Console.WriteLine("Enter 0 to complete order Enter Item Id");
        var itemId =int.Parse(Console.ReadLine());
        if (itemId == 0)
            break;
        Console.Write("Enter Item Quantity: ");
        var quantity = int.Parse(Console.ReadLine());
        shoppingCart.AddItem(itemId,quantity,items.First(i=>i.ItemId==itemId).UnitPrice);
    }
    shoppingCart.Checkout(customer);
    ////var invoiceManager = new InvoiceManager();
    ////invoiceManager.SetStrategy(new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategy(customer.CustomerCategory));
    ////var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);
    //Console.WriteLine($"Invoice Create for Customer {invoice.Customer.Name} with net price {invoice.NetPrice}");
    Console.WriteLine("Press any key to create another invoice");
    Console.ReadKey();
    Console.WriteLine("-----------------------------");
}