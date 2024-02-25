namespace UndoRedo.Core.Commands
{
    internal class AddProductCommand : ICommand
    {
        internal Order Order;
        private readonly Product product;
        private readonly int qunatity;

        public AddProductCommand(Order order,Product product,int qunatity)
        {
            Order = order;
            this.product = product;
            this.qunatity = qunatity;
        }
        public void Execute()
        {
            Order.AddProduct(product, qunatity);
        }
    }
}
