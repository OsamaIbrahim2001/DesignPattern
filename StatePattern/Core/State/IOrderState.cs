namespace StatePattern.Core.State
{
    internal interface IOrderState
    {
        void Confirm();
        void Cancel();
        void Process();
        void Ship();
        void Deliver();
        void Return();
    }
}
