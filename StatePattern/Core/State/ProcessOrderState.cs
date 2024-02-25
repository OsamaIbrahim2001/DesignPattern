namespace StatePattern.Core.State
{
    internal class ProcessOrderState : IOrderState
    {
        private Order _order;
        public ProcessOrderState(Order order)
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
            throw new NotImplementedException();
        }

        public void Ship()
        {
            _order.State = new ShipOrderState(_order);
        }
    }
}
