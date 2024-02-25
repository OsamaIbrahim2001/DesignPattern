namespace StatePattern.Core.State
{
    internal class DeliverOrderState : IOrderState
    {
        private Order _order;
        public DeliverOrderState(Order order)
        {
            _order = order;
        }
        public void Cancel()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Return()
        {
            _order.State = new ReturnOrderState(_order);
        }

        public void Ship()
        {
            throw new NotImplementedException();
        }
    }
}
