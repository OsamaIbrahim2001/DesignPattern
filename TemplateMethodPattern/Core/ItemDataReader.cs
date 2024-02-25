namespace TemplateMethodPattern.Core
{
    internal class ItemDataReader
    {
        public IEnumerable<Item> GetItems()
        {
            return new[]{
        new Item(){ItemId=1,Name="Laptop",UnitPrice=10000 },
        new Item(){ItemId=2,Name="Keyboard",UnitPrice=150},
        new Item(){ItemId=3,Name="Mouse",UnitPrice=300}
        };
        }
    }
}
