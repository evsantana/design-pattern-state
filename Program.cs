using design_pattern_state;

OrderContext order = new OrderContext();

order.PrintStatus();
order.NextState();

order.PrintStatus();
order.NextState();

order.PrintStatus();
order.NextState();

order.PrintStatus();
order.NextState();

order.CancelOrder();