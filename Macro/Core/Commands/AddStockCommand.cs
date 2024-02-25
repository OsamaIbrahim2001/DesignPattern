namespace UndoRedo.Core.Commands
{
    internal class AddStockCommand : ICommand
    {
        private readonly Product product;
        private readonly int quantity;

        public AddStockCommand(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public void Execute()
        {
            product.AddStock(quantity);
        }
    }
}
