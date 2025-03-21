namespace design_pattern_state.States;

internal sealed class PaidState : IOrderState
{
    public void Cancel(OrderContext order)
    {
        order.SetState(new CancelledState());
        Console.WriteLine("Order is cancelled.");
    }

    public void Next(OrderContext order)
    {
        order.SetState(new ShippedState());
        Console.WriteLine("Order shipped!");
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order paid. Waiting for shipping.");
    }
}

