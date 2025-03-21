namespace design_pattern_state.States;

internal sealed class ShippedState : IOrderState
{
    public void Cancel(OrderContext order)
    {
        Console.WriteLine("The order has already been delivered. It cannot be cancelled.");
    }

    public void Next(OrderContext order)
    {
        order.SetState(new DeliveredState());
        Console.WriteLine("Order delivered.");
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order shipped. Waiting for delivery.");
    }
}
