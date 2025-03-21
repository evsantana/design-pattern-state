using design_pattern_state.States;

namespace design_pattern_state;

internal sealed class OrderContext
{
    private IOrderState _orderState;
    
    public OrderContext()
    {
        _orderState = new PendingState();
    }

    public void SetState(IOrderState state)
    {
        _orderState = state;
    }

    public void NextState()
    {
        _orderState.Next(this);
    }

    public void CancelOrder()
    { 
        _orderState.Cancel(this); 
    }

    public void PrintStatus()
    {
        _orderState.PrintStatus();
    }
}

