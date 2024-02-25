namespace CommandPattern.Core.Commands
{
    internal class AddProductCommand : ICommand
    {
        private readonly Order order;
        private readonly Product product;
        private readonly int qunatity;

        public AddProductCommand(Order order,Product product,int qunatity)
        {
            this.order = order;
            this.product = product;
            this.qunatity = qunatity;
        }
        public void Execute()
        {
            order.AddProduct(product, qunatity);
        }
    }
}
