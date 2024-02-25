using UndoRedo.Core;
using UndoRedo.Core.Commands;
using UndoRedo.Core.Macro;

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
        Console.WriteLine("\t4. Save Macro");
        Console.WriteLine("\t5. Replay Macro");
        Console.WriteLine("\t6. Undo");
        Console.WriteLine("\t7. Redo");
        Console.WriteLine("\t0. Process");

        int commandId = int.Parse(Console.ReadLine());
        if (commandId == 1)
        {
            invocker.ExecudeCommand(new AddProductCommand(order, laptop, 1));
            invocker.ExecudeCommand(new AddStockCommand(laptop, -1));
        }
        else if (commandId == 2)
        {
            invocker.ExecudeCommand(new AddProductCommand(order, keyboard, 1));
            invocker.ExecudeCommand(new AddStockCommand(keyboard, -1));
        }
        else if (commandId == 3)
        {
            invocker.ExecudeCommand(new AddProductCommand(order, mouse, 1));
            invocker.ExecudeCommand(new AddStockCommand(mouse, -1));
        }
        else if (commandId == 4)
        {
            MacroSotrage.Instance.CreateMacro(invocker.GetCommands());
            invocker.ClearCommands();
        }
        else if (commandId == 5)
        {
            ReplayMacro();
        }
        else if (commandId == 6)
        {
            invocker.Undo();
            invocker.Undo();
            var totalQunatities = order.Lines.Sum(l => l.Qunaity);
            var totalPrice = order.Lines.Sum(l => l.UnitPrice * l.Qunaity);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Order #{order.Id} created: Quantity= {totalQunatities} TotalPrice={totalPrice}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (commandId == 7)
        {
            invocker.Redo();
            invocker.Redo();
            var totalQunatities = order.Lines.Sum(l => l.Qunaity);
            var totalPrice = order.Lines.Sum(l => l.UnitPrice * l.Qunaity);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Order #{order.Id} created: Quantity= {totalQunatities} TotalPrice={totalPrice}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (commandId == 0)
        {
            invocker.ExecudeCommands();
            var totalQunatities = order.Lines.Sum(l => l.Qunaity);
            var totalPrice = order.Lines.Sum(l => l.UnitPrice * l.Qunaity);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Order #{order.Id} created: Quantity= {totalQunatities} TotalPrice={totalPrice}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    Console.WriteLine("----------------------------------------");
}

void ReplayMacro()
{
    Console.WriteLine("Enter Macro Id");

    foreach (var macro in MacroSotrage.Instance.GetMacros())
    {
        Console.WriteLine($"\t{macro.Id}. (Command Count: {macro.Commands.Count()}, Created At : {macro.CreatedAt:yyyy-MM-dd HH:mm:ss})");
    }
    int macroId = int.Parse(Console.ReadLine());
    var selectedMacro = MacroSotrage.Instance.GetMacro(macroId);

    Order order = new();
    CommandInvocker invocker = new();

    foreach (var command in selectedMacro.Commands)
    {
        if (command is AddProductCommand addProductCommand)
            addProductCommand.Order = order;
        invocker.AddCommand(command);
    }
    invocker.ExecudeCommands();
}