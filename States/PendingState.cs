namespace design_pattern_state.States;

internal sealed class PendingState : IOrderState
{
    public void Cancel(OrderContext order)
    {
        order.SetState(new CancelledState());
        Console.WriteLine("Order is cancelled.");
    }

    public void Next(OrderContext order)
    {
        order.SetState(new PaidState());
        Console.WriteLine("Order paid.");
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is pending.");
    }
}

