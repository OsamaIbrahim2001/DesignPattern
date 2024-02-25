

using StatePattern.Core;

var dataReader = new ProductDataReader();
var products = dataReader.GetProducts();

while (true)
{
    Console.WriteLine("Product List");
    foreach (var item in products)
        Console.WriteLine($"\t {item.Id}. {item.Name} {item.UnitPrice}");
    Console.WriteLine();

    Order order = new();
    Console.WriteLine($"State is {order.State}");

    while (true)
    {
        Console.WriteLine("Enter Product Id (0 to complete the order): ");
        var productId = int.Parse(Console.ReadLine());
        if (productId == 0)
            break;
        Console.Write("Enter Item Quantity: ");
        var quantity = int.Parse(Console.ReadLine());

        Product product = products.First(p => p.Id == productId);
        order.Lines.Add(new OrderLine()
        {
            ProductId = productId,
            Quantity = quantity,
            UnitPrice = product.UnitPrice
        });
    }

    while (true)
    {
        Console.WriteLine("Select Action : ");
        Console.WriteLine("\t1. Confirm");
        Console.WriteLine("\t2. UnderProcessing");
        Console.WriteLine("\t3. Canceled");
        Console.WriteLine("\t4. Shipped");
        Console.WriteLine("\t5. Delivered");
        Console.WriteLine("\t6. Returned");
        Console.WriteLine("\t0. Exit");

        int action = int.Parse(Console.ReadLine());
        try
        {
            if (action == 0)
                break;
            else if (action == 1)
                order.ConfirmState();
            else if (action == 2)
                order.ProcessState();
            else if (action == 3)
                order.CancelState();
            else if (action == 4)
                order.ShipState();
            else if (action == 5)
                order.DeliverState();
            else if (action == 6)
                order.ReturnState();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order state changed to {order.State}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    Console.WriteLine("Press any key to create another order");
    Console.ReadKey();
    Console.WriteLine("-----------------------------");
}