using State7Demo._2_ImplementConcreteStates;
using State7Demo._3_ContextClass;

var order = new OrderContext(new OrderedState());
order.Pay();   // Pay for the order
order.Ship();  // Attempt to ship, will transition to ShippedState
order.Deliver(); // Finally, mark the order as delivered