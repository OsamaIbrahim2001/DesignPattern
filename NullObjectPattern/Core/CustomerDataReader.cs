namespace NullObjectPattern.Core
{
    internal class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[] {
        new Customer() {Id=1,Name="Osama",CustomerCategory=CustomerCategory.Gold},
        new Customer() {Id=2,Name="Mostafa",CustomerCategory=CustomerCategory.Silver},
                new Customer() {Id=3,Name="Eslam",CustomerCategory=CustomerCategory.None}
        };
        }
    }
}
