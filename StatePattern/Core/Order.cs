using StatePattern.Core.State;

namespace StatePattern.Core
{
    internal class Order
    {
        public Order()
        {
            State = new DriftOrderState(this); 
        }
        public IOrderState State { get; set; }
        public List<OrderLine> Lines { get; set; } = new();
        //public void SetState(OrderState newState)
        //{
        //    if ((State == OrderState.Draft && newState != OrderState.Confirmed)
        //            || (State == OrderState.Confirmed && (newState != OrderState.Canceled && newState != OrderState.UnderProcessing))
        //            || (State == OrderState.UnderProcessing && newState != OrderState.Shipped)
        //            || (State == OrderState.Shipped && newState != OrderState.Delivered)
        //            || (State == OrderState.Delivered && newState != OrderState.Returned))
        //        throw new InvalidOperationException($"Moving from state {State} to state {newState} is not supported");
        //    else State = newState;
        //}

        public void ConfirmState() => State.Confirm();
        public void CancelState() => State.Cancel();
        public void ProcessState() => State.Process();
        public void ShipState() => State.Ship();
        public void DeliverState() => State.Deliver();
        public void ReturnState() => State.Return();
    }
}
