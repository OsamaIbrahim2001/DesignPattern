namespace StatePattern.Core.State
{
    internal class ConfirmOrderState : IOrderState
    {
        private readonly Order _order;
        public ConfirmOrderState(Order order)
        {
            _order = order;
        }
        public void Cancel()
        {
            _order.State = new CancelOrderState();
        }

        public void Confirm()
        {
            throw new NotImplementedException();
        }

        public void Deliver()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            _order.State = new ProcessOrderState(_order);
        }

        public void Return()
        {
            throw new NotImplementedException();
        }

        public void Ship()
        {
            throw new NotImplementedException();
        }
    }
}
