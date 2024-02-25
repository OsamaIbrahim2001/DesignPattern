using CommandPattern.Core;
using CommandPattern.Core.Commands;

var laptop = new Product(1, "Laptop", 15000, 10);
var keyboard = new Product(1, "Keyboard", 300, 16);
var mouse = new Product(1, "Mouse", 140, 22);

while (true)
{
    Order order = new();
    CommandInvocker invocker = new();
    while (true)
    {
        Console.WriteLine("Select Product ID : ");
        Console.WriteLine("\t1. Laptop");
        Console.WriteLine("\t2. Keyboard");
        Console.WriteLine("\t3. Mouse");
        Console.WriteLine("\t0. Exit");

        int commandId = int.Parse(Console.ReadLine());
        if (commandId == 1)
        {
            invocker.AddCommand(new AddProductCommand(order, laptop, 1));
            invocker.AddCommand(new AddStockCommand(laptop, -1));
        }
        else if (commandId == 2)
        {
            invocker.AddCommand(new AddProductCommand(order, keyboard, 1));
            invocker.AddCommand(new AddStockCommand(keyboard, -1));
        }
        else if (commandId == 3)
        {
            invocker.AddCommand(new AddProductCommand(order, mouse, 1));
            invocker.AddCommand(new AddStockCommand(mouse, -1));
        }
        else if (commandId == 0)
        {
            invocker.ExecudeCommands();
            var totalQunatities = order.Lines.Sum(l => l.Qunaity);
            var totalPrice = order.Lines.Sum(l => l.UnitPrice * l.Qunaity);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Order #{order.Id} created: Quantity= {totalQunatities} TotalPrice={totalPrice}");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        }
    }
    Console.WriteLine("----------------------------------------");
}