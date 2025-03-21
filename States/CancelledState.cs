namespace design_pattern_state.States;

internal sealed class CancelledState : IOrderState
{
    public void Cancel(OrderContext order)
    {
        Console.WriteLine("Order is cancelled.");
    }

    public void Next(OrderContext order)
    {
        Console.WriteLine("Unable to change state. Order is cancelled.");
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is cancelled.");
    }
}
