namespace UndoRedo.Core
{
    internal class Product
    {
        public Product(int id, string name, double unitPrice,int stockBalance)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            StockBalance = stockBalance;
        }
        public int Id { get;private set; }
        public string Name { get;private set; }
        public double UnitPrice { get; private set; }
        public int StockBalance { get; private set; }

        public void AddStock(int quantity)
        {
            StockBalance += quantity;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Product {Name} Stock Changed to {StockBalance}");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
