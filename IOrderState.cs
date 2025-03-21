namespace design_pattern_state;

internal interface IOrderState
{
    void Next(OrderContext order);
    void Cancel(OrderContext order);
    void PrintStatus();
}