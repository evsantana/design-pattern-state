namespace design_pattern_state.States;

internal sealed class DeliveredState : IOrderState
{
    public void Cancel(OrderContext order)
    {
        Console.WriteLine("The order has already been delivered. It cannot be cancelled.");
    }

    public void Next(OrderContext order)
    {
        Console.WriteLine("The order has already been delivered. It cannot be changed.");
    }

    public void PrintStatus()
    {
        Console.WriteLine("The order was delivered successfully.");
    }
}
