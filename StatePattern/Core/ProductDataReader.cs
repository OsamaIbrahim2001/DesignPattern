namespace StatePattern.Core
{
    internal class ProductDataReader
    {
        public IEnumerable<Product> GetProducts()
        {
            return new[]{
        new Product(){Id=1,Name="Laptop",UnitPrice=10000 },
        new Product(){Id=2,Name="Keyboard",UnitPrice=150},
        new Product(){Id=3,Name="Mouse",UnitPrice=300}
        };
        }
    }
}
