namespace CommandPattern.Core
{
    internal class Order
    {
        public int Id { get; } = Random.Shared.Next(1, 1000);
        private List<OrderLine> _lines = new();
        public IEnumerable<OrderLine> Lines => _lines.AsReadOnly();

        public void AddProduct(Product product, int quantity)
        {
            _lines.Add(new OrderLine() { ProductId = product.Id, UnitPrice = product.UnitPrice, Qunaity = quantity });
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Product {product.Name} added, Order now contains {_lines.Count} products");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
